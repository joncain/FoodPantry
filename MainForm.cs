using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodPantryLib;
using log4net;

namespace FoodPantryApp
{
    public partial class MainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Stack<int> recentRecords = new Stack<int>(25);

        public MainForm()
        {
            InitializeComponent();
            this.Show();
            log.Debug("MainForm");
        }

        private void textBoxSearchText_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridViewSearchResults.DataSource = null;
            dataGridViewSearchResults.DataMember = null;

            try
            {

                string searchText = ((TextBox)sender).Text;

                if (searchText.Length > 0)
                {
                    FoodPantryLib.Search search = new Search();
                    DataSet searchResults = search.DoSearch(Utility.makeSQLSafe(searchText));
                    dataGridViewSearchResults.DataSource = searchResults;
                    dataGridViewSearchResults.DataMember = searchResults.Tables[0].TableName;
                    //dataGridViewSearchResults.Columns["RecipientID"].Visible = false;

                    foreach (DataGridViewColumn c in dataGridViewSearchResults.Columns)
                    {
                        c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }
        }

        private void dataGridViewSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = getSelectedRecipientId();
            RecipientForm f = new RecipientForm(id);
            f.Show();
            f.BringToFront();

            if (!((DataGridView)sender).Name.Contains("RecentRecords"))
            {
                addToRecentRecords(id);
            }
        }

        private void addToRecentRecords(int RecipientID)
        {
            recentRecords.Push(RecipientID);
            getRecentRecords();
        }

        private void getRecentRecords()
        {
            ClassDb db = new ClassDb();
            db.Exec(string.Format("SELECT oid RecipientID, First || ' ' || Last Name FROM Recipients WHERE oid IN ({0})", String.Join<int>(",", recentRecords)));
            dataGridViewRecentRecords.DataSource = db.Results;
            dataGridViewRecentRecords.DataMember = db.Results.Tables[0].TableName;
            dataGridViewRecentRecords.Columns["RecipientID"].Visible = false;
            dataGridViewRecentRecords.Columns["Name"].HeaderText = "Recently Viewed";
            dataGridViewRecentRecords.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonCreateNewRecipient_Click(object sender, EventArgs e)
        {
            RecipientForm f = new RecipientForm(0);
            f.Show();
            f.BringToFront();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            f.Show();
            f.BringToFront();
        }

        private void dataGridViewSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewSearchResults_MouseDoubleClick(dataGridViewSearchResults, null);
                e.Handled = true;
            }
        }

        private void dataGridViewSearchResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dataGridViewSearchResults.ClearSelection();
                dataGridViewSearchResults.Rows[e.RowIndex].Selected = true;
                contextMenuSearchResults.Show(MousePosition);
            }
        }

        private void recordVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recipient recipient = new Recipient(getSelectedRecipientId());
            SaveResult result = recipient.RecordVisit();

            if (!result.success)
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(result.message);
                return;
            }

            MessageBox.Show("Visit Recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private int getSelectedRecipientId()
        {
            try
            {
                return Convert.ToInt32(dataGridViewSearchResults.SelectedRows[0].Cells["RecipientID"].Value.ToString());
            }
            catch (Exception e)
            {
                log.Error(e);
            }

            return 0;
        }
    }
}

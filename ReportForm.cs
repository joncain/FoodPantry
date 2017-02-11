using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FoodPantryLib;
using log4net;
using System.IO;
using System.Configuration;

namespace FoodPantryApp
{
    public partial class ReportForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ReportForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveResult attendsCalvaryResult = exportDataTable(((DataSet)dataGridViewAttendsCalvary.DataSource).Tables[0], "AttendsCalvary");

                if (!attendsCalvaryResult.success)
                {
                    throw new Exception(attendsCalvaryResult.message);
                }
                
                SaveResult ageSummaryResult = exportDataTable(((DataSet)dataGridViewAgeSummary.DataSource).Tables[0], "AgeSummary");

                if (!ageSummaryResult.success)
                {
                    throw new Exception(ageSummaryResult.message);
                }
                
                SaveResult bagCountResult = exportDataTable(((DataSet)dataGridViewBagCount.DataSource).Tables[0], "BagCount");

                if (!bagCountResult.success)
                {
                    throw new Exception(bagCountResult.message);
                }

                string dbBackupFileName = ConfigurationSettings.AppSettings["exportPath"] + string.Format("{0}_{1}_{2}_FoodPantry.db.backup", dateTimePickerReportDate.Value.Date.ToString("yyyy"), dateTimePickerReportDate.Value.Date.ToString("MM"), dateTimePickerReportDate.Value.Date.ToString("dd"));
                File.Delete(dbBackupFileName);
                File.Copy(ConfigurationSettings.AppSettings["dbPath"], dbBackupFileName);

            }
            catch(Exception ex)
            {
                log.Error(ex);
            }

            MessageBox.Show(string.Format("Export saved to: {0}", ConfigurationSettings.AppSettings["exportPath"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet attendsCalvaryRecords = getReport("visit_attends_calvary_report");

                if (attendsCalvaryRecords.Tables[0].Rows.Count > 0)
                {
                    attendsCalvaryRecords.Tables[0].Rows.Add(null, null, attendsCalvaryRecords.Tables[0].Compute("SUM(RecordCount)", null));
                }

                dataGridViewAttendsCalvary.DataSource = attendsCalvaryRecords;
                dataGridViewAttendsCalvary.DataMember = attendsCalvaryRecords.Tables[0].TableName;

                foreach (DataGridViewColumn c in dataGridViewAttendsCalvary.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch
            {
            }

            try
            {
                DataSet ageSummaryRecords = getReport("visit_age_summary_report");

                if (ageSummaryRecords.Tables[0].Rows.Count > 0)
                {
                    ageSummaryRecords.Tables[0].Rows.Add(null, null, ageSummaryRecords.Tables[0].Compute("SUM(HouseholdCount)", null));
                }

                dataGridViewAgeSummary.DataSource = ageSummaryRecords;
                dataGridViewAgeSummary.DataMember = ageSummaryRecords.Tables[0].TableName;

                foreach (DataGridViewColumn c in dataGridViewAgeSummary.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch
            {
            }
           
            try
            {
                DataSet bagCountRecords = getReport("visit_bag_count_report");

                if (bagCountRecords.Tables[0].Rows.Count > 0)
                {
                    bagCountRecords.Tables[0].Rows.Add(null, null, bagCountRecords.Tables[0].Compute("SUM(HouseholdCount)", null), bagCountRecords.Tables[0].Compute("SUM(BagCount)", null));
                }

                dataGridViewBagCount.DataSource = bagCountRecords;
                dataGridViewBagCount.DataMember = bagCountRecords.Tables[0].TableName;

                foreach (DataGridViewColumn c in dataGridViewBagCount.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch
            {
            }

            try
            {
                DataSet visitCountRecords = getReport("visit_more_than_once_this_month_report");

                if (visitCountRecords.Tables[0].Rows.Count > 0)
                {
                    visitCountRecords.Tables[0].Rows.Add(null, visitCountRecords.Tables[0].Rows.Count, visitCountRecords.Tables[0].Compute("SUM(Visits)", null));
                }

                dataGridViewVisitCount.DataSource = visitCountRecords;
                dataGridViewVisitCount.DataMember = visitCountRecords.Tables[0].TableName;

                foreach (DataGridViewColumn c in dataGridViewVisitCount.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch
            {
            }

            buttonExport.Enabled = true;
        }

        private DataSet getReport(string reportName)
        {
            DataSet d = null;

            try
            {
                string query = File.ReadAllText(ConfigurationSettings.AppSettings["queryPath"] + reportName + ".txt");

                ClassDb db = new ClassDb();

                if (!db.Exec(string.Format(query, dateTimePickerReportDate.Value.Date.ToString("yyyy-MM-dd"))))
                {
                    throw new Exception(db.ErrorMessage);
                }
                d = db.Results;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }

            return d;
        }

        private void dateTimePickerReportDate_Enter(object sender, EventArgs e)
        {
            buttonExport.Enabled = false;
        }

        private SaveResult exportDataTable(DataTable table, string reportName)
        {
            SaveResult result = new SaveResult();

            try
            {
                string exportPath = ConfigurationSettings.AppSettings["exportPath"];
                string fileName = string.Format("{0}_{1}_{2}_{3}.csv", dateTimePickerReportDate.Value.Date.ToString("yyyy"), dateTimePickerReportDate.Value.Date.ToString("MM"), dateTimePickerReportDate.Value.Date.ToString("dd"), reportName);
                string exportDestinationPath = exportPath + fileName;

                StreamWriter sw = new StreamWriter(exportDestinationPath, false);

                string columnHeader = string.Empty;

                foreach (DataColumn column in table.Columns)
                {
                    columnHeader += column.ColumnName + ",";
                }

                sw.WriteLine(columnHeader.TrimEnd(new char[] { ',' }));


                foreach (DataRow row in table.Rows)
                {
                    sw.WriteLine(string.Join(",", row.ItemArray));
                }
               
                sw.Close();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                result.success = false;
                result.message = ex.Message;
            }

            return result;
        }
    }

}

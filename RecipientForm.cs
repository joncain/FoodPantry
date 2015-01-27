using System;
using System.Collections;
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
    public partial class RecipientForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        Recipient _recipient = null;
        bool _dependentsChanged = false;

        public RecipientForm(int id)
        {
            InitializeComponent();
            loadStates();

            _recipient = new Recipient(id);

            if (_recipient.id > 0)
            {
                loadData();
                loadDependents();
                loadVisits();

                this.Text += " - " + _recipient.first + " " + _recipient.last;
            }
        }

        private void loadData()
        {
            try
            {
                if (_recipient.id == 0)
                {
                    return;
                }

                textBoxFirst.Text = _recipient.first;
                textBoxLast.Text = _recipient.last;
                maskedTextBoxDOB.Text = _recipient.dob.ToString("MM/dd/yyyy");
                checkBoxIdVerified.Checked = _recipient.idVerified;
                checkBoxAttendsCalvary.Checked = _recipient.attendsCalvary;
                maskedTextBoxPhone.Text = _recipient.phone.value;

                if (!string.IsNullOrEmpty(_recipient.address.address1))
                {
                    textBoxAddress1.Text = _recipient.address.address1;
                }

                if (!string.IsNullOrEmpty(_recipient.address.address2))
                {
                    textBoxAddress2.Text = _recipient.address.address2;
                }

                if (!string.IsNullOrEmpty(_recipient.address.city))
                {
                    textBoxCity.Text = _recipient.address.city;
                }

                if (!string.IsNullOrEmpty(_recipient.address.state))
                {
                    comboBoxState.SelectedValue = _recipient.address.state;
                }

                if (!string.IsNullOrEmpty(_recipient.address.zipcode))
                {
                    maskedTextBoxZipcode.Text = _recipient.address.zipcode;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }
        }

        private void loadDependents()
        {
            try
            {
                dataGridViewDependents.DataSource = _recipient.Dependents;
                dataGridViewDependents.DataMember = _recipient.Dependents.Tables[0].TableName;
                dataGridViewDependents.Columns["RecipientID"].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }
        }

        private void loadVisits()
        {
            try
            {
                DataSet visits = _recipient.Visits;
                dataGridViewVisits.DataSource = visits;
                dataGridViewVisits.DataMember = visits.Tables[0].TableName;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }
        }
    
        private void loadStates()
        {
            try
            {
                ClassDb db = new ClassDb();
                db.Exec("SELECT StateCode, StateName FROM States ORDER BY StateName ASC");
                comboBoxState.DataSource = db.Results.Tables[0];
                comboBoxState.ValueMember = "StateCode";
                comboBoxState.DisplayMember = "StateName";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(e);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _recipient.first = textBoxFirst.Text;
                _recipient.last = textBoxLast.Text;
                _recipient.dob = DateTime.Parse(maskedTextBoxDOB.Text);
                _recipient.idVerified = checkBoxIdVerified.Checked;
                _recipient.attendsCalvary = checkBoxAttendsCalvary.Checked;
                _recipient.phone.value = maskedTextBoxPhone.Text;
                _recipient.address.address1 = textBoxAddress1.Text;
                _recipient.address.address2 = textBoxAddress2.Text;
                _recipient.address.city = textBoxCity.Text;

                if (comboBoxState.SelectedValue != null)
                {
                    _recipient.address.state = comboBoxState.SelectedValue.ToString();
                }

                _recipient.address.zipcode = maskedTextBoxZipcode.Text;

                if (_recipient.id == 0)
                {
                    ////////////////////////////////////////////////////////
                    //
                    // Check for existing records with same name & DOB
                    //
                    ClassDb db = new ClassDb();
                    if (db.Exec(string.Format("SELECT * FROM Recipients WHERE ParentRecipientID IS NULL AND lower(first||last||dob) = lower('{0}{1}{2}')", _recipient.first, _recipient.last, _recipient.dob.ToString("yyyy-MM-dd"))) && db.Results.Tables[0].Rows.Count > 0)
                    {
                        if (MessageBox.Show("A recipient with the same name and birth date already exist. Are you sure you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                        {
                            return;
                        }
                    }

                }

                SaveResult result = _recipient.Save();

                if (!result.success)
                {
                    throw new Exception(result.message);
                }

                
                
                if (_dependentsChanged)
                {
                    foreach (DataGridViewRow r in dataGridViewDependents.Rows)
                    {
                        if (r.IsNewRow)
                        {
                            continue;
                        }

                        int dependentId = 0;
                        Int32.TryParse(r.Cells[0].Value.ToString(), out dependentId);

                        Recipient dependent = new Recipient();
                        dependent.id = dependentId;
                        dependent.parentId = _recipient.id;
                        dependent.first = r.Cells[1].Value.ToString();
                        dependent.last = r.Cells[2].Value.ToString();
                        dependent.dob = DateTime.Parse(r.Cells[3].Value.ToString());

                        SaveResult depResult = dependent.Save();
                        
                        if (!depResult.success)
                        {
                            throw new Exception(depResult.message);
                        }
                    }

                    _dependentsChanged = false;
                }

                loadDependents();

                MessageBox.Show("Your changes have been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(ex);
            }
        }

        private void buttonRecordVisit_Click(object sender, EventArgs e)
        {
            SaveResult result = _recipient.RecordVisit();

            if (!result.success)
            {
                MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log.Error(result.message);
                return;
            }
            loadVisits();
            MessageBox.Show("Your changes have been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewDependents_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            _dependentsChanged = true;
        }

        private void dataGridViewDependents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _dependentsChanged = true;
        }

        private void dataGridViewDependents_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                try
                {
                    int id = 0;
                    Int32.TryParse(e.Row.Cells["RecipientID"].Value.ToString(), out id);

                    if (id > 0)
                    {
                        Recipient _deleted = new Recipient(id);
                        _deleted.deleted = true;
                        _deleted.Save();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    log.Error(ex);
                }
            }
        }

        private void RecipientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dependentsChanged)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}

namespace FoodPantryApp
{
    partial class RecipientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRequired = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDOB = new System.Windows.Forms.MaskedTextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.checkBoxAttendsCalvary = new System.Windows.Forms.CheckBox();
            this.checkBoxIdVerified = new System.Windows.Forms.CheckBox();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZipcode = new System.Windows.Forms.Label();
            this.groupBoxOptional = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxZipcode = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxDependents = new System.Windows.Forms.GroupBox();
            this.dataGridViewDependents = new System.Windows.Forms.DataGridView();
            this.buttonRecordVisit = new System.Windows.Forms.Button();
            this.groupBoxVisits = new System.Windows.Forms.GroupBox();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxRequired.SuspendLayout();
            this.groupBoxOptional.SuspendLayout();
            this.groupBoxDependents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDependents)).BeginInit();
            this.groupBoxVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRequired
            // 
            this.groupBoxRequired.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxRequired.Controls.Add(this.maskedTextBoxDOB);
            this.groupBoxRequired.Controls.Add(this.labelDOB);
            this.groupBoxRequired.Controls.Add(this.checkBoxAttendsCalvary);
            this.groupBoxRequired.Controls.Add(this.checkBoxIdVerified);
            this.groupBoxRequired.Controls.Add(this.textBoxLast);
            this.groupBoxRequired.Controls.Add(this.labelLast);
            this.groupBoxRequired.Controls.Add(this.labelFirst);
            this.groupBoxRequired.Controls.Add(this.textBoxFirst);
            this.groupBoxRequired.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRequired.Location = new System.Drawing.Point(10, 10);
            this.groupBoxRequired.Name = "groupBoxRequired";
            this.groupBoxRequired.Size = new System.Drawing.Size(416, 147);
            this.groupBoxRequired.TabIndex = 0;
            this.groupBoxRequired.TabStop = false;
            this.groupBoxRequired.Text = "Required Information";
            // 
            // maskedTextBoxDOB
            // 
            this.maskedTextBoxDOB.Location = new System.Drawing.Point(75, 67);
            this.maskedTextBoxDOB.Mask = "00/00/0000";
            this.maskedTextBoxDOB.Name = "maskedTextBoxDOB";
            this.maskedTextBoxDOB.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxDOB.TabIndex = 3;
            this.maskedTextBoxDOB.ValidatingType = typeof(System.DateTime);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(4, 69);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(57, 13);
            this.labelDOB.TabIndex = 5;
            this.labelDOB.Text = "Birth Date:";
            this.labelDOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxAttendsCalvary
            // 
            this.checkBoxAttendsCalvary.AutoSize = true;
            this.checkBoxAttendsCalvary.Location = new System.Drawing.Point(75, 117);
            this.checkBoxAttendsCalvary.Name = "checkBoxAttendsCalvary";
            this.checkBoxAttendsCalvary.Size = new System.Drawing.Size(136, 17);
            this.checkBoxAttendsCalvary.TabIndex = 5;
            this.checkBoxAttendsCalvary.Text = "Attends Calvary Chapel";
            this.checkBoxAttendsCalvary.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdVerified
            // 
            this.checkBoxIdVerified.AutoSize = true;
            this.checkBoxIdVerified.Location = new System.Drawing.Point(75, 93);
            this.checkBoxIdVerified.Name = "checkBoxIdVerified";
            this.checkBoxIdVerified.Size = new System.Drawing.Size(75, 17);
            this.checkBoxIdVerified.TabIndex = 4;
            this.checkBoxIdVerified.Text = "ID Verified";
            this.checkBoxIdVerified.UseVisualStyleBackColor = true;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(75, 44);
            this.textBoxLast.MaxLength = 100;
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(227, 20);
            this.textBoxLast.TabIndex = 2;
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.Location = new System.Drawing.Point(37, 47);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(30, 13);
            this.labelLast.TabIndex = 1;
            this.labelLast.Text = "Last:";
            this.labelLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.Location = new System.Drawing.Point(37, 23);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(29, 13);
            this.labelFirst.TabIndex = 0;
            this.labelFirst.Text = "First:";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(75, 20);
            this.textBoxFirst.MaxLength = 100;
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(227, 20);
            this.textBoxFirst.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(25, 24);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress1.Location = new System.Drawing.Point(16, 48);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(48, 13);
            this.labelAddress1.TabIndex = 3;
            this.labelAddress1.Text = "Address:";
            this.labelAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(9, 72);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 4;
            this.labelAddress2.Text = "Address2:";
            this.labelAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(40, 96);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City:";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(31, 120);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelZipcode
            // 
            this.labelZipcode.AutoSize = true;
            this.labelZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipcode.Location = new System.Drawing.Point(15, 144);
            this.labelZipcode.Name = "labelZipcode";
            this.labelZipcode.Size = new System.Drawing.Size(49, 13);
            this.labelZipcode.TabIndex = 7;
            this.labelZipcode.Text = "Zipcode:";
            this.labelZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxOptional
            // 
            this.groupBoxOptional.Controls.Add(this.maskedTextBoxZipcode);
            this.groupBoxOptional.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxOptional.Controls.Add(this.comboBoxState);
            this.groupBoxOptional.Controls.Add(this.textBoxCity);
            this.groupBoxOptional.Controls.Add(this.textBoxAddress2);
            this.groupBoxOptional.Controls.Add(this.textBoxAddress1);
            this.groupBoxOptional.Controls.Add(this.labelPhone);
            this.groupBoxOptional.Controls.Add(this.labelAddress1);
            this.groupBoxOptional.Controls.Add(this.labelZipcode);
            this.groupBoxOptional.Controls.Add(this.labelAddress2);
            this.groupBoxOptional.Controls.Add(this.labelState);
            this.groupBoxOptional.Controls.Add(this.labelCity);
            this.groupBoxOptional.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOptional.Location = new System.Drawing.Point(10, 157);
            this.groupBoxOptional.Name = "groupBoxOptional";
            this.groupBoxOptional.Size = new System.Drawing.Size(416, 176);
            this.groupBoxOptional.TabIndex = 5;
            this.groupBoxOptional.TabStop = false;
            this.groupBoxOptional.Text = "Optional Information";
            // 
            // maskedTextBoxZipcode
            // 
            this.maskedTextBoxZipcode.Location = new System.Drawing.Point(75, 141);
            this.maskedTextBoxZipcode.Mask = "00000";
            this.maskedTextBoxZipcode.Name = "maskedTextBoxZipcode";
            this.maskedTextBoxZipcode.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxZipcode.TabIndex = 11;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(75, 20);
            this.maskedTextBoxPhone.Mask = "(000)000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxPhone.TabIndex = 6;
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(75, 116);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(227, 21);
            this.comboBoxState.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(75, 92);
            this.textBoxCity.MaxLength = 100;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(227, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(75, 68);
            this.textBoxAddress2.MaxLength = 100;
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddress2.TabIndex = 8;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(75, 44);
            this.textBoxAddress1.MaxLength = 100;
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddress1.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(108, 17);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxDependents
            // 
            this.groupBoxDependents.Controls.Add(this.dataGridViewDependents);
            this.groupBoxDependents.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDependents.Location = new System.Drawing.Point(10, 333);
            this.groupBoxDependents.Name = "groupBoxDependents";
            this.groupBoxDependents.Size = new System.Drawing.Size(416, 116);
            this.groupBoxDependents.TabIndex = 12;
            this.groupBoxDependents.TabStop = false;
            this.groupBoxDependents.Text = "Dependents";
            // 
            // dataGridViewDependents
            // 
            this.dataGridViewDependents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDependents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDependents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDependents.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDependents.MultiSelect = false;
            this.dataGridViewDependents.Name = "dataGridViewDependents";
            this.dataGridViewDependents.Size = new System.Drawing.Size(410, 97);
            this.dataGridViewDependents.TabIndex = 13;
            this.dataGridViewDependents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDependents_CellValueChanged);
            this.dataGridViewDependents.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewDependents_UserAddedRow);
            this.dataGridViewDependents.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewDependents_UserDeletingRow);
            // 
            // buttonRecordVisit
            // 
            this.buttonRecordVisit.Location = new System.Drawing.Point(223, 17);
            this.buttonRecordVisit.Name = "buttonRecordVisit";
            this.buttonRecordVisit.Size = new System.Drawing.Size(86, 23);
            this.buttonRecordVisit.TabIndex = 16;
            this.buttonRecordVisit.Text = "Record &Visit";
            this.buttonRecordVisit.UseVisualStyleBackColor = true;
            this.buttonRecordVisit.Click += new System.EventHandler(this.buttonRecordVisit_Click);
            // 
            // groupBoxVisits
            // 
            this.groupBoxVisits.Controls.Add(this.dataGridViewVisits);
            this.groupBoxVisits.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxVisits.Location = new System.Drawing.Point(10, 449);
            this.groupBoxVisits.Name = "groupBoxVisits";
            this.groupBoxVisits.Size = new System.Drawing.Size(416, 116);
            this.groupBoxVisits.TabIndex = 14;
            this.groupBoxVisits.TabStop = false;
            this.groupBoxVisits.Text = "Visits";
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AllowUserToAddRows = false;
            this.dataGridViewVisits.AllowUserToDeleteRows = false;
            this.dataGridViewVisits.AllowUserToResizeColumns = false;
            this.dataGridViewVisits.AllowUserToResizeRows = false;
            this.dataGridViewVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVisits.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVisits.MultiSelect = false;
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.RowHeadersVisible = false;
            this.dataGridViewVisits.Size = new System.Drawing.Size(410, 97);
            this.dataGridViewVisits.TabIndex = 13;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonRecordVisit);
            this.groupBoxControls.Controls.Add(this.buttonSave);
            this.groupBoxControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxControls.Location = new System.Drawing.Point(10, 565);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(416, 57);
            this.groupBoxControls.TabIndex = 17;
            this.groupBoxControls.TabStop = false;
            // 
            // RecipientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(436, 632);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxVisits);
            this.Controls.Add(this.groupBoxDependents);
            this.Controls.Add(this.groupBoxOptional);
            this.Controls.Add(this.groupBoxRequired);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipientForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecipientForm_FormClosing);
            this.groupBoxRequired.ResumeLayout(false);
            this.groupBoxRequired.PerformLayout();
            this.groupBoxOptional.ResumeLayout(false);
            this.groupBoxOptional.PerformLayout();
            this.groupBoxDependents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDependents)).EndInit();
            this.groupBoxVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRequired;
        private System.Windows.Forms.CheckBox checkBoxAttendsCalvary;
        private System.Windows.Forms.CheckBox checkBoxIdVerified;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZipcode;
        private System.Windows.Forms.GroupBox groupBoxOptional;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxDependents;
        private System.Windows.Forms.DataGridView dataGridViewDependents;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxZipcode;
        private System.Windows.Forms.Button buttonRecordVisit;
        private System.Windows.Forms.GroupBox groupBoxVisits;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDOB;
    }
}
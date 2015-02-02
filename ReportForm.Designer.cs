namespace FoodPantryApp
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupBoxReportDate = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReportDate = new System.Windows.Forms.DateTimePicker();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.groupBoxAttendsCalvary = new System.Windows.Forms.GroupBox();
            this.dataGridViewAttendsCalvary = new System.Windows.Forms.DataGridView();
            this.dataGridViewBagCount = new System.Windows.Forms.DataGridView();
            this.dataGridViewAgeSummary = new System.Windows.Forms.DataGridView();
            this.groupBoxHouseholdCountByAgeGroup = new System.Windows.Forms.GroupBox();
            this.groupBoxBagCount = new System.Windows.Forms.GroupBox();
            this.groupBoxReportDate.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxAttendsCalvary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendsCalvary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgeSummary)).BeginInit();
            this.groupBoxHouseholdCountByAgeGroup.SuspendLayout();
            this.groupBoxBagCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReportDate
            // 
            this.groupBoxReportDate.Controls.Add(this.dateTimePickerReportDate);
            this.groupBoxReportDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxReportDate.Location = new System.Drawing.Point(10, 10);
            this.groupBoxReportDate.Name = "groupBoxReportDate";
            this.groupBoxReportDate.Size = new System.Drawing.Size(695, 59);
            this.groupBoxReportDate.TabIndex = 0;
            this.groupBoxReportDate.TabStop = false;
            this.groupBoxReportDate.Text = "Report Date";
            // 
            // dateTimePickerReportDate
            // 
            this.dateTimePickerReportDate.Location = new System.Drawing.Point(27, 21);
            this.dateTimePickerReportDate.Name = "dateTimePickerReportDate";
            this.dateTimePickerReportDate.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerReportDate.TabIndex = 0;
            this.dateTimePickerReportDate.Enter += new System.EventHandler(this.dateTimePickerReportDate_Enter);
            // 
            // buttonExport
            // 
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(306, 19);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "E&xport";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(389, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControls.Controls.Add(this.buttonView);
            this.groupBoxControls.Controls.Add(this.buttonExport);
            this.groupBoxControls.Controls.Add(this.buttonExit);
            this.groupBoxControls.Location = new System.Drawing.Point(13, 663);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(689, 57);
            this.groupBoxControls.TabIndex = 3;
            this.groupBoxControls.TabStop = false;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(225, 19);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "&View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // groupBoxAttendsCalvary
            // 
            this.groupBoxAttendsCalvary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxAttendsCalvary.Controls.Add(this.dataGridViewAttendsCalvary);
            this.groupBoxAttendsCalvary.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAttendsCalvary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAttendsCalvary.Location = new System.Drawing.Point(10, 69);
            this.groupBoxAttendsCalvary.Name = "groupBoxAttendsCalvary";
            this.groupBoxAttendsCalvary.Size = new System.Drawing.Size(695, 107);
            this.groupBoxAttendsCalvary.TabIndex = 1;
            this.groupBoxAttendsCalvary.TabStop = false;
            this.groupBoxAttendsCalvary.Text = "Head of Household Attends Calvary";
            // 
            // dataGridViewAttendsCalvary
            // 
            this.dataGridViewAttendsCalvary.AllowUserToAddRows = false;
            this.dataGridViewAttendsCalvary.AllowUserToDeleteRows = false;
            this.dataGridViewAttendsCalvary.AllowUserToResizeColumns = false;
            this.dataGridViewAttendsCalvary.AllowUserToResizeRows = false;
            this.dataGridViewAttendsCalvary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendsCalvary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendsCalvary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAttendsCalvary.EnableHeadersVisualStyles = false;
            this.dataGridViewAttendsCalvary.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAttendsCalvary.Name = "dataGridViewAttendsCalvary";
            this.dataGridViewAttendsCalvary.ReadOnly = true;
            this.dataGridViewAttendsCalvary.RowHeadersVisible = false;
            this.dataGridViewAttendsCalvary.Size = new System.Drawing.Size(689, 88);
            this.dataGridViewAttendsCalvary.TabIndex = 0;
            this.dataGridViewAttendsCalvary.TabStop = false;
            // 
            // dataGridViewBagCount
            // 
            this.dataGridViewBagCount.AllowUserToAddRows = false;
            this.dataGridViewBagCount.AllowUserToDeleteRows = false;
            this.dataGridViewBagCount.AllowUserToResizeColumns = false;
            this.dataGridViewBagCount.AllowUserToResizeRows = false;
            this.dataGridViewBagCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBagCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBagCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBagCount.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewBagCount.Name = "dataGridViewBagCount";
            this.dataGridViewBagCount.ReadOnly = true;
            this.dataGridViewBagCount.RowHeadersVisible = false;
            this.dataGridViewBagCount.Size = new System.Drawing.Size(689, 350);
            this.dataGridViewBagCount.TabIndex = 2;
            this.dataGridViewBagCount.TabStop = false;
            // 
            // dataGridViewAgeSummary
            // 
            this.dataGridViewAgeSummary.AllowUserToAddRows = false;
            this.dataGridViewAgeSummary.AllowUserToDeleteRows = false;
            this.dataGridViewAgeSummary.AllowUserToResizeColumns = false;
            this.dataGridViewAgeSummary.AllowUserToResizeRows = false;
            this.dataGridViewAgeSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAgeSummary.EnableHeadersVisualStyles = false;
            this.dataGridViewAgeSummary.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAgeSummary.Name = "dataGridViewAgeSummary";
            this.dataGridViewAgeSummary.ReadOnly = true;
            this.dataGridViewAgeSummary.RowHeadersVisible = false;
            this.dataGridViewAgeSummary.Size = new System.Drawing.Size(689, 110);
            this.dataGridViewAgeSummary.TabIndex = 1;
            this.dataGridViewAgeSummary.TabStop = false;
            // 
            // groupBoxHouseholdCountByAgeGroup
            // 
            this.groupBoxHouseholdCountByAgeGroup.Controls.Add(this.dataGridViewAgeSummary);
            this.groupBoxHouseholdCountByAgeGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHouseholdCountByAgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHouseholdCountByAgeGroup.Location = new System.Drawing.Point(10, 176);
            this.groupBoxHouseholdCountByAgeGroup.Name = "groupBoxHouseholdCountByAgeGroup";
            this.groupBoxHouseholdCountByAgeGroup.Size = new System.Drawing.Size(695, 129);
            this.groupBoxHouseholdCountByAgeGroup.TabIndex = 4;
            this.groupBoxHouseholdCountByAgeGroup.TabStop = false;
            this.groupBoxHouseholdCountByAgeGroup.Text = "Household Count by Age Group";
            // 
            // groupBoxBagCount
            // 
            this.groupBoxBagCount.Controls.Add(this.dataGridViewBagCount);
            this.groupBoxBagCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBagCount.Location = new System.Drawing.Point(10, 305);
            this.groupBoxBagCount.Name = "groupBoxBagCount";
            this.groupBoxBagCount.Size = new System.Drawing.Size(695, 369);
            this.groupBoxBagCount.TabIndex = 5;
            this.groupBoxBagCount.TabStop = false;
            this.groupBoxBagCount.Text = "Bag Count per House";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(715, 730);
            this.Controls.Add(this.groupBoxBagCount);
            this.Controls.Add(this.groupBoxHouseholdCountByAgeGroup);
            this.Controls.Add(this.groupBoxAttendsCalvary);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxReportDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.groupBoxReportDate.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxAttendsCalvary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendsCalvary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBagCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgeSummary)).EndInit();
            this.groupBoxHouseholdCountByAgeGroup.ResumeLayout(false);
            this.groupBoxBagCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReportDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportDate;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxAttendsCalvary;
        private System.Windows.Forms.DataGridView dataGridViewAttendsCalvary;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridViewAgeSummary;
        private System.Windows.Forms.DataGridView dataGridViewBagCount;
        private System.Windows.Forms.GroupBox groupBoxHouseholdCountByAgeGroup;
        private System.Windows.Forms.GroupBox groupBoxBagCount;
    }
}
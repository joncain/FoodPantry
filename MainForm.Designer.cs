﻿namespace FoodPantryApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonCreateNewRecipient = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.dataGridViewRecentRecords = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuSearchResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.AllowUserToAddRows = false;
            this.dataGridViewSearchResults.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResults.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResults.AllowUserToResizeRows = false;
            this.dataGridViewSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchResults.MultiSelect = false;
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.RowHeadersVisible = false;
            this.dataGridViewSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(854, 653);
            this.dataGridViewSearchResults.TabIndex = 2;
            this.dataGridViewSearchResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearchResults_CellMouseClick);
            this.dataGridViewSearchResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewSearchResults_KeyDown);
            this.dataGridViewSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSearchResults_MouseDoubleClick);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonReports);
            this.groupBoxSearch.Controls.Add(this.buttonCreateNewRecipient);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchText);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Location = new System.Drawing.Point(10, 10);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.groupBoxSearch.Size = new System.Drawing.Size(988, 57);
            this.groupBoxSearch.TabIndex = 100;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Location = new System.Drawing.Point(860, 19);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(110, 23);
            this.buttonReports.TabIndex = 3;
            this.buttonReports.TabStop = false;
            this.buttonReports.Text = "&Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonCreateNewRecipient
            // 
            this.buttonCreateNewRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewRecipient.Location = new System.Drawing.Point(718, 19);
            this.buttonCreateNewRecipient.Name = "buttonCreateNewRecipient";
            this.buttonCreateNewRecipient.Size = new System.Drawing.Size(136, 23);
            this.buttonCreateNewRecipient.TabIndex = 2;
            this.buttonCreateNewRecipient.TabStop = false;
            this.buttonCreateNewRecipient.Text = "&Create New Recipient";
            this.buttonCreateNewRecipient.UseVisualStyleBackColor = true;
            this.buttonCreateNewRecipient.Click += new System.EventHandler(this.buttonCreateNewRecipient_Click);
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchText.Location = new System.Drawing.Point(11, 21);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(701, 20);
            this.textBoxSearchText.TabIndex = 1;
            this.textBoxSearchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchText_KeyUp);
            // 
            // dataGridViewRecentRecords
            // 
            this.dataGridViewRecentRecords.AllowUserToAddRows = false;
            this.dataGridViewRecentRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecentRecords.AllowUserToResizeColumns = false;
            this.dataGridViewRecentRecords.AllowUserToResizeRows = false;
            this.dataGridViewRecentRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentRecords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecentRecords.MultiSelect = false;
            this.dataGridViewRecentRecords.Name = "dataGridViewRecentRecords";
            this.dataGridViewRecentRecords.ReadOnly = true;
            this.dataGridViewRecentRecords.RowHeadersVisible = false;
            this.dataGridViewRecentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecentRecords.Size = new System.Drawing.Size(130, 653);
            this.dataGridViewRecentRecords.TabIndex = 2;
            this.dataGridViewRecentRecords.TabStop = false;
            this.dataGridViewRecentRecords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSearchResults_MouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewSearchResults);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewRecentRecords);
            this.splitContainer1.Size = new System.Drawing.Size(988, 653);
            this.splitContainer1.SplitterDistance = 854;
            this.splitContainer1.TabIndex = 101;
            this.splitContainer1.TabStop = false;
            // 
            // contextMenuSearchResults
            // 
            this.contextMenuSearchResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordVisitToolStripMenuItem});
            this.contextMenuSearchResults.Name = "contextMenuSearchResults";
            this.contextMenuSearchResults.Size = new System.Drawing.Size(137, 26);
            this.contextMenuSearchResults.Text = "Options";
            // 
            // recordVisitToolStripMenuItem
            // 
            this.recordVisitToolStripMenuItem.Name = "recordVisitToolStripMenuItem";
            this.recordVisitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.recordVisitToolStripMenuItem.Text = "Record Visit";
            this.recordVisitToolStripMenuItem.Click += new System.EventHandler(this.recordVisitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC Boise Food Pantry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentRecords)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.DataGridView dataGridViewRecentRecords;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCreateNewRecipient;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.ContextMenuStrip contextMenuSearchResults;
        private System.Windows.Forms.ToolStripMenuItem recordVisitToolStripMenuItem;
    }
}


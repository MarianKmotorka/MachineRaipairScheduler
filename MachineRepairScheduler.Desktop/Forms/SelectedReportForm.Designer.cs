namespace MachineRepairScheduler.Desktop.Forms
{
    partial class SelectedReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedReportForm));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.reportDataTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedTechniciansTable = new System.Windows.Forms.DataGridView();
            this.selectedReportTable = new System.Windows.Forms.DataGridView();
            this.selectTechniciansTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fixDateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.selectTechniciansCheckList = new System.Windows.Forms.CheckedListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.errorSelectTechniciansLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.changeDetails = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.reportDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedTechniciansTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedReportTable)).BeginInit();
            this.selectTechniciansTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.reportDataTabPage);
            this.tabControl2.Controls.Add(this.selectTechniciansTabPage);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1965, 800);
            this.tabControl2.TabIndex = 3;
            // 
            // reportDataTabPage
            // 
            this.reportDataTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportDataTabPage.Controls.Add(this.label2);
            this.reportDataTabPage.Controls.Add(this.label1);
            this.reportDataTabPage.Controls.Add(this.selectedTechniciansTable);
            this.reportDataTabPage.Controls.Add(this.selectedReportTable);
            this.reportDataTabPage.Location = new System.Drawing.Point(4, 47);
            this.reportDataTabPage.Name = "reportDataTabPage";
            this.reportDataTabPage.Size = new System.Drawing.Size(1957, 749);
            this.reportDataTabPage.TabIndex = 2;
            this.reportDataTabPage.Text = "Report data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 48);
            this.label2.TabIndex = 30;
            this.label2.Text = "Report info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selected technicians";
            // 
            // selectedTechniciansTable
            // 
            this.selectedTechniciansTable.AllowUserToAddRows = false;
            this.selectedTechniciansTable.AllowUserToDeleteRows = false;
            this.selectedTechniciansTable.AllowUserToResizeColumns = false;
            this.selectedTechniciansTable.AllowUserToResizeRows = false;
            this.selectedTechniciansTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedTechniciansTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedTechniciansTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.selectedTechniciansTable.Location = new System.Drawing.Point(3, 346);
            this.selectedTechniciansTable.Name = "selectedTechniciansTable";
            this.selectedTechniciansTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectedTechniciansTable.RowTemplate.Height = 60;
            this.selectedTechniciansTable.Size = new System.Drawing.Size(784, 400);
            this.selectedTechniciansTable.TabIndex = 1;
            this.selectedTechniciansTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.selectedTechniciansTable_CellFormatting);
            // 
            // selectedReportTable
            // 
            this.selectedReportTable.AllowUserToAddRows = false;
            this.selectedReportTable.AllowUserToDeleteRows = false;
            this.selectedReportTable.AllowUserToResizeColumns = false;
            this.selectedReportTable.AllowUserToResizeRows = false;
            this.selectedReportTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedReportTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.selectedReportTable.Location = new System.Drawing.Point(3, 51);
            this.selectedReportTable.Name = "selectedReportTable";
            this.selectedReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectedReportTable.RowTemplate.Height = 60;
            this.selectedReportTable.Size = new System.Drawing.Size(1594, 220);
            this.selectedReportTable.TabIndex = 0;
            this.selectedReportTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.selectedReportTable_CellFormatting);
            this.selectedReportTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedReportTable_CellMouseEnter);
            this.selectedReportTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedReportTable_CellMouseLeave);
            // 
            // selectTechniciansTabPage
            // 
            this.selectTechniciansTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectTechniciansTabPage.Controls.Add(this.groupBox1);
            this.selectTechniciansTabPage.Location = new System.Drawing.Point(4, 47);
            this.selectTechniciansTabPage.Name = "selectTechniciansTabPage";
            this.selectTechniciansTabPage.Size = new System.Drawing.Size(1957, 749);
            this.selectTechniciansTabPage.TabIndex = 3;
            this.selectTechniciansTabPage.Text = "Select technicians";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fixDateMonthCalendar);
            this.groupBox1.Controls.Add(this.selectTechniciansCheckList);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.errorSelectTechniciansLabel);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.changeDetails);
            this.groupBox1.Location = new System.Drawing.Point(148, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 745);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // fixDateMonthCalendar
            // 
            this.fixDateMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fixDateMonthCalendar.Location = new System.Drawing.Point(818, 300);
            this.fixDateMonthCalendar.Name = "fixDateMonthCalendar";
            this.fixDateMonthCalendar.TabIndex = 31;
            // 
            // selectTechniciansCheckList
            // 
            this.selectTechniciansCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTechniciansCheckList.FormattingEnabled = true;
            this.selectTechniciansCheckList.Location = new System.Drawing.Point(87, 300);
            this.selectTechniciansCheckList.Name = "selectTechniciansCheckList";
            this.selectTechniciansCheckList.Size = new System.Drawing.Size(438, 404);
            this.selectTechniciansCheckList.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(79, 230);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(244, 48);
            this.label21.TabIndex = 28;
            this.label21.Text = "Technicians";
            // 
            // errorSelectTechniciansLabel
            // 
            this.errorSelectTechniciansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorSelectTechniciansLabel.ForeColor = System.Drawing.Color.Red;
            this.errorSelectTechniciansLabel.Location = new System.Drawing.Point(6, 40);
            this.errorSelectTechniciansLabel.Name = "errorSelectTechniciansLabel";
            this.errorSelectTechniciansLabel.Size = new System.Drawing.Size(1301, 184);
            this.errorSelectTechniciansLabel.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(810, 230);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(169, 48);
            this.label26.TabIndex = 24;
            this.label26.Text = "Fix date";
            // 
            // changeDetails
            // 
            this.changeDetails.BackColor = System.Drawing.Color.White;
            this.changeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeDetails.Location = new System.Drawing.Point(1050, 635);
            this.changeDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDetails.Name = "changeDetails";
            this.changeDetails.Size = new System.Drawing.Size(257, 115);
            this.changeDetails.TabIndex = 23;
            this.changeDetails.Text = "Change details";
            this.changeDetails.UseVisualStyleBackColor = false;
            this.changeDetails.Click += new System.EventHandler(this.changeDetails_Click);
            // 
            // SelectedReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1997, 984);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectedReportForm";
            this.Text = "Selected report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectedReportForm_FormClosed);
            this.tabControl2.ResumeLayout(false);
            this.reportDataTabPage.ResumeLayout(false);
            this.reportDataTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedTechniciansTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedReportTable)).EndInit();
            this.selectTechniciansTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage reportDataTabPage;
        private System.Windows.Forms.DataGridView selectedReportTable;
        private System.Windows.Forms.TabPage selectTechniciansTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label errorSelectTechniciansLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button changeDetails;
        private System.Windows.Forms.DataGridView selectedTechniciansTable;
        private System.Windows.Forms.MonthCalendar fixDateMonthCalendar;
        private System.Windows.Forms.CheckedListBox selectTechniciansCheckList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
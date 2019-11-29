namespace MachineRepairScheduler.Desktop.Forms
{
    partial class SelectedUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedUserForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userDataTabPage = new System.Windows.Forms.TabPage();
            this.selectedUserTable = new System.Windows.Forms.DataGridView();
            this.editUserTabPage = new System.Windows.Forms.TabPage();
            this.deleteSelectedUserPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.userDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedUserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userDataTabPage);
            this.tabControl1.Controls.Add(this.editUserTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1965, 800);
            this.tabControl1.TabIndex = 1;
            // 
            // userDataTabPage
            // 
            this.userDataTabPage.BackColor = System.Drawing.Color.White;
            this.userDataTabPage.Controls.Add(this.deleteSelectedUserPictureBox);
            this.userDataTabPage.Controls.Add(this.selectedUserTable);
            this.userDataTabPage.Location = new System.Drawing.Point(4, 47);
            this.userDataTabPage.Name = "userDataTabPage";
            this.userDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userDataTabPage.Size = new System.Drawing.Size(1957, 749);
            this.userDataTabPage.TabIndex = 2;
            this.userDataTabPage.Text = "User data";
            // 
            // selectedUserTable
            // 
            this.selectedUserTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedUserTable.Location = new System.Drawing.Point(6, 308);
            this.selectedUserTable.Name = "selectedUserTable";
            this.selectedUserTable.RowHeadersWidth = 51;
            this.selectedUserTable.RowTemplate.Height = 65;
            this.selectedUserTable.Size = new System.Drawing.Size(1594, 150);
            this.selectedUserTable.TabIndex = 0;
            // 
            // editUserTabPage
            // 
            this.editUserTabPage.BackColor = System.Drawing.Color.White;
            this.editUserTabPage.Location = new System.Drawing.Point(4, 47);
            this.editUserTabPage.Name = "editUserTabPage";
            this.editUserTabPage.Size = new System.Drawing.Size(1957, 749);
            this.editUserTabPage.TabIndex = 3;
            this.editUserTabPage.Text = "Edit user";
            // 
            // deleteSelectedUserPictureBox
            // 
            this.deleteSelectedUserPictureBox.Image = global::MachineRepairScheduler.Desktop.Properties.Resources.Trash_bin;
            this.deleteSelectedUserPictureBox.InitialImage = global::MachineRepairScheduler.Desktop.Properties.Resources.Trash_bin;
            this.deleteSelectedUserPictureBox.Location = new System.Drawing.Point(1533, 586);
            this.deleteSelectedUserPictureBox.Name = "deleteSelectedUserPictureBox";
            this.deleteSelectedUserPictureBox.Size = new System.Drawing.Size(67, 60);
            this.deleteSelectedUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteSelectedUserPictureBox.TabIndex = 1;
            this.deleteSelectedUserPictureBox.TabStop = false;
            this.deleteSelectedUserPictureBox.Click += new System.EventHandler(this.deleteSelectedUserPictureBox_Click);
            // 
            // SelectedUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1979, 937);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectedUserForm";
            this.Text = "Selected user";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectedUserForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.userDataTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedUserPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userDataTabPage;
        private System.Windows.Forms.TabPage editUserTabPage;
        private System.Windows.Forms.DataGridView selectedUserTable;
        private System.Windows.Forms.PictureBox deleteSelectedUserPictureBox;
    }
}
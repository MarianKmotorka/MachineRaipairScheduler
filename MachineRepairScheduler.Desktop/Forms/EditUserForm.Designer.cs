namespace MachineRepairScheduler.Desktop.Forms
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userDataTabPage = new System.Windows.Forms.TabPage();
            this.editUserTabPage = new System.Windows.Forms.TabPage();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.deleteUser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.userDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
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
            this.userDataTabPage.Controls.Add(this.deleteUser);
            this.userDataTabPage.Controls.Add(this.userTable);
            this.userDataTabPage.Location = new System.Drawing.Point(4, 47);
            this.userDataTabPage.Name = "userDataTabPage";
            this.userDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userDataTabPage.Size = new System.Drawing.Size(1957, 749);
            this.userDataTabPage.TabIndex = 2;
            this.userDataTabPage.Text = "User data";
            // 
            // editUserTabPage
            // 
            this.editUserTabPage.BackColor = System.Drawing.Color.White;
            this.editUserTabPage.Location = new System.Drawing.Point(4, 47);
            this.editUserTabPage.Name = "editUserTabPage";
            this.editUserTabPage.Size = new System.Drawing.Size(1957, 869);
            this.editUserTabPage.TabIndex = 3;
            this.editUserTabPage.Text = "Edit user";
            // 
            // userTable
            // 
            this.userTable.BackgroundColor = System.Drawing.Color.White;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(6, 308);
            this.userTable.Name = "userTable";
            this.userTable.RowHeadersWidth = 51;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.Size = new System.Drawing.Size(1594, 150);
            this.userTable.TabIndex = 0;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(1342, 579);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(258, 116);
            this.deleteUser.TabIndex = 1;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1979, 937);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditUserForm";
            this.Text = "Edit user";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditUserForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.userDataTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userDataTabPage;
        private System.Windows.Forms.TabPage editUserTabPage;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Button deleteUser;
    }
}
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
            this.deleteSelectedUserPictureBox = new System.Windows.Forms.PictureBox();
            this.selectedUserTable = new System.Windows.Forms.DataGridView();
            this.editUserTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthCertificateNumberEditUserTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneEditUserTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.surnameEditUserTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameEditUserTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userRoleEditUserComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordEditUserTextBox = new System.Windows.Forms.TextBox();
            this.showEditUserPassword = new System.Windows.Forms.CheckBox();
            this.errorEditUserLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailEditUserTextBox = new System.Windows.Forms.TextBox();
            this.editUser = new System.Windows.Forms.Button();
            this.passwordEditUserTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.userDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserTable)).BeginInit();
            this.editUserTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.userDataTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userDataTabPage.Controls.Add(this.deleteSelectedUserPictureBox);
            this.userDataTabPage.Controls.Add(this.selectedUserTable);
            this.userDataTabPage.Location = new System.Drawing.Point(4, 47);
            this.userDataTabPage.Name = "userDataTabPage";
            this.userDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userDataTabPage.Size = new System.Drawing.Size(1957, 749);
            this.userDataTabPage.TabIndex = 2;
            this.userDataTabPage.Text = "User data";
            // 
            // deleteSelectedUserPictureBox
            // 
            this.deleteSelectedUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedUserPictureBox.Image")));
            this.deleteSelectedUserPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("deleteSelectedUserPictureBox.InitialImage")));
            this.deleteSelectedUserPictureBox.Location = new System.Drawing.Point(1533, 598);
            this.deleteSelectedUserPictureBox.Name = "deleteSelectedUserPictureBox";
            this.deleteSelectedUserPictureBox.Size = new System.Drawing.Size(67, 60);
            this.deleteSelectedUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteSelectedUserPictureBox.TabIndex = 2;
            this.deleteSelectedUserPictureBox.TabStop = false;
            this.deleteSelectedUserPictureBox.Click += new System.EventHandler(this.deleteSelectedUserPictureBox_Click_1);
            // 
            // selectedUserTable
            // 
            this.selectedUserTable.AllowUserToAddRows = false;
            this.selectedUserTable.AllowUserToDeleteRows = false;
            this.selectedUserTable.AllowUserToResizeColumns = false;
            this.selectedUserTable.AllowUserToResizeRows = false;
            this.selectedUserTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedUserTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.selectedUserTable.Location = new System.Drawing.Point(6, 233);
            this.selectedUserTable.Name = "selectedUserTable";
            this.selectedUserTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selectedUserTable.RowTemplate.Height = 55;
            this.selectedUserTable.Size = new System.Drawing.Size(1594, 225);
            this.selectedUserTable.TabIndex = 0;
            this.selectedUserTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.selectedUserTable_CellFormatting);
            // 
            // editUserTabPage
            // 
            this.editUserTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editUserTabPage.Controls.Add(this.groupBox1);
            this.editUserTabPage.Location = new System.Drawing.Point(4, 47);
            this.editUserTabPage.Name = "editUserTabPage";
            this.editUserTabPage.Size = new System.Drawing.Size(1957, 749);
            this.editUserTabPage.TabIndex = 3;
            this.editUserTabPage.Text = "Edit user";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.birthCertificateNumberEditUserTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.phoneEditUserTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.surnameEditUserTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameEditUserTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.userRoleEditUserComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.confirmPasswordEditUserTextBox);
            this.groupBox1.Controls.Add(this.showEditUserPassword);
            this.groupBox1.Controls.Add(this.errorEditUserLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.emailEditUserTextBox);
            this.groupBox1.Controls.Add(this.editUser);
            this.groupBox1.Controls.Add(this.passwordEditUserTextBox);
            this.groupBox1.Location = new System.Drawing.Point(148, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 745);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(21, 672);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 48);
            this.label10.TabIndex = 20;
            this.label10.Text = "* Marked fields are optional";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1265, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(707, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(451, 48);
            this.label8.TabIndex = 18;
            this.label8.Text = "Birth certificate number";
            // 
            // birthCertificateNumberEditUserTextBox
            // 
            this.birthCertificateNumberEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.birthCertificateNumberEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthCertificateNumberEditUserTextBox.Location = new System.Drawing.Point(715, 458);
            this.birthCertificateNumberEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthCertificateNumberEditUserTextBox.Name = "birthCertificateNumberEditUserTextBox";
            this.birthCertificateNumberEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.birthCertificateNumberEditUserTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(707, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 48);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone number";
            // 
            // phoneEditUserTextBox
            // 
            this.phoneEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.phoneEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneEditUserTextBox.Location = new System.Drawing.Point(715, 567);
            this.phoneEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneEditUserTextBox.Name = "phoneEditUserTextBox";
            this.phoneEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.phoneEditUserTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(707, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surname";
            // 
            // surnameEditUserTextBox
            // 
            this.surnameEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.surnameEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameEditUserTextBox.Location = new System.Drawing.Point(715, 349);
            this.surnameEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameEditUserTextBox.Name = "surnameEditUserTextBox";
            this.surnameEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.surnameEditUserTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(707, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 48);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // nameEditUserTextBox
            // 
            this.nameEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.nameEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameEditUserTextBox.Location = new System.Drawing.Point(715, 241);
            this.nameEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameEditUserTextBox.Name = "nameEditUserTextBox";
            this.nameEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.nameEditUserTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "User role";
            // 
            // userRoleEditUserComboBox
            // 
            this.userRoleEditUserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userRoleEditUserComboBox.FormattingEnabled = true;
            this.userRoleEditUserComboBox.Location = new System.Drawing.Point(29, 566);
            this.userRoleEditUserComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userRoleEditUserComboBox.Name = "userRoleEditUserComboBox";
            this.userRoleEditUserComboBox.Size = new System.Drawing.Size(544, 56);
            this.userRoleEditUserComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm password";
            // 
            // confirmPasswordEditUserTextBox
            // 
            this.confirmPasswordEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.confirmPasswordEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswordEditUserTextBox.Location = new System.Drawing.Point(29, 458);
            this.confirmPasswordEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPasswordEditUserTextBox.Name = "confirmPasswordEditUserTextBox";
            this.confirmPasswordEditUserTextBox.PasswordChar = '*';
            this.confirmPasswordEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.confirmPasswordEditUserTextBox.TabIndex = 7;
            // 
            // showEditUserPassword
            // 
            this.showEditUserPassword.AutoSize = true;
            this.showEditUserPassword.Location = new System.Drawing.Point(448, 411);
            this.showEditUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showEditUserPassword.Name = "showEditUserPassword";
            this.showEditUserPassword.Size = new System.Drawing.Size(125, 43);
            this.showEditUserPassword.TabIndex = 6;
            this.showEditUserPassword.Text = "Show";
            this.showEditUserPassword.UseVisualStyleBackColor = true;
            this.showEditUserPassword.CheckedChanged += new System.EventHandler(this.showEditUserPassword_CheckedChanged);
            // 
            // errorEditUserLabel
            // 
            this.errorEditUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorEditUserLabel.ForeColor = System.Drawing.Color.Red;
            this.errorEditUserLabel.Location = new System.Drawing.Point(6, 40);
            this.errorEditUserLabel.Name = "errorEditUserLabel";
            this.errorEditUserLabel.Size = new System.Drawing.Size(1301, 147);
            this.errorEditUserLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // emailEditUserTextBox
            // 
            this.emailEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.emailEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailEditUserTextBox.Location = new System.Drawing.Point(29, 241);
            this.emailEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailEditUserTextBox.Name = "emailEditUserTextBox";
            this.emailEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.emailEditUserTextBox.TabIndex = 0;
            // 
            // editUser
            // 
            this.editUser.BackColor = System.Drawing.Color.White;
            this.editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editUser.Location = new System.Drawing.Point(1090, 651);
            this.editUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(217, 90);
            this.editUser.TabIndex = 2;
            this.editUser.Text = "Edit user";
            this.editUser.UseVisualStyleBackColor = false;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // passwordEditUserTextBox
            // 
            this.passwordEditUserTextBox.BackColor = System.Drawing.Color.White;
            this.passwordEditUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordEditUserTextBox.Location = new System.Drawing.Point(29, 349);
            this.passwordEditUserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordEditUserTextBox.Name = "passwordEditUserTextBox";
            this.passwordEditUserTextBox.PasswordChar = '*';
            this.passwordEditUserTextBox.Size = new System.Drawing.Size(544, 55);
            this.passwordEditUserTextBox.TabIndex = 1;
            // 
            // SelectedUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserTable)).EndInit();
            this.editUserTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userDataTabPage;
        private System.Windows.Forms.TabPage editUserTabPage;
        private System.Windows.Forms.DataGridView selectedUserTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox birthCertificateNumberEditUserTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneEditUserTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnameEditUserTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameEditUserTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userRoleEditUserComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordEditUserTextBox;
        private System.Windows.Forms.CheckBox showEditUserPassword;
        private System.Windows.Forms.Label errorEditUserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailEditUserTextBox;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.TextBox passwordEditUserTextBox;
        private System.Windows.Forms.PictureBox deleteSelectedUserPictureBox;
    }
}
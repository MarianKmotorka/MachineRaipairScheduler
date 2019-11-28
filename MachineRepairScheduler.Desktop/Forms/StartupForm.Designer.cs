namespace MachineRepairScheduler.Desktop.Forms
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.showRegisterPassword = new System.Windows.Forms.CheckBox();
            this.errorRegisterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registeredUsersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.registeredUsersTable = new System.Windows.Forms.DataGridView();
            this.findUser = new System.Windows.Forms.Button();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.registeredUsersTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.registerTabPage);
            this.tabControl1.Controls.Add(this.registeredUsersTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2028, 1103);
            this.tabControl1.TabIndex = 0;
            // 
            // registerTabPage
            // 
            this.registerTabPage.BackColor = System.Drawing.Color.White;
            this.registerTabPage.Controls.Add(this.groupBox1);
            this.registerTabPage.Location = new System.Drawing.Point(4, 47);
            this.registerTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerTabPage.Size = new System.Drawing.Size(2020, 1052);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.userRoleComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.registerConfirmPasswordTextBox);
            this.groupBox1.Controls.Add(this.showRegisterPassword);
            this.groupBox1.Controls.Add(this.errorRegisterLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.registerEmailTextBox);
            this.groupBox1.Controls.Add(this.signUp);
            this.groupBox1.Controls.Add(this.registerPasswordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(148, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 800);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "User role";
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(85, 592);
            this.userRoleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(997, 56);
            this.userRoleComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm password";
            // 
            // registerConfirmPasswordTextBox
            // 
            this.registerConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.registerConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerConfirmPasswordTextBox.Location = new System.Drawing.Point(85, 484);
            this.registerConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerConfirmPasswordTextBox.Name = "registerConfirmPasswordTextBox";
            this.registerConfirmPasswordTextBox.PasswordChar = '*';
            this.registerConfirmPasswordTextBox.Size = new System.Drawing.Size(997, 55);
            this.registerConfirmPasswordTextBox.TabIndex = 7;
            // 
            // showRegisterPassword
            // 
            this.showRegisterPassword.AutoSize = true;
            this.showRegisterPassword.Location = new System.Drawing.Point(1137, 438);
            this.showRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showRegisterPassword.Name = "showRegisterPassword";
            this.showRegisterPassword.Size = new System.Drawing.Size(125, 43);
            this.showRegisterPassword.TabIndex = 6;
            this.showRegisterPassword.Text = "Show";
            this.showRegisterPassword.UseVisualStyleBackColor = true;
            // 
            // errorRegisterLabel
            // 
            this.errorRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorRegisterLabel.ForeColor = System.Drawing.Color.Red;
            this.errorRegisterLabel.Location = new System.Drawing.Point(6, 40);
            this.errorRegisterLabel.Name = "errorRegisterLabel";
            this.errorRegisterLabel.Size = new System.Drawing.Size(1301, 177);
            this.errorRegisterLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.BackColor = System.Drawing.Color.White;
            this.registerEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerEmailTextBox.Location = new System.Drawing.Point(85, 267);
            this.registerEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(997, 55);
            this.registerEmailTextBox.TabIndex = 0;
            // 
            // signUp
            // 
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signUp.Location = new System.Drawing.Point(1090, 706);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(217, 90);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerPasswordTextBox.Location = new System.Drawing.Point(85, 375);
            this.registerPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(997, 55);
            this.registerPasswordTextBox.TabIndex = 1;
            // 
            // registeredUsersTabPage
            // 
            this.registeredUsersTabPage.Controls.Add(this.groupBox2);
            this.registeredUsersTabPage.Location = new System.Drawing.Point(4, 47);
            this.registeredUsersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registeredUsersTabPage.Name = "registeredUsersTabPage";
            this.registeredUsersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registeredUsersTabPage.Size = new System.Drawing.Size(2020, 1052);
            this.registeredUsersTabPage.TabIndex = 1;
            this.registeredUsersTabPage.Text = "Registered users";
            this.registeredUsersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.registeredUsersTable);
            this.groupBox2.Controls.Add(this.findUser);
            this.groupBox2.Controls.Add(this.searchUserTextBox);
            this.groupBox2.Location = new System.Drawing.Point(148, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1313, 800);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // registeredUsersTable
            // 
            this.registeredUsersTable.BackgroundColor = System.Drawing.Color.White;
            this.registeredUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registeredUsersTable.Location = new System.Drawing.Point(29, 150);
            this.registeredUsersTable.Name = "registeredUsersTable";
            this.registeredUsersTable.RowHeadersWidth = 51;
            this.registeredUsersTable.RowTemplate.Height = 24;
            this.registeredUsersTable.Size = new System.Drawing.Size(1255, 621);
            this.registeredUsersTable.TabIndex = 2;
            // 
            // findUser
            // 
            this.findUser.BackColor = System.Drawing.Color.White;
            this.findUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findUser.Location = new System.Drawing.Point(1120, 43);
            this.findUser.Name = "findUser";
            this.findUser.Size = new System.Drawing.Size(164, 55);
            this.findUser.TabIndex = 1;
            this.findUser.Text = "Find";
            this.findUser.UseVisualStyleBackColor = false;
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchUserTextBox.Location = new System.Drawing.Point(29, 43);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(1026, 55);
            this.searchUserTextBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2020, 1052);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Submit malfunction";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(148, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1313, 800);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1979, 937);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.Text = "Machine repair scheduler";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.registerTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.registeredUsersTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TabPage registeredUsersTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerConfirmPasswordTextBox;
        private System.Windows.Forms.CheckBox showRegisterPassword;
        private System.Windows.Forms.Label errorRegisterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerEmailTextBox;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findUser;
        private System.Windows.Forms.TextBox searchUserTextBox;
        private System.Windows.Forms.DataGridView registeredUsersTable;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
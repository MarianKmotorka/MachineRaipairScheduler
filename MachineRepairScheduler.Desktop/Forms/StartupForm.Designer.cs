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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthCertificateNumberRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.surnameRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userRoleRegisterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.showRegisterPassword = new System.Windows.Forms.CheckBox();
            this.errorRegisterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailRegisterTextBox = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.passwordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.registeredUsersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.registeredUsersTable = new System.Windows.Forms.DataGridView();
            this.findUser = new System.Windows.Forms.Button();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nextPageUsersPictureBox = new System.Windows.Forms.PictureBox();
            this.previousPageUsersPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.registeredUsersTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPageUsersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPageUsersPictureBox)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1965, 900);
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
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.birthCertificateNumberRegisterTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.phoneRegisterTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.surnameRegisterTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameRegisterTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.userRoleRegisterComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.confirmPasswordRegisterTextBox);
            this.groupBox1.Controls.Add(this.showRegisterPassword);
            this.groupBox1.Controls.Add(this.errorRegisterLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.emailRegisterTextBox);
            this.groupBox1.Controls.Add(this.signUp);
            this.groupBox1.Controls.Add(this.passwordRegisterTextBox);
            this.groupBox1.Location = new System.Drawing.Point(148, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 800);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(20, 717);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 48);
            this.label10.TabIndex = 20;
            this.label10.Text = "* Marked fields are optional";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1264, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 48);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(706, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(451, 48);
            this.label8.TabIndex = 18;
            this.label8.Text = "Birth certificate number";
            // 
            // birthCertificateNumberRegisterTextBox
            // 
            this.birthCertificateNumberRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.birthCertificateNumberRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthCertificateNumberRegisterTextBox.Location = new System.Drawing.Point(714, 484);
            this.birthCertificateNumberRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthCertificateNumberRegisterTextBox.Name = "birthCertificateNumberRegisterTextBox";
            this.birthCertificateNumberRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.birthCertificateNumberRegisterTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(706, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 48);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone number";
            // 
            // phoneRegisterTextBox
            // 
            this.phoneRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.phoneRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneRegisterTextBox.Location = new System.Drawing.Point(714, 593);
            this.phoneRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneRegisterTextBox.Name = "phoneRegisterTextBox";
            this.phoneRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.phoneRegisterTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(706, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surname";
            // 
            // surnameRegisterTextBox
            // 
            this.surnameRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.surnameRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameRegisterTextBox.Location = new System.Drawing.Point(714, 375);
            this.surnameRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameRegisterTextBox.Name = "surnameRegisterTextBox";
            this.surnameRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.surnameRegisterTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(706, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 48);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // nameRegisterTextBox
            // 
            this.nameRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.nameRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameRegisterTextBox.Location = new System.Drawing.Point(714, 267);
            this.nameRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameRegisterTextBox.Name = "nameRegisterTextBox";
            this.nameRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.nameRegisterTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "User role";
            // 
            // userRoleRegisterComboBox
            // 
            this.userRoleRegisterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userRoleRegisterComboBox.FormattingEnabled = true;
            this.userRoleRegisterComboBox.Location = new System.Drawing.Point(28, 592);
            this.userRoleRegisterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userRoleRegisterComboBox.Name = "userRoleRegisterComboBox";
            this.userRoleRegisterComboBox.Size = new System.Drawing.Size(544, 56);
            this.userRoleRegisterComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm password";
            // 
            // confirmPasswordRegisterTextBox
            // 
            this.confirmPasswordRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.confirmPasswordRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswordRegisterTextBox.Location = new System.Drawing.Point(28, 484);
            this.confirmPasswordRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPasswordRegisterTextBox.Name = "confirmPasswordRegisterTextBox";
            this.confirmPasswordRegisterTextBox.PasswordChar = '*';
            this.confirmPasswordRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.confirmPasswordRegisterTextBox.TabIndex = 7;
            // 
            // showRegisterPassword
            // 
            this.showRegisterPassword.AutoSize = true;
            this.showRegisterPassword.Location = new System.Drawing.Point(447, 437);
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
            this.label2.Location = new System.Drawing.Point(19, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // emailRegisterTextBox
            // 
            this.emailRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.emailRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailRegisterTextBox.Location = new System.Drawing.Point(28, 267);
            this.emailRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailRegisterTextBox.Name = "emailRegisterTextBox";
            this.emailRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.emailRegisterTextBox.TabIndex = 0;
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
            // passwordRegisterTextBox
            // 
            this.passwordRegisterTextBox.BackColor = System.Drawing.Color.White;
            this.passwordRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordRegisterTextBox.Location = new System.Drawing.Point(28, 375);
            this.passwordRegisterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordRegisterTextBox.Name = "passwordRegisterTextBox";
            this.passwordRegisterTextBox.PasswordChar = '*';
            this.passwordRegisterTextBox.Size = new System.Drawing.Size(544, 55);
            this.passwordRegisterTextBox.TabIndex = 1;
            // 
            // registeredUsersTabPage
            // 
            this.registeredUsersTabPage.Controls.Add(this.groupBox2);
            this.registeredUsersTabPage.Location = new System.Drawing.Point(4, 47);
            this.registeredUsersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registeredUsersTabPage.Name = "registeredUsersTabPage";
            this.registeredUsersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registeredUsersTabPage.Size = new System.Drawing.Size(1957, 849);
            this.registeredUsersTabPage.TabIndex = 1;
            this.registeredUsersTabPage.Text = "Registered users";
            this.registeredUsersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextPageUsersPictureBox);
            this.groupBox2.Controls.Add(this.previousPageUsersPictureBox);
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
            this.registeredUsersTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.registeredUsersTable.Location = new System.Drawing.Point(29, 150);
            this.registeredUsersTable.Name = "registeredUsersTable";
            this.registeredUsersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.registeredUsersTable.RowTemplate.Height = 24;
            this.registeredUsersTable.Size = new System.Drawing.Size(1255, 524);
            this.registeredUsersTable.TabIndex = 2;
            this.registeredUsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registeredUsersTable_CellContentClick);
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
            // nextPageUsersPictureBox
            // 
            this.nextPageUsersPictureBox.Image = global::MachineRepairScheduler.Desktop.Properties.Resources.next_page;
            this.nextPageUsersPictureBox.InitialImage = global::MachineRepairScheduler.Desktop.Properties.Resources.next_page;
            this.nextPageUsersPictureBox.Location = new System.Drawing.Point(699, 714);
            this.nextPageUsersPictureBox.Name = "nextPageUsersPictureBox";
            this.nextPageUsersPictureBox.Size = new System.Drawing.Size(50, 50);
            this.nextPageUsersPictureBox.TabIndex = 4;
            this.nextPageUsersPictureBox.TabStop = false;
            this.nextPageUsersPictureBox.Click += new System.EventHandler(this.nextPageUsersPictureBox_Click);
            // 
            // previousPageUsersPictureBox
            // 
            this.previousPageUsersPictureBox.Image = global::MachineRepairScheduler.Desktop.Properties.Resources.previous_page;
            this.previousPageUsersPictureBox.InitialImage = global::MachineRepairScheduler.Desktop.Properties.Resources.previous_page;
            this.previousPageUsersPictureBox.Location = new System.Drawing.Point(581, 714);
            this.previousPageUsersPictureBox.Name = "previousPageUsersPictureBox";
            this.previousPageUsersPictureBox.Size = new System.Drawing.Size(50, 50);
            this.previousPageUsersPictureBox.TabIndex = 3;
            this.previousPageUsersPictureBox.TabStop = false;
            this.previousPageUsersPictureBox.Click += new System.EventHandler(this.previousPageUsersPictureBox_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.nextPageUsersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousPageUsersPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TabPage registeredUsersTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordRegisterTextBox;
        private System.Windows.Forms.CheckBox showRegisterPassword;
        private System.Windows.Forms.Label errorRegisterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailRegisterTextBox;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.TextBox passwordRegisterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userRoleRegisterComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findUser;
        private System.Windows.Forms.TextBox searchUserTextBox;
        private System.Windows.Forms.DataGridView registeredUsersTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneRegisterTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnameRegisterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameRegisterTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox birthCertificateNumberRegisterTextBox;
        private System.Windows.Forms.PictureBox previousPageUsersPictureBox;
        private System.Windows.Forms.PictureBox nextPageUsersPictureBox;
    }
}
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegisterTabPage = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.RegisterTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegisterTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // RegisterTabPage
            // 
            this.RegisterTabPage.Controls.Add(this.groupBox1);
            this.RegisterTabPage.Location = new System.Drawing.Point(4, 25);
            this.RegisterTabPage.Name = "RegisterTabPage";
            this.RegisterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTabPage.Size = new System.Drawing.Size(768, 397);
            this.RegisterTabPage.TabIndex = 0;
            this.RegisterTabPage.Text = "Register";
            this.RegisterTabPage.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(84, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 400);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(31, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "User role";
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(37, 353);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(300, 39);
            this.userRoleComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm password";
            // 
            // registerConfirmPasswordTextBox
            // 
            this.registerConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.registerConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerConfirmPasswordTextBox.Location = new System.Drawing.Point(37, 278);
            this.registerConfirmPasswordTextBox.Name = "registerConfirmPasswordTextBox";
            this.registerConfirmPasswordTextBox.PasswordChar = '*';
            this.registerConfirmPasswordTextBox.Size = new System.Drawing.Size(300, 38);
            this.registerConfirmPasswordTextBox.TabIndex = 7;
            // 
            // showRegisterPassword
            // 
            this.showRegisterPassword.AutoSize = true;
            this.showRegisterPassword.Location = new System.Drawing.Point(362, 254);
            this.showRegisterPassword.Name = "showRegisterPassword";
            this.showRegisterPassword.Size = new System.Drawing.Size(64, 21);
            this.showRegisterPassword.TabIndex = 6;
            this.showRegisterPassword.Text = "Show";
            this.showRegisterPassword.UseVisualStyleBackColor = true;
            // 
            // errorRegisterLabel
            // 
            this.errorRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorRegisterLabel.ForeColor = System.Drawing.Color.Red;
            this.errorRegisterLabel.Location = new System.Drawing.Point(6, 18);
            this.errorRegisterLabel.Name = "errorRegisterLabel";
            this.errorRegisterLabel.Size = new System.Drawing.Size(588, 82);
            this.errorRegisterLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.BackColor = System.Drawing.Color.White;
            this.registerEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerEmailTextBox.Location = new System.Drawing.Point(37, 128);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(300, 38);
            this.registerEmailTextBox.TabIndex = 0;
            // 
            // signUp
            // 
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signUp.Location = new System.Drawing.Point(453, 331);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(141, 63);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerPasswordTextBox.Location = new System.Drawing.Point(37, 203);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(300, 38);
            this.registerPasswordTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.submit);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Submit repair";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Machine";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(756, 110);
            this.label5.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(663, 343);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(99, 48);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(0, 227);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(768, 110);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(768, 39);
            this.comboBox1.TabIndex = 0;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "StartupForm";
            this.Text = "Machine repair scheduler";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.RegisterTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RegisterTabPage;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
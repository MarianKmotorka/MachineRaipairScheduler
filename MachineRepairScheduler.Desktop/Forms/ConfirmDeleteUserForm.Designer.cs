namespace MachineRepairScheduler.Desktop.Forms
{
    partial class ConfirmDeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDeleteUserForm));
            this.confirmDeleteUserNoButton = new System.Windows.Forms.Button();
            this.confirmDeleteUserYesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmDeleteUserNoButton
            // 
            this.confirmDeleteUserNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDeleteUserNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmDeleteUserNoButton.Location = new System.Drawing.Point(495, 243);
            this.confirmDeleteUserNoButton.Name = "confirmDeleteUserNoButton";
            this.confirmDeleteUserNoButton.Size = new System.Drawing.Size(230, 98);
            this.confirmDeleteUserNoButton.TabIndex = 0;
            this.confirmDeleteUserNoButton.Text = "No";
            this.confirmDeleteUserNoButton.UseVisualStyleBackColor = true;
            this.confirmDeleteUserNoButton.Click += new System.EventHandler(this.confirmDeleteUserNoButton_Click);
            // 
            // confirmDeleteUserYesButton
            // 
            this.confirmDeleteUserYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDeleteUserYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmDeleteUserYesButton.Location = new System.Drawing.Point(66, 243);
            this.confirmDeleteUserYesButton.Name = "confirmDeleteUserYesButton";
            this.confirmDeleteUserYesButton.Size = new System.Drawing.Size(230, 98);
            this.confirmDeleteUserYesButton.TabIndex = 1;
            this.confirmDeleteUserYesButton.Text = "Yes";
            this.confirmDeleteUserYesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you really want to delete selected user?";
            // 
            // ConfirmDeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmDeleteUserYesButton);
            this.Controls.Add(this.confirmDeleteUserNoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmDeleteUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmDeleteUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmDeleteUserNoButton;
        private System.Windows.Forms.Button confirmDeleteUserYesButton;
        private System.Windows.Forms.Label label1;
    }
}
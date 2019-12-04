namespace MachineRepairScheduler.Desktop.Forms
{
    partial class ConfirmDeleteMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDeleteMachineForm));
            this.label1 = new System.Windows.Forms.Label();
            this.confirmDeleteMachineYesButton = new System.Windows.Forms.Button();
            this.confirmDeleteMachineNoButton = new System.Windows.Forms.Button();
            this.errorConfirmDeleteSelectedMachineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Do you really want to delete selected user?";
            // 
            // confirmDeleteMachineYesButton
            // 
            this.confirmDeleteMachineYesButton.BackColor = System.Drawing.Color.White;
            this.confirmDeleteMachineYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDeleteMachineYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmDeleteMachineYesButton.Location = new System.Drawing.Point(66, 198);
            this.confirmDeleteMachineYesButton.Name = "confirmDeleteMachineYesButton";
            this.confirmDeleteMachineYesButton.Size = new System.Drawing.Size(230, 98);
            this.confirmDeleteMachineYesButton.TabIndex = 4;
            this.confirmDeleteMachineYesButton.Text = "Yes";
            this.confirmDeleteMachineYesButton.UseVisualStyleBackColor = false;
            this.confirmDeleteMachineYesButton.Click += new System.EventHandler(this.confirmDeleteMachineYesButton_Click);
            // 
            // confirmDeleteMachineNoButton
            // 
            this.confirmDeleteMachineNoButton.BackColor = System.Drawing.Color.White;
            this.confirmDeleteMachineNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDeleteMachineNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmDeleteMachineNoButton.Location = new System.Drawing.Point(495, 198);
            this.confirmDeleteMachineNoButton.Name = "confirmDeleteMachineNoButton";
            this.confirmDeleteMachineNoButton.Size = new System.Drawing.Size(230, 98);
            this.confirmDeleteMachineNoButton.TabIndex = 3;
            this.confirmDeleteMachineNoButton.Text = "No";
            this.confirmDeleteMachineNoButton.UseVisualStyleBackColor = false;
            this.confirmDeleteMachineNoButton.Click += new System.EventHandler(this.confirmDeleteMachineNoButton_Click);
            // 
            // errorConfirmDeleteSelectedMachineLabel
            // 
            this.errorConfirmDeleteSelectedMachineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorConfirmDeleteSelectedMachineLabel.ForeColor = System.Drawing.Color.Red;
            this.errorConfirmDeleteSelectedMachineLabel.Location = new System.Drawing.Point(66, 333);
            this.errorConfirmDeleteSelectedMachineLabel.Name = "errorConfirmDeleteSelectedMachineLabel";
            this.errorConfirmDeleteSelectedMachineLabel.Size = new System.Drawing.Size(659, 98);
            this.errorConfirmDeleteSelectedMachineLabel.TabIndex = 7;
            // 
            // ConfirmDeleteMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorConfirmDeleteSelectedMachineLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmDeleteMachineYesButton);
            this.Controls.Add(this.confirmDeleteMachineNoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmDeleteMachineForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmDeleteMachineForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmDeleteMachineYesButton;
        private System.Windows.Forms.Button confirmDeleteMachineNoButton;
        private System.Windows.Forms.Label errorConfirmDeleteSelectedMachineLabel;
    }
}
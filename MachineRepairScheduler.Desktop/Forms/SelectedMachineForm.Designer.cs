namespace MachineRepairScheduler.Desktop.Forms
{
    partial class SelectedMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedMachineForm));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.machineDataTabPage = new System.Windows.Forms.TabPage();
            this.deleteSelectedMachinePictureBox = new System.Windows.Forms.PictureBox();
            this.selectedMachineTable = new System.Windows.Forms.DataGridView();
            this.editMachineTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manufacturerNameEditMachineTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.yearOfManufactureEditMachineTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.machineNameEditMachineTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.errorEditMachineLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.serialNumberEditMachineTextBox = new System.Windows.Forms.TextBox();
            this.editMachine = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.machineDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedMachinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMachineTable)).BeginInit();
            this.editMachineTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.machineDataTabPage);
            this.tabControl2.Controls.Add(this.editMachineTabPage);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1965, 800);
            this.tabControl2.TabIndex = 2;
            // 
            // machineDataTabPage
            // 
            this.machineDataTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.machineDataTabPage.Controls.Add(this.deleteSelectedMachinePictureBox);
            this.machineDataTabPage.Controls.Add(this.selectedMachineTable);
            this.machineDataTabPage.Location = new System.Drawing.Point(4, 47);
            this.machineDataTabPage.Name = "machineDataTabPage";
            this.machineDataTabPage.Size = new System.Drawing.Size(1957, 749);
            this.machineDataTabPage.TabIndex = 2;
            this.machineDataTabPage.Text = "Machine data";
            // 
            // deleteSelectedMachinePictureBox
            // 
            this.deleteSelectedMachinePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedMachinePictureBox.Image")));
            this.deleteSelectedMachinePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("deleteSelectedMachinePictureBox.InitialImage")));
            this.deleteSelectedMachinePictureBox.Location = new System.Drawing.Point(1533, 598);
            this.deleteSelectedMachinePictureBox.Name = "deleteSelectedMachinePictureBox";
            this.deleteSelectedMachinePictureBox.Size = new System.Drawing.Size(67, 60);
            this.deleteSelectedMachinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteSelectedMachinePictureBox.TabIndex = 2;
            this.deleteSelectedMachinePictureBox.TabStop = false;
            this.deleteSelectedMachinePictureBox.Click += new System.EventHandler(this.deleteSelectedMachinePictureBox_Click);
            // 
            // selectedMachineTable
            // 
            this.selectedMachineTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedMachineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedMachineTable.Location = new System.Drawing.Point(6, 308);
            this.selectedMachineTable.Name = "selectedMachineTable";
            this.selectedMachineTable.RowHeadersWidth = 51;
            this.selectedMachineTable.RowTemplate.Height = 65;
            this.selectedMachineTable.Size = new System.Drawing.Size(1594, 150);
            this.selectedMachineTable.TabIndex = 0;
            // 
            // editMachineTabPage
            // 
            this.editMachineTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editMachineTabPage.Controls.Add(this.groupBox1);
            this.editMachineTabPage.Location = new System.Drawing.Point(4, 47);
            this.editMachineTabPage.Name = "editMachineTabPage";
            this.editMachineTabPage.Size = new System.Drawing.Size(1957, 749);
            this.editMachineTabPage.TabIndex = 3;
            this.editMachineTabPage.Text = "Edit machine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manufacturerNameEditMachineTextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.yearOfManufactureEditMachineTextBox);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.machineNameEditMachineTextBox);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.errorEditMachineLabel);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.serialNumberEditMachineTextBox);
            this.groupBox1.Controls.Add(this.editMachine);
            this.groupBox1.Location = new System.Drawing.Point(148, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 745);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // manufacturerNameEditMachineTextBox
            // 
            this.manufacturerNameEditMachineTextBox.BackColor = System.Drawing.Color.White;
            this.manufacturerNameEditMachineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manufacturerNameEditMachineTextBox.Location = new System.Drawing.Point(28, 513);
            this.manufacturerNameEditMachineTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturerNameEditMachineTextBox.Name = "manufacturerNameEditMachineTextBox";
            this.manufacturerNameEditMachineTextBox.Size = new System.Drawing.Size(544, 55);
            this.manufacturerNameEditMachineTextBox.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(20, 671);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(525, 48);
            this.label16.TabIndex = 32;
            this.label16.Text = "* Marked fields are optional";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(1264, 520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 48);
            this.label17.TabIndex = 31;
            this.label17.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(706, 462);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(397, 48);
            this.label19.TabIndex = 30;
            this.label19.Text = "Year of manufacture";
            // 
            // yearOfManufactureEditMachineTextBox
            // 
            this.yearOfManufactureEditMachineTextBox.BackColor = System.Drawing.Color.White;
            this.yearOfManufactureEditMachineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearOfManufactureEditMachineTextBox.Location = new System.Drawing.Point(714, 513);
            this.yearOfManufactureEditMachineTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearOfManufactureEditMachineTextBox.Name = "yearOfManufactureEditMachineTextBox";
            this.yearOfManufactureEditMachineTextBox.Size = new System.Drawing.Size(544, 55);
            this.yearOfManufactureEditMachineTextBox.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(706, 243);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(293, 48);
            this.label21.TabIndex = 28;
            this.label21.Text = "Machine name";
            // 
            // machineNameEditMachineTextBox
            // 
            this.machineNameEditMachineTextBox.BackColor = System.Drawing.Color.White;
            this.machineNameEditMachineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.machineNameEditMachineTextBox.Location = new System.Drawing.Point(714, 293);
            this.machineNameEditMachineTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.machineNameEditMachineTextBox.Name = "machineNameEditMachineTextBox";
            this.machineNameEditMachineTextBox.Size = new System.Drawing.Size(544, 55);
            this.machineNameEditMachineTextBox.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(19, 462);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(381, 48);
            this.label22.TabIndex = 26;
            this.label22.Text = "Manufacturer name";
            // 
            // errorEditMachineLabel
            // 
            this.errorEditMachineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorEditMachineLabel.ForeColor = System.Drawing.Color.Red;
            this.errorEditMachineLabel.Location = new System.Drawing.Point(6, 40);
            this.errorEditMachineLabel.Name = "errorEditMachineLabel";
            this.errorEditMachineLabel.Size = new System.Drawing.Size(1301, 184);
            this.errorEditMachineLabel.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(19, 243);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(280, 48);
            this.label26.TabIndex = 24;
            this.label26.Text = "Serial number";
            // 
            // serialNumberEditMachineTextBox
            // 
            this.serialNumberEditMachineTextBox.BackColor = System.Drawing.Color.White;
            this.serialNumberEditMachineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serialNumberEditMachineTextBox.Location = new System.Drawing.Point(28, 293);
            this.serialNumberEditMachineTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serialNumberEditMachineTextBox.Name = "serialNumberEditMachineTextBox";
            this.serialNumberEditMachineTextBox.Size = new System.Drawing.Size(544, 55);
            this.serialNumberEditMachineTextBox.TabIndex = 22;
            // 
            // editMachine
            // 
            this.editMachine.BackColor = System.Drawing.Color.White;
            this.editMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editMachine.Location = new System.Drawing.Point(1050, 635);
            this.editMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editMachine.Name = "editMachine";
            this.editMachine.Size = new System.Drawing.Size(257, 115);
            this.editMachine.TabIndex = 23;
            this.editMachine.Text = "Edit machine";
            this.editMachine.UseVisualStyleBackColor = false;
            this.editMachine.Click += new System.EventHandler(this.editMachine_Click);
            // 
            // SelectedMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1979, 937);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectedMachineForm";
            this.Text = "Selected machine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectedMachineForm_FormClosed);
            this.tabControl2.ResumeLayout(false);
            this.machineDataTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteSelectedMachinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMachineTable)).EndInit();
            this.editMachineTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage machineDataTabPage;
        private System.Windows.Forms.PictureBox deleteSelectedMachinePictureBox;
        private System.Windows.Forms.DataGridView selectedMachineTable;
        private System.Windows.Forms.TabPage editMachineTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox manufacturerNameEditMachineTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox yearOfManufactureEditMachineTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox machineNameEditMachineTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label errorEditMachineLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox serialNumberEditMachineTextBox;
        private System.Windows.Forms.Button editMachine;
    }
}
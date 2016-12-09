using System;

namespace Personalmanager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.boxRole = new System.Windows.Forms.ComboBox();
            this.boxStore = new System.Windows.Forms.ComboBox();
            this.boxBirthdate = new System.Windows.Forms.DateTimePicker();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxOnleave = new System.Windows.Forms.CheckBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxLastname = new System.Windows.Forms.TextBox();
            this.boxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.storesTab = new System.Windows.Forms.TabPage();
            this.showUsersBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickStoreBox = new System.Windows.Forms.ListBox();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.storesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.employeesTab);
            this.tabControl.Controls.Add(this.storesTab);
            this.tabControl.Location = new System.Drawing.Point(12, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(563, 384);
            this.tabControl.TabIndex = 0;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.boxRole);
            this.employeesTab.Controls.Add(this.boxStore);
            this.employeesTab.Controls.Add(this.boxBirthdate);
            this.employeesTab.Controls.Add(this.birthdateLabel);
            this.employeesTab.Controls.Add(this.buttonAdd);
            this.employeesTab.Controls.Add(this.buttonDelete);
            this.employeesTab.Controls.Add(this.buttonSave);
            this.employeesTab.Controls.Add(this.label7);
            this.employeesTab.Controls.Add(this.label8);
            this.employeesTab.Controls.Add(this.boxSalary);
            this.employeesTab.Controls.Add(this.label6);
            this.employeesTab.Controls.Add(this.label4);
            this.employeesTab.Controls.Add(this.label3);
            this.employeesTab.Controls.Add(this.label2);
            this.employeesTab.Controls.Add(this.boxOnleave);
            this.employeesTab.Controls.Add(this.boxEmail);
            this.employeesTab.Controls.Add(this.boxLastname);
            this.employeesTab.Controls.Add(this.boxFirstname);
            this.employeesTab.Controls.Add(this.label1);
            this.employeesTab.Controls.Add(this.employeeListBox);
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTab.Size = new System.Drawing.Size(555, 358);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            this.employeesTab.Click += new System.EventHandler(this.employeesTab_Click);
            // 
            // boxRole
            // 
            this.boxRole.DisplayMember = "name";
            this.boxRole.FormattingEnabled = true;
            this.boxRole.Location = new System.Drawing.Point(281, 154);
            this.boxRole.Name = "boxRole";
            this.boxRole.Size = new System.Drawing.Size(252, 21);
            this.boxRole.TabIndex = 41;
            this.boxRole.ValueMember = "id";
            // 
            // boxStore
            // 
            this.boxStore.DisplayMember = "name";
            this.boxStore.FormattingEnabled = true;
            this.boxStore.Location = new System.Drawing.Point(281, 232);
            this.boxStore.Name = "boxStore";
            this.boxStore.Size = new System.Drawing.Size(252, 21);
            this.boxStore.TabIndex = 40;
            this.boxStore.ValueMember = "id";
            // 
            // boxBirthdate
            // 
            this.boxBirthdate.CausesValidation = false;
            this.boxBirthdate.Location = new System.Drawing.Point(281, 271);
            this.boxBirthdate.Name = "boxBirthdate";
            this.boxBirthdate.Size = new System.Drawing.Size(252, 20);
            this.boxBirthdate.TabIndex = 38;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(279, 255);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdateLabel.TabIndex = 39;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 316);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(256, 31);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add new employee";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(377, 324);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(458, 324);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Store";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salary";
            // 
            // boxSalary
            // 
            this.boxSalary.Location = new System.Drawing.Point(281, 193);
            this.boxSalary.Name = "boxSalary";
            this.boxSalary.Size = new System.Drawing.Size(252, 20);
            this.boxSalary.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role / Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // boxOnleave
            // 
            this.boxOnleave.AutoSize = true;
            this.boxOnleave.Location = new System.Drawing.Point(367, 297);
            this.boxOnleave.Name = "boxOnleave";
            this.boxOnleave.Size = new System.Drawing.Size(69, 17);
            this.boxOnleave.TabIndex = 8;
            this.boxOnleave.Text = "Available";
            this.boxOnleave.UseVisualStyleBackColor = true;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(281, 114);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(252, 20);
            this.boxEmail.TabIndex = 3;
            // 
            // boxLastname
            // 
            this.boxLastname.Location = new System.Drawing.Point(281, 75);
            this.boxLastname.Name = "boxLastname";
            this.boxLastname.Size = new System.Drawing.Size(252, 20);
            this.boxLastname.TabIndex = 2;
            // 
            // boxFirstname
            // 
            this.boxFirstname.Location = new System.Drawing.Point(281, 36);
            this.boxFirstname.Name = "boxFirstname";
            this.boxFirstname.Size = new System.Drawing.Size(252, 20);
            this.boxFirstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select employee";
            // 
            // employeeListBox
            // 
            this.employeeListBox.AccessibleName = "employeeList";
            this.employeeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(15, 36);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(256, 262);
            this.employeeListBox.Sorted = true;
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // storesTab
            // 
            this.storesTab.Controls.Add(this.showUsersBox);
            this.storesTab.Controls.Add(this.label5);
            this.storesTab.Controls.Add(this.pickStoreBox);
            this.storesTab.Location = new System.Drawing.Point(4, 22);
            this.storesTab.Name = "storesTab";
            this.storesTab.Padding = new System.Windows.Forms.Padding(3);
            this.storesTab.Size = new System.Drawing.Size(555, 358);
            this.storesTab.TabIndex = 1;
            this.storesTab.Text = "Stores";
            this.storesTab.UseVisualStyleBackColor = true;
            // 
            // showUsersBox
            // 
            this.showUsersBox.DisplayMember = "name";
            this.showUsersBox.FormattingEnabled = true;
            this.showUsersBox.Location = new System.Drawing.Point(277, 39);
            this.showUsersBox.Name = "showUsersBox";
            this.showUsersBox.Size = new System.Drawing.Size(255, 303);
            this.showUsersBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pick store to see which employees work there";
            // 
            // pickStoreBox
            // 
            this.pickStoreBox.DisplayMember = "name";
            this.pickStoreBox.FormattingEnabled = true;
            this.pickStoreBox.Location = new System.Drawing.Point(16, 39);
            this.pickStoreBox.Name = "pickStoreBox";
            this.pickStoreBox.Size = new System.Drawing.Size(255, 303);
            this.pickStoreBox.TabIndex = 0;
            this.pickStoreBox.SelectedIndexChanged += new System.EventHandler(this.pickStoreBox_SelectedIndexChanged);
            // 
            // logoImage
            // 
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(12, 13);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(275, 40);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 454);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Personal manager v0.5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.tabControl.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.employeesTab.PerformLayout();
            this.storesTab.ResumeLayout(false);
            this.storesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage storesTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox boxOnleave;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxLastname;
        private System.Windows.Forms.TextBox boxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxSalary;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.ComboBox boxStore;
        private System.Windows.Forms.ListBox pickStoreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxRole;
        private System.Windows.Forms.ListBox showUsersBox;
        public System.Windows.Forms.ListBox employeeListBox;
        public System.Windows.Forms.DateTimePicker boxBirthdate;
    }
}


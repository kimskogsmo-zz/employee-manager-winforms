using System;

namespace Personalmanager
{
    partial class NewUser
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.boxFirstname = new System.Windows.Forms.TextBox();
            this.boxLastname = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxOnleave = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxRole = new System.Windows.Forms.ComboBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.boxBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.boxStore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(11, 301);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(145, 301);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(53, 330);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(163, 23);
            this.buttonDiscard.TabIndex = 11;
            this.buttonDiscard.Text = "Discard and abort mission";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // boxFirstname
            // 
            this.boxFirstname.Location = new System.Drawing.Point(12, 29);
            this.boxFirstname.Name = "boxFirstname";
            this.boxFirstname.Size = new System.Drawing.Size(252, 20);
            this.boxFirstname.TabIndex = 1;
            // 
            // boxLastname
            // 
            this.boxLastname.Location = new System.Drawing.Point(12, 68);
            this.boxLastname.Name = "boxLastname";
            this.boxLastname.Size = new System.Drawing.Size(252, 20);
            this.boxLastname.TabIndex = 2;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(12, 107);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(252, 20);
            this.boxEmail.TabIndex = 3;
            // 
            // boxOnleave
            // 
            this.boxOnleave.AutoSize = true;
            this.boxOnleave.Location = new System.Drawing.Point(194, 229);
            this.boxOnleave.Name = "boxOnleave";
            this.boxOnleave.Size = new System.Drawing.Size(69, 17);
            this.boxOnleave.TabIndex = 7;
            this.boxOnleave.Text = "Available";
            this.boxOnleave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Role / Position";
            // 
            // boxSalary
            // 
            this.boxSalary.Location = new System.Drawing.Point(11, 188);
            this.boxSalary.Name = "boxSalary";
            this.boxSalary.Size = new System.Drawing.Size(252, 20);
            this.boxSalary.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Salary";
            // 
            // boxRole
            // 
            this.boxRole.DisplayMember = "name";
            this.boxRole.FormattingEnabled = true;
            this.boxRole.Location = new System.Drawing.Point(12, 148);
            this.boxRole.Name = "boxRole";
            this.boxRole.Size = new System.Drawing.Size(252, 21);
            this.boxRole.TabIndex = 4;
            this.boxRole.SelectedIndexChanged += new System.EventHandler(this.boxRole_SelectedIndexChanged);
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(9, 213);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(49, 13);
            this.birthdateLabel.TabIndex = 37;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // boxBirthdate
            // 
            this.boxBirthdate.Location = new System.Drawing.Point(11, 229);
            this.boxBirthdate.Name = "boxBirthdate";
            this.boxBirthdate.Size = new System.Drawing.Size(159, 20);
            this.boxBirthdate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Store";
            // 
            // boxStore
            // 
            this.boxStore.DisplayMember = "name";
            this.boxStore.FormattingEnabled = true;
            this.boxStore.Location = new System.Drawing.Point(11, 268);
            this.boxStore.Name = "boxStore";
            this.boxStore.Size = new System.Drawing.Size(252, 21);
            this.boxStore.TabIndex = 8;
            this.boxStore.SelectedIndexChanged += new System.EventHandler(this.boxStore_SelectedIndexChanged);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 362);
            this.Controls.Add(this.boxStore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxBirthdate);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.boxRole);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxOnleave);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxLastname);
            this.Controls.Add(this.boxFirstname);
            this.Name = "NewUser";
            this.Text = "Add new user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void NewUser_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.ComboBox boxRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox boxOnleave;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxLastname;
        private System.Windows.Forms.TextBox boxFirstname;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker boxBirthdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxStore;
    }
}
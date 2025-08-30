namespace DatabaseManager.View
{
    partial class AddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddFormLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.phnNameTextBox = new System.Windows.Forms.TextBox();
            this.PhnNbrLabel = new System.Windows.Forms.Label();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.profileLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPswdTextBox = new System.Windows.Forms.TextBox();
            this.confPasswordLabel = new System.Windows.Forms.Label();
            this.showPswdCheckBox = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddFormLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 72);
            this.panel1.TabIndex = 0;
            // 
            // AddFormLabel
            // 
            this.AddFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFormLabel.AutoSize = true;
            this.AddFormLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFormLabel.Location = new System.Drawing.Point(17, 26);
            this.AddFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddFormLabel.Name = "AddFormLabel";
            this.AddFormLabel.Size = new System.Drawing.Size(153, 31);
            this.AddFormLabel.TabIndex = 0;
            this.AddFormLabel.Text = "Add Account";
            this.AddFormLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(17, 93);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(101, 28);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(200, 90);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(416, 34);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(200, 130);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(416, 34);
            this.middleNameTextBox.TabIndex = 9;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(17, 133);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(126, 28);
            this.MiddleNameLabel.TabIndex = 8;
            this.MiddleNameLabel.Text = "MiddleName";
            this.MiddleNameLabel.Click += new System.EventHandler(this.MiddleNameLabel_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(200, 170);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(416, 34);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(17, 173);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(98, 28);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "LastName";
            // 
            // phnNameTextBox
            // 
            this.phnNameTextBox.Location = new System.Drawing.Point(200, 210);
            this.phnNameTextBox.Name = "phnNameTextBox";
            this.phnNameTextBox.Size = new System.Drawing.Size(416, 34);
            this.phnNameTextBox.TabIndex = 13;
            // 
            // PhnNbrLabel
            // 
            this.PhnNbrLabel.AutoSize = true;
            this.PhnNbrLabel.Location = new System.Drawing.Point(17, 213);
            this.PhnNbrLabel.Name = "PhnNbrLabel";
            this.PhnNbrLabel.Size = new System.Drawing.Size(79, 28);
            this.PhnNbrLabel.TabIndex = 12;
            this.PhnNbrLabel.Text = "PhnNbr";
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(200, 250);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(317, 34);
            this.profileTextBox.TabIndex = 15;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(17, 253);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(68, 28);
            this.profileLabel.TabIndex = 14;
            this.profileLabel.Text = "Profile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(200, 290);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(416, 34);
            this.passwordTextBox.TabIndex = 18;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(17, 293);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 28);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPswdTextBox
            // 
            this.confirmPswdTextBox.Location = new System.Drawing.Point(200, 330);
            this.confirmPswdTextBox.Name = "confirmPswdTextBox";
            this.confirmPswdTextBox.Size = new System.Drawing.Size(416, 34);
            this.confirmPswdTextBox.TabIndex = 20;
            // 
            // confPasswordLabel
            // 
            this.confPasswordLabel.AutoSize = true;
            this.confPasswordLabel.Location = new System.Drawing.Point(17, 333);
            this.confPasswordLabel.Name = "confPasswordLabel";
            this.confPasswordLabel.Size = new System.Drawing.Size(168, 28);
            this.confPasswordLabel.TabIndex = 19;
            this.confPasswordLabel.Text = "Confirm Password";
            // 
            // showPswdCheckBox
            // 
            this.showPswdCheckBox.AutoSize = true;
            this.showPswdCheckBox.Location = new System.Drawing.Point(23, 385);
            this.showPswdCheckBox.Name = "showPswdCheckBox";
            this.showPswdCheckBox.Size = new System.Drawing.Size(168, 32);
            this.showPswdCheckBox.TabIndex = 21;
            this.showPswdCheckBox.Text = "Show Password";
            this.showPswdCheckBox.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(200, 378);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(418, 45);
            this.createButton.TabIndex = 22;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 447);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.showPswdCheckBox);
            this.Controls.Add(this.confirmPswdTextBox);
            this.Controls.Add(this.confPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.phnNameTextBox);
            this.Controls.Add(this.PhnNbrLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddFormLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox phnNameTextBox;
        private System.Windows.Forms.Label PhnNbrLabel;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confirmPswdTextBox;
        private System.Windows.Forms.Label confPasswordLabel;
        private System.Windows.Forms.CheckBox showPswdCheckBox;
        private System.Windows.Forms.Button createButton;
    }
}
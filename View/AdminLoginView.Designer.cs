namespace DatabaseManager
{
    partial class AdminLogin
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
            this.LoginDesign = new System.Windows.Forms.Panel();
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.loginShowPswdCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.CreateAcountTab = new System.Windows.Forms.TabPage();
            this.CreateShowPswdCheckBox = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.ConfPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPswdLabel = new System.Windows.Forms.Label();
            this.createPswdTextBox = new System.Windows.Forms.TextBox();
            this.createPswdLabel = new System.Windows.Forms.Label();
            this.ProfileSelectButton = new System.Windows.Forms.Button();
            this.ProfileTextBox = new System.Windows.Forms.TextBox();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.PhnNbrCodeComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneNbrTextBox = new System.Windows.Forms.TextBox();
            this.PhnNbrLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.LoginTabControl.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.CreateAcountTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginDesign
            // 
            this.LoginDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginDesign.Location = new System.Drawing.Point(0, 0);
            this.LoginDesign.Name = "LoginDesign";
            this.LoginDesign.Size = new System.Drawing.Size(370, 568);
            this.LoginDesign.TabIndex = 0;
            // 
            // LoginTabControl
            // 
            this.LoginTabControl.Controls.Add(this.LoginTab);
            this.LoginTabControl.Controls.Add(this.CreateAcountTab);
            this.LoginTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginTabControl.Location = new System.Drawing.Point(372, 0);
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(580, 568);
            this.LoginTabControl.TabIndex = 1;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.loginShowPswdCheckBox);
            this.LoginTab.Controls.Add(this.LoginButton);
            this.LoginTab.Controls.Add(this.PasswordTextBox);
            this.LoginTab.Controls.Add(this.PasswordLabel);
            this.LoginTab.Controls.Add(this.UserIDTextBox);
            this.LoginTab.Controls.Add(this.UserIDLabel);
            this.LoginTab.Location = new System.Drawing.Point(4, 37);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(572, 527);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // loginShowPswdCheckBox
            // 
            this.loginShowPswdCheckBox.AutoSize = true;
            this.loginShowPswdCheckBox.Location = new System.Drawing.Point(70, 253);
            this.loginShowPswdCheckBox.Name = "loginShowPswdCheckBox";
            this.loginShowPswdCheckBox.Size = new System.Drawing.Size(168, 32);
            this.loginShowPswdCheckBox.TabIndex = 4;
            this.loginShowPswdCheckBox.Text = "Show Password";
            this.loginShowPswdCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(240, 249);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(280, 39);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(171, 209);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(349, 34);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(65, 212);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(93, 28);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(171, 169);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(349, 34);
            this.UserIDTextBox.TabIndex = 2;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(65, 172);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(70, 28);
            this.UserIDLabel.TabIndex = 0;
            this.UserIDLabel.Text = "UserID";
            // 
            // CreateAcountTab
            // 
            this.CreateAcountTab.Controls.Add(this.ProfilePanel);
            this.CreateAcountTab.Controls.Add(this.CreateShowPswdCheckBox);
            this.CreateAcountTab.Controls.Add(this.createButton);
            this.CreateAcountTab.Controls.Add(this.ConfPasswordTextBox);
            this.CreateAcountTab.Controls.Add(this.confirmPswdLabel);
            this.CreateAcountTab.Controls.Add(this.createPswdTextBox);
            this.CreateAcountTab.Controls.Add(this.createPswdLabel);
            this.CreateAcountTab.Controls.Add(this.ProfileSelectButton);
            this.CreateAcountTab.Controls.Add(this.ProfileTextBox);
            this.CreateAcountTab.Controls.Add(this.ProfileLabel);
            this.CreateAcountTab.Controls.Add(this.PhnNbrCodeComboBox);
            this.CreateAcountTab.Controls.Add(this.PhoneNbrTextBox);
            this.CreateAcountTab.Controls.Add(this.PhnNbrLabel);
            this.CreateAcountTab.Controls.Add(this.LastNameTextBox);
            this.CreateAcountTab.Controls.Add(this.LastNameLabel);
            this.CreateAcountTab.Controls.Add(this.MiddleNameTextBox);
            this.CreateAcountTab.Controls.Add(this.MiddleNameLabel);
            this.CreateAcountTab.Controls.Add(this.FirstNameTextBox);
            this.CreateAcountTab.Controls.Add(this.FirstLabel);
            this.CreateAcountTab.Location = new System.Drawing.Point(4, 37);
            this.CreateAcountTab.Name = "CreateAcountTab";
            this.CreateAcountTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateAcountTab.Size = new System.Drawing.Size(572, 527);
            this.CreateAcountTab.TabIndex = 1;
            this.CreateAcountTab.Text = "CreateAccount";
            this.CreateAcountTab.UseVisualStyleBackColor = true;
            // 
            // CreateShowPswdCheckBox
            // 
            this.CreateShowPswdCheckBox.AutoSize = true;
            this.CreateShowPswdCheckBox.Location = new System.Drawing.Point(55, 445);
            this.CreateShowPswdCheckBox.Name = "CreateShowPswdCheckBox";
            this.CreateShowPswdCheckBox.Size = new System.Drawing.Size(168, 32);
            this.CreateShowPswdCheckBox.TabIndex = 14;
            this.CreateShowPswdCheckBox.Text = "Show Password";
            this.CreateShowPswdCheckBox.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(224, 439);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(323, 38);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // ConfPasswordTextBox
            // 
            this.ConfPasswordTextBox.Location = new System.Drawing.Point(224, 399);
            this.ConfPasswordTextBox.Name = "ConfPasswordTextBox";
            this.ConfPasswordTextBox.Size = new System.Drawing.Size(323, 34);
            this.ConfPasswordTextBox.TabIndex = 13;
            this.ConfPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPswdLabel
            // 
            this.confirmPswdLabel.AutoSize = true;
            this.confirmPswdLabel.Location = new System.Drawing.Point(50, 402);
            this.confirmPswdLabel.Name = "confirmPswdLabel";
            this.confirmPswdLabel.Size = new System.Drawing.Size(168, 28);
            this.confirmPswdLabel.TabIndex = 0;
            this.confirmPswdLabel.Text = "Confirm Password";
            // 
            // createPswdTextBox
            // 
            this.createPswdTextBox.BackColor = System.Drawing.Color.White;
            this.createPswdTextBox.Location = new System.Drawing.Point(224, 359);
            this.createPswdTextBox.Name = "createPswdTextBox";
            this.createPswdTextBox.Size = new System.Drawing.Size(323, 34);
            this.createPswdTextBox.TabIndex = 12;
            this.createPswdTextBox.UseSystemPasswordChar = true;
            // 
            // createPswdLabel
            // 
            this.createPswdLabel.AutoSize = true;
            this.createPswdLabel.Location = new System.Drawing.Point(50, 362);
            this.createPswdLabel.Name = "createPswdLabel";
            this.createPswdLabel.Size = new System.Drawing.Size(93, 28);
            this.createPswdLabel.TabIndex = 0;
            this.createPswdLabel.Text = "Password";
            // 
            // ProfileSelectButton
            // 
            this.ProfileSelectButton.Location = new System.Drawing.Point(460, 318);
            this.ProfileSelectButton.Name = "ProfileSelectButton";
            this.ProfileSelectButton.Size = new System.Drawing.Size(87, 37);
            this.ProfileSelectButton.TabIndex = 11;
            this.ProfileSelectButton.Text = "Select";
            this.ProfileSelectButton.UseVisualStyleBackColor = true;
            // 
            // ProfileTextBox
            // 
            this.ProfileTextBox.Location = new System.Drawing.Point(224, 319);
            this.ProfileTextBox.Name = "ProfileTextBox";
            this.ProfileTextBox.Size = new System.Drawing.Size(230, 34);
            this.ProfileTextBox.TabIndex = 0;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(50, 322);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(68, 28);
            this.ProfileLabel.TabIndex = 0;
            this.ProfileLabel.Text = "Profile";
            // 
            // PhnNbrCodeComboBox
            // 
            this.PhnNbrCodeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhnNbrCodeComboBox.CausesValidation = false;
            this.PhnNbrCodeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhnNbrCodeComboBox.FormattingEnabled = true;
            this.PhnNbrCodeComboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PhnNbrCodeComboBox.IntegralHeight = false;
            this.PhnNbrCodeComboBox.ItemHeight = 28;
            this.PhnNbrCodeComboBox.Items.AddRange(new object[] {
            "",
            "+7",
            "+250"});
            this.PhnNbrCodeComboBox.Location = new System.Drawing.Point(224, 279);
            this.PhnNbrCodeComboBox.MaximumSize = new System.Drawing.Size(89, 0);
            this.PhnNbrCodeComboBox.MaxLength = 34;
            this.PhnNbrCodeComboBox.MinimumSize = new System.Drawing.Size(89, 0);
            this.PhnNbrCodeComboBox.Name = "PhnNbrCodeComboBox";
            this.PhnNbrCodeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhnNbrCodeComboBox.Size = new System.Drawing.Size(89, 36);
            this.PhnNbrCodeComboBox.TabIndex = 9;
            // 
            // PhoneNbrTextBox
            // 
            this.PhoneNbrTextBox.Location = new System.Drawing.Point(319, 279);
            this.PhoneNbrTextBox.Name = "PhoneNbrTextBox";
            this.PhoneNbrTextBox.Size = new System.Drawing.Size(228, 34);
            this.PhoneNbrTextBox.TabIndex = 10;
            // 
            // PhnNbrLabel
            // 
            this.PhnNbrLabel.AutoSize = true;
            this.PhnNbrLabel.Location = new System.Drawing.Point(50, 282);
            this.PhnNbrLabel.Name = "PhnNbrLabel";
            this.PhnNbrLabel.Size = new System.Drawing.Size(139, 28);
            this.PhnNbrLabel.TabIndex = 0;
            this.PhnNbrLabel.Text = "PhoneNumber";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(224, 239);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(323, 34);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(50, 242);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(98, 28);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "LastName";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(224, 199);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(323, 34);
            this.MiddleNameTextBox.TabIndex = 7;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(50, 202);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(126, 28);
            this.MiddleNameLabel.TabIndex = 0;
            this.MiddleNameLabel.Text = "MiddleName";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(224, 159);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(323, 34);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(50, 162);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(101, 28);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "FirstName";
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Location = new System.Drawing.Point(51, 12);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(140, 140);
            this.ProfilePanel.TabIndex = 16;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 568);
            this.Controls.Add(this.LoginTabControl);
            this.Controls.Add(this.LoginDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.LoginTabControl.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.CreateAcountTab.ResumeLayout(false);
            this.CreateAcountTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginDesign;
        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.TabPage CreateAcountTab;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox loginShowPswdCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PhoneNbrTextBox;
        private System.Windows.Forms.Label PhnNbrLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.ComboBox PhnNbrCodeComboBox;
        private System.Windows.Forms.Button ProfileSelectButton;
        private System.Windows.Forms.TextBox ProfileTextBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.TextBox ConfPasswordTextBox;
        private System.Windows.Forms.Label confirmPswdLabel;
        private System.Windows.Forms.TextBox createPswdTextBox;
        private System.Windows.Forms.Label createPswdLabel;
        private System.Windows.Forms.CheckBox CreateShowPswdCheckBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel ProfilePanel;
    }
}


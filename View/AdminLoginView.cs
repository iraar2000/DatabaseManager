using DatabaseManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager
{
    public partial class AdminLogin : Form, IAdminLoginView
    {
        public AdminLogin()
        {
            InitializeComponent();
            LoginButton.Click += (s, e)  => LoginBtnClicked?.Invoke(this, EventArgs.Empty);
            createButton.Click += (s, e) => createBtnClicked?.Invoke(this, EventArgs.Empty);
            ProfileSelectButton.Click += (s, e) => selectProfileBtnClicked?.Invoke(this, EventArgs.Empty);
            loginShowPswdCheckBox.Click += (s, e) => loginShowPswdChecked?.Invoke(this, EventArgs.Empty);
            CreateShowPswdCheckBox.Click += (s, e) => createShowPswdChecked?.Invoke(this, EventArgs.Empty);
        }

        //
        // Login Tab
        //

        public string UserID => UserIDTextBox.Text;
        public string loginPassword => PasswordTextBox.Text;
        public bool loginShowPassword => loginShowPswdCheckBox.Checked;

        public event EventHandler LoginBtnClicked;
        public event EventHandler loginShowPswdChecked;
        //
        // Create Account Tab d
        //
        public string firstName => FirstNameTextBox.Text;
        public string lastName => LastNameTextBox.Text;
        public string middleName => MiddleNameTextBox.Text;
        public string phoneNumber => $"{PhnNbrCodeComboBox.SelectedItem} {PhoneNbrTextBox.Text}";
        public string profile => ProfileTextBox.Text;
        public string createPassword => createPswdTextBox.Text; 
        public string createConfirmPassword =>  ConfPasswordTextBox.Text;
        public bool createShowPassword => CreateShowPswdCheckBox.Checked;

        public event EventHandler createBtnClicked;
        public event EventHandler createShowPswdChecked;
        public event EventHandler selectProfileBtnClicked;

        //
        // unsetting the textbox values and label visualization
        //
        public void unsetValues(bool unset)
        {
            createPswdTextBox.Text = "";
            ConfPasswordTextBox.Text = "";
            switch (unset)
            {
                case true:
                    createPswdLabel.ForeColor = Color.Red;
                    confirmPswdLabel.ForeColor = Color.Red;
                    break;
                case false:
                    FirstNameTextBox.Text = "";
                    MiddleNameTextBox.Text = "";
                    LastNameTextBox.Text = "";
                    ProfileTextBox.Text = "";
                    PhoneNbrTextBox.Text = "";
                    PhnNbrCodeComboBox.SelectedIndex = 0;

                    createPswdLabel.ForeColor = Color.Black;
                    confirmPswdLabel.ForeColor = Color.Black;
                    break;

            }
        }

        public void viewLoginPassword(bool View) 
        {
            switch (View) 
            {
                case true:
                    PasswordTextBox.UseSystemPasswordChar = false;
                    break;
                case false:
                    PasswordTextBox.UseSystemPasswordChar = true;
                    break;
            }
                
        }
        public void viewCreatePassword(bool View) 
        {
            switch (View)
            {
                case true:
                    createPswdTextBox.UseSystemPasswordChar = false;
                    ConfPasswordTextBox.UseSystemPasswordChar = false;
                    break;
                case false:
                    createPswdTextBox.UseSystemPasswordChar = true;
                    ConfPasswordTextBox.UseSystemPasswordChar = true;
                    break;
            }
            
        }
        public void setProfilePath(string profilePath)
        {
            ProfileTextBox.Text = profilePath;
            ProfilePanel.BackgroundImage = Image.FromFile(profilePath);
            ProfilePanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setVisibility(string Visibility)
        {
            switch (Visibility)
            {
                case "Show": Visible = true;  break;
                case "Hide": Visible = false; break;
            }
        }

    }
}

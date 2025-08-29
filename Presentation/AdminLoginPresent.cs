using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseManager.View;
using DatabaseManager.Model;
using System.Windows.Forms;

namespace DatabaseManager.Presentation
{
    public class AdminLoginPresent
    {
        private readonly IAdminLoginView _adminLoginView;
        private readonly AdminLoginServices _adminLoginServices;
        private AdminLoginModel _adminLoginModel;

        public AdminLoginPresent(IAdminLoginView AdminLoginView, AdminLoginServices adminLoginServices,AdminLoginModel adminLoginModel) 
        {
            //
            // data initialization
            //
            _adminLoginView = AdminLoginView;
            _adminLoginModel = adminLoginModel;
            _adminLoginServices = adminLoginServices;
            
            //
            // Event Subscription
            //
            _adminLoginView.LoginBtnClicked += OnLoginClicked;
            _adminLoginView.createBtnClicked += OnCreateClicked;
            _adminLoginView.loginShowPswdChecked += OnLoginCheckBoxClicked;
            _adminLoginView.createShowPswdChecked += OnCreateCheckBoxClicked;
            _adminLoginView.selectProfileBtnClicked += OnSelectProfileBtnClicked;
        }

        public void OnCreateClicked(object sender, EventArgs e)
        {
            //
            // creating a new or editing a LoginModel
            //
            _adminLoginModel = _adminLoginServices.adminLoginModel((AdminLogin)_adminLoginView, Definitions.Tabs.CREATEACCOUNT);

            if (!_adminLoginModel.Password.Equals("NotSet")) 
            {
                //
                // creating an account
                //
                _adminLoginServices.WriteAccountFile(_adminLoginModel);

                //
                // messagebox notification
                //
                MessageBox.Show($"Create Button Clicked\n" +
                        $"UserId: {_adminLoginModel.UserID};\n" +
                        $"Full Name:{_adminLoginModel.FirstName} {_adminLoginModel.LastName};\n" +
                        $"Phone Number: {_adminLoginModel.PhoneNumber};\n" +
                        $"Password: {_adminLoginModel.Password}\n");
            } 
        }

        public void OnLoginClicked(object sender, EventArgs e)
        {
            //
            // login model 
            //

            _adminLoginModel.UserID = _adminLoginView.UserID;
            _adminLoginModel.loginPassword = _adminLoginView.loginPassword;

            //
            // login credential verification
            //
            _adminLoginServices.ReadAccountFile();
            if (_adminLoginServices.LoginVerification(_adminLoginView.UserID, _adminLoginView.loginPassword))
            {
                MessageBox.Show($" Successfully Logged in! ");
            }
        }

        public void OnLoginCheckBoxClicked(object sender, EventArgs e)
        {
            if (_adminLoginView.loginShowPassword) { _adminLoginView.viewLoginPassword(true); }
            else { _adminLoginView.viewLoginPassword(false); }
        }

        public void OnCreateCheckBoxClicked (object sender, EventArgs e)
        {
            if (_adminLoginView.createShowPassword) { _adminLoginView.viewCreatePassword(true); }
            else { _adminLoginView.viewCreatePassword(false); }
        }

        public void OnSelectProfileBtnClicked(object sender, EventArgs e)
        {
            _adminLoginModel.Profile = _adminLoginServices.fileSelection();
            _adminLoginView.setProfilePath(_adminLoginModel.Profile);
        } 

    }
}

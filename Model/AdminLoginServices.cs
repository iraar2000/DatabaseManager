using DatabaseManager;
using DatabaseManager.Data;
using DatabaseManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager.Model
{
    public class AdminLoginServices
    {

        private readonly List<AccountModel> accountList = new List<AccountModel>();
        private DataStorageAccess _accountStorageAccess;
        // private DataStorageAccess _ProfilePathStorageAccess;
        private string Data;
        private int  _countID = 0;
                
        public List<AccountModel> getAccounts => accountList.ToList();
        public bool LoginVerification(string UserID, string Password)
        {
            for (int acc = 0; acc < accountList.Count; acc++)
            {
                if (accountList[acc].UserID == UserID && accountList[acc].Password == Password) { return true; break; }
            } 
            return false;
        }

        public AdminLoginServices(string filePath)
        {
            _accountStorageAccess = new DataStorageAccess(filePath+"Accounts.txt");
            //_ProfilePathStorageAccess = new DataStorageAccess(filePath + "ProfilePath.txt");
        }

        //
        // create account operations
        //
        public void WriteAccountFile(AdminLoginModel Account)
        {
            //
            // writing and appending new data in the file 
            //
            Data = $"{_countID.ToString()},{Account.FirstName},{Account.MiddleName},{Account.LastName},{Account.PhoneNumber},{Account.Profile},{Account.Password}";
            _accountStorageAccess.WriteFile(Data);

            MessageBox.Show("New Account Successfully created");
            _countID++;                // making a new UserID
        }

        //
        // login account operations
        //
        public void ReadAccountFile()
        {
            foreach(AccountModel account in _accountStorageAccess.ReadFile())
            {
                accountList.Add(account);
            }        
        }

        //
        // function for appending content to a model
        //
        public AdminLoginModel adminLoginModel(AdminLogin adminLoginView, Definitions.Tabs TabCode)
        {
            // 
            // Creating an adminLoginModel variable
            //
            AdminLoginModel _adminLoginModel = new AdminLoginModel();

            //
            // Appending the model with the create account view data
            //
            // Admin login model login tab model
            //
            if (TabCode.Equals(Definitions.Tabs.LOGIN))
            {
                _adminLoginModel.UserID = adminLoginView.UserID;
                _adminLoginModel.loginPassword = adminLoginView.loginPassword;
                _adminLoginModel.loginShowPassword = adminLoginView.loginShowPassword;

            }
            //
            // Admin login model create account tab model
            //
            else if (TabCode.Equals(Definitions.Tabs.CREATEACCOUNT))
            {
                _adminLoginModel.UserID = _countID.ToString();
                _adminLoginModel.FirstName = adminLoginView.firstName;
                _adminLoginModel.LastName = adminLoginView.lastName;
                _adminLoginModel.MiddleName = adminLoginView.middleName;
                _adminLoginModel.PhoneNumber = adminLoginView.phoneNumber;
                _adminLoginModel.Profile = adminLoginView.profile;
                _adminLoginModel.createPassword = adminLoginView.createPassword;
                _adminLoginModel.ConfirmPassword = adminLoginView.createConfirmPassword;
                _adminLoginModel.createShowPassword = adminLoginView.createShowPassword;

                if (_adminLoginModel.createPassword == _adminLoginModel.ConfirmPassword)
                {
                    _adminLoginModel.Password = _adminLoginModel.createPassword;
                    adminLoginView.unsetValues(false);
                }
                else 
                {
                    _adminLoginModel.Password = "NotSet";
                    adminLoginView.unsetValues(true);
                    MessageBox.Show(" Please check again the confirmation password! "); 
                }

            }

            //
            // returning the new model of create account which was created
            //
            return _adminLoginModel;
        }

        public string fileSelection() 
        {
            string file = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Win32Study\\DBManager\\DatabaseManager\\Resources\\";
                openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt ";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog.FileName;
                }
            }
            return file.ToString();
        }
    }
}

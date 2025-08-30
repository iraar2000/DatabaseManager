using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.View
{
    public interface IAdminLoginView
    {
        //
        // Login Form 
        //
        string UserID { get; }
        string loginPassword { get; }
        bool loginShowPassword { get; }
        event EventHandler LoginBtnClicked;
        event EventHandler loginShowPswdChecked;
        //
        // Create Account Form
        //
        string firstName{ get; }
        string middleName { get; }
        string lastName { get; }
        string phoneNumber { get; }
        string profile { get; }
        string createPassword { get; }
        string createConfirmPassword { get; }
        bool createShowPassword { get; }
        event EventHandler createBtnClicked;
        event EventHandler createShowPswdChecked;
        event EventHandler selectProfileBtnClicked;

        //
        // methods definition
        //
        void unsetValues(bool unset);
        void viewLoginPassword(bool View);
        void viewCreatePassword(bool View);
        void setProfilePath(string ProfilePath);
        void setVisibility(string  Visibility);
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseManager.Model
{
    public class AdminLoginModel : AccountModel
    {
        //
        // additional elements for Account model.
        //
        public string ConfirmPassword { get; set; }
        public bool createShowPassword { get; set; }
        public bool loginShowPassword { get; set; }
        public string createPassword { get; set; }
        public string loginPassword { get; set; }
    }
}

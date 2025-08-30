using DatabaseManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Data
{
    public interface IDataStorageAccess
    {
        string path { get; }

        //
        // reading file
        // 
        List<AccountModel> ReadFile();
        List<AccountModel> ReadFile(string path);

        //
        // writing file
        //
        void WriteFile(string Data);
        void WriteFile(string path, string Data);

        //
        // Database Access
        //

    }
}

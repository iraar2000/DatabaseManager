using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DatabaseManager.Model;

namespace DatabaseManager.Data
{
    public class DataStorageAccess : IDataStorageAccess
    {
        private string filePath;

        //
        // constructors definition
        //
        public DataStorageAccess() { }
        public DataStorageAccess(string FilePath) 
        {
            filePath = FilePath;
        }
        public string path => filePath;

        //
        // Reading a file's data
        //

        public List<AccountModel> ReadFile(string Path)
        {
            List<AccountModel> accountModels = new List<AccountModel>();
            string Line;
            using (StreamReader Reader = new StreamReader(Path))
            {
                while ((Line = Reader.ReadLine()) != null)
                {
                    List<string> lineData = Line.Split(',').ToList();
                    AccountModel account = new AccountModel();
                    account.UserID = lineData[0];
                    account.FirstName = lineData[1];
                    account.MiddleName = lineData[2];
                    account.LastName = lineData[3];
                    account.PhoneNumber = lineData[4];
                    account.Profile = lineData[5];
                    account.Password = lineData[6];

                    accountModels.Add(account);
                }
            }

            return accountModels;
        }

        public List<AccountModel> ReadFile()
        {
            List<AccountModel> accountModels = new List<AccountModel>();
            string Line;
            using (StreamReader Reader = new StreamReader(filePath))
            {
                while ((Line = Reader.ReadLine()) != null)
                {
                    List<string> lineData = Line.Split(',').ToList();
                    AccountModel account = new AccountModel();
                    account.UserID = lineData[0];
                    account.FirstName = lineData[1];
                    account.MiddleName = lineData[2];
                    account.LastName = lineData[3];
                    account.PhoneNumber = lineData[4];
                    account.Profile = lineData[5];
                    account.Password = lineData[6];

                    accountModels.Add(account);
                }
            }

            return accountModels;
        }

        //
        // Writing a file's data
        //

        public void WriteFile(string Path, string Data)
        {
            using (StreamWriter Writer = new StreamWriter(Path, append:true))
            {
                Writer.WriteLine(Data);
            }
        }

        public void WriteFile(string Data)
        {
            using (StreamWriter Writer = new StreamWriter(filePath, append:true))
            {
                Writer.WriteLine(Data);
            }
        }

        //
        // data formating region
        //

    }
}

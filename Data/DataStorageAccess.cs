using System;
using System.Collections.Generic;
using System.IO;

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

        public List<string> ReadFile(string Path)
        { 
            List<string> Data = new List<string>();
            string Line;
            using (StreamReader Reader = new StreamReader(Path))
            {
                while ((Line = Reader.ReadLine()) != null)
                { 
                    Data.Add(Line);
                }
            }

            return Data;
        }

        public List<string> ReadFile()
        {
            List<string> Data = new List<string>();
            string Line;
            using (StreamReader Reader = new StreamReader(filePath))
            {
                while ((Line = Reader.ReadLine()) != null)
                {
                    Data.Add(Line);
                }
            }

            return Data;
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

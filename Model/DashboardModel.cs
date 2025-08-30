using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Model
{
    public class DashboardModel
    {
        private List<AccountModel> AccountData = new List<AccountModel>();
        public DashboardModel(List<AccountModel> dataList) { this.AccountData = dataList; }
        public string SearchedText {  get; set; }
        public List<AccountModel> TableData() => AccountData;
    }
}

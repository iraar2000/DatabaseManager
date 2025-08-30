using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using DatabaseManager.Model;
using DatabaseManager.View;

namespace DatabaseManager.Presentation
{
    public class DashboardPresent
    {
        private readonly DashboardModel _dashboardModel;
        private readonly IDashboardView _dashboardView;

        public DashboardPresent(DashboardModel dashboardModel, IDashboardView dashboardView)
        {
            _dashboardModel = dashboardModel;
            _dashboardView = dashboardView;

            _dashboardView.DashboardButtonClicked += OnDashboardBtnClick;
            _dashboardView.AddButtonClicked += OnAddBtnClick;
            _dashboardView.DeleteButtonClicked += OnDeleteBtnClick;
            _dashboardView.EditButtonClicked += OnEditBtnClick;
            _dashboardView.PDFButtonClicked += OnPDFBtnClick;
            _dashboardView.SearchButtonClicked += OnSearchBtnClick;

            //
            // updating the table with the data inside the account as the login button is clicked
            //
            updateTableAccounts(_dashboardModel, _dashboardView);
        }

        public void OnDashboardBtnClick(object sender, EventArgs e) { }
        public void OnAddBtnClick(object sender, EventArgs e) 
        {
            
        }
        public void OnDeleteBtnClick(object sender, EventArgs e) { }
        public void OnEditBtnClick(object sender, EventArgs e) { }
        public void OnPDFBtnClick(object sender, EventArgs e) { }
        public void OnSearchBtnClick(object sender, EventArgs e) { }
        public void updateTableAccounts(DashboardModel dashboardModel, IDashboardView dashboardView)
        {

            AccountModel tableColName = dashboardModel.TableData()[0];
            DataTable table = new DataTable();
            //
            // adding columns Names on the table
            //
            table.Columns.Add(tableColName.UserID, typeof(string));
            table.Columns.Add(tableColName.FirstName, typeof(string));
            table.Columns.Add(tableColName.MiddleName, typeof(string));
            table.Columns.Add(tableColName.LastName, typeof(string));
            table.Columns.Add(tableColName.PhoneNumber, typeof(string));
            table.Columns.Add(tableColName.Profile, typeof(string));
            table.Columns.Add(tableColName.Password, typeof(string));

            //
            // adding rows on the table
            //
            foreach (AccountModel Account in dashboardModel.TableData().GetRange(1, dashboardModel.TableData().Count - 1))
            {
                table.Rows.Add(Account.UserID, Account.FirstName, Account.MiddleName, Account.LastName, Account.PhoneNumber, Account.Profile, Account.Password);
            }

            dashboardView.setDataTable(table);
        }

    }
}

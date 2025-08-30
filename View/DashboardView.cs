using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DatabaseManager.View
{
    public partial class DashboardView : Form, IDashboardView
    {
        public DashboardView()
        {
            InitializeComponent();
            DashboardButton.Click += (s, e) => DashboardButtonClicked?.Invoke(this, EventArgs.Empty);
            addButton.Click += (s, e) => AddButtonClicked?.Invoke(this, EventArgs.Empty);
            DeleteButton.Click += (s, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            EditButton.Click += (s, e) => EditButtonClicked?.Invoke(this, EventArgs.Empty);
            PDFButton.Click += (s, e) => PDFButtonClicked?.Invoke(this, EventArgs.Empty);
            SearchButton.Click += (s, e) => SearchButtonClicked?.Invoke(this, EventArgs.Empty);

        }
        //
        // Menu button accessors
        //
        public event EventHandler DashboardButtonClicked;

        //
        // Data Control Main action buttons     
        //
        public event EventHandler AddButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public event EventHandler EditButtonClicked;
        public event EventHandler PDFButtonClicked;
        public event EventHandler SearchButtonClicked;
        public string SearchData => SearchTextBox.Text;
        public void setVisibility(string Visibility)
        {
            switch (Visibility)
            {
                case "Show": Visible = true; break;
                case "Hide": Visible = false; break;
                case "Close": this.Close(); break;
            }
        }

        private void DashboardView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void setDataTable(DataTable table)
        {
            appDataTable.DataSource = table;
        }

        private void appDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

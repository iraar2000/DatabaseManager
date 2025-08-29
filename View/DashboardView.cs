using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManager.View
{
    public partial class DashboardView : Form, IDashboard
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
    }
}

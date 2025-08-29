using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.View
{
    public interface IDashboard
    {
        //
        // Menu button accessors
        //
        event EventHandler DashboardButtonClicked;

        //
        // Data Control Main action buttons     
        //
        event EventHandler AddButtonClicked; 
        event EventHandler DeleteButtonClicked;
        event EventHandler EditButtonClicked;
        event EventHandler PDFButtonClicked;
        event EventHandler SearchButtonClicked;
        string SearchData { get; }

    }
}

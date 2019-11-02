using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IIQ_Dashboard
{
    /// <summary>
    /// Interaction logic for Tasks.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        public Tasks()
        {
            InitializeComponent();
            getTasks();
            getflTasks();
            getWarnings();


        }
        private void getTasks()
        {
            DAL temp = new DAL();
            DataSet dstsk = temp.GetTasks();
            DataTable dttsk = new DataTable();
            
            foreach (DataTable table in dstsk.Tables)
            {
                tskgrid.ItemsSource = table.DefaultView;

            }
        }
        private void getflTasks()
        {
            DAL temp = new DAL();
            DataSet dsfltsk = temp.GetFailedTasks();
            DataTable dtfltsk = new DataTable();

            foreach (DataTable table in dsfltsk.Tables)
            {
                fltskgrid.ItemsSource = table.DefaultView;

            }
        }
        private void getWarnings()
        {
            DAL temp = new DAL();
            DataSet dswar = temp.GetWarnings();
            DataTable dtwar = new DataTable();

            foreach (DataTable table in dswar.Tables)
            {
                wargrid.ItemsSource = table.DefaultView;

            }
        }

    }
}

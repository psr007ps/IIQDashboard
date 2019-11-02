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
    /// Interaction logic for Test_All_Applications__Dev_A_.xaml
    /// </summary>
    public partial class Test_All_Applications__Dev_A_ : Window
    {
        public Test_All_Applications__Dev_A_()
        {
            InitializeComponent();
            refreshdata();
        }
        private void refreshdata()
        {
            DAL temp = new DAL();
            DataSet dstd = temp.DevA();
            DataTable dt1 = new DataTable();


            dt1.Columns.Add("Applications");
            dt1.Columns.Add("Status");

            foreach (DataTable dt in dstd.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string description = dr[0].ToString();
                    string completed = dr[1].ToString();
                    txtcompleted.Text = "Last Refreshed: " + completed;
                    string[] Status = description.Split(new string[] { "Failures:" }, StringSplitOptions.None);
                    string Successes1 = Status[0];
                    string Failures1 = Status[1];

                    string[] Successes = Successes1.Split(new string[] { "&#xA;" }, StringSplitOptions.None);
                    string[] Failures = Failures1.Split(new string[] { "&#xA;" }, StringSplitOptions.None);

                    foreach (string s in Successes)
                    {

                        DataRow workrow = dt1.NewRow();
                        workrow["Applications"] = s;

                        if (s != "")
                        {
                            workrow["Status"] = "Success";

                        }
                        dt1.Rows.Add(workrow);

                    }
                    for (int s = 1; s < Failures.Length; s++)
                    //foreach (string s in Failures)
                    {

                        DataRow workrow = dt1.NewRow();
                        workrow["Applications"] = Failures[s];
                        if (Failures[s] != "")
                        {

                            workrow["Status"] = "Fail";

                        }
                        dt1.Rows.Add(workrow);

                    }

                }


            }

            dt1 = dt1.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is DBNull || string.IsNullOrWhiteSpace(field as string))).CopyToDataTable();
            dt1.Rows[0].Delete();
            dt1.Rows[1].Delete();
            dt1.Rows[dt1.Rows.Count - 1].Delete();
            
            Desgrid.ItemsSource = dt1.DefaultView;

        }
    }
}

﻿using System;
using System.Collections.Generic;
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
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace IIQ_Dashboard
{
    /// <summary>
    /// Interaction logic for Test_All_Applications_UAT_.xaml
    /// </summary>
    public partial class Test_All_Applications_UAT_ : Window
    {

        public Test_All_Applications_UAT_()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject())) return;
            InitializeComponent();
            refreshdata();


        }

        private void refreshdata()
        {
            
                DAL temp = new DAL();
                DataSet ds = temp.Test();
                DataTable dt1 = new DataTable();


                dt1.Columns.Add("Applications");
                dt1.Columns.Add("Status");

                foreach (DataTable dt in ds.Tables)
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
                //dt2.Columns.Add("Successes");
                //dt2.Columns.Add("Failures");
                //foreach (DataRow x in dt1.Rows)
                //{

                //    string y = x[0].ToString();
                //    DataRow row1 = dt2.NewRow();
                //    while (!y.Equals("Failures"))
                //    {

                //        row1["Successes"] = y;
                //    }


                //    dt2.Rows.Add(row1);
                //}
                Desgrid.ItemsSource = dt1.DefaultView;

            
            
        }
        

    
    }
}

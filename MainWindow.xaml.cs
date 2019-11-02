using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace IIQ_Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tasks obj = new Tasks();
                obj.Show();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Test_All_Applications_UAT_ obj = new Test_All_Applications_UAT_();
                obj.Show();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show(" Refresh in progress. Please try after some time ");
                
            }
        }
        //private void Window_Minimize(object sender, RoutedEventArgs e)
        //{
        //    this.WindowState = WindowState.Minimized;
        //}
        //private void Window_Maximize(object sender, RoutedEventArgs e)
        //{
        //    if (this.WindowState == WindowState.Normal)
        //    {
        //        this.WindowState = WindowState.Maximized;
        //    }
        //    else
        //    {
        //        this.WindowState = WindowState.Normal;
        //    }
        //}
        //private void Window_Close(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //    App.Current.Shutdown();
        //}

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //var driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://<Server Name>:8080/identityiq/home.jsf");
            System.Diagnostics.Process.Start("http://<Server Name>:8080/identityiq/home.jsf"); 		//intentionally removed
           

            //var driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://<Server Name>:8080/identityiq/home.jsf");
            //var login = driver.FindElementById("loginForm:accountId");
            //login.SendKeys("id");
            //var password = driver.FindElementById("loginForm:password");
            //password.SendKeys("password");
            //var searchButton = driver.FindElementByName("loginForm:loginButton");
            //searchButton.Click();
            //driver.Manage().Timeouts().PageLoad=
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //var identi = driver.FindElementByCssSelector("#menuMainDiv > nav > div > ul.nav.navbar-nav.navbar-left > li:nth-child(4) > a");
            //identi.Click();

            //var identity = driver.FindElementByXPath("//*[@id='menuMainDiv']/nav/div/ul[1]/li[4]/ul/li[1]/a");
            //identity.Click();
            //var emp = driver.FindElementById("searchfield-1033-inputEl");
            //emp.SendKeys("id");
            //emp.SendKeys(Keys.Return);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(@"C:\final\IIQ Dashboard\IIQ Dashboard\Report\IIQ_CONNECTORS_OVERVIEW_V2.0.xlsx");
            }
            catch
            { MessageBox.Show("                            Excel not found                              "); }
            }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                Test_All_Applications__Dev_A_ obj = new Test_All_Applications__Dev_A_();
                obj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Refresh in progress. Please try after some time ");
            }
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://<UAT-A Server>:8080/identityiq/home.jsf"); }			//intentionally removed
            catch { MessageBox.Show("Some Error Occured"); }
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://<UAT-B Server>:8080/identityiq/home.jsf"); }			//intentionally removed
            catch { MessageBox.Show("Some Error Occured"); }
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://<Dev-A Server>:8080/identityiq/home.jsf"); }				//intentionally removed
            catch { MessageBox.Show("Some Error Occured"); }
        }
        private void Button4_OnClick(object sender, RoutedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("http://<Dev-B Server>:8080/identityiq/home.jsf"); }				//intentionally removed
            catch { MessageBox.Show("Some Error Occured"); }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                Test_All_Applications__Dev_B_ obj = new Test_All_Applications__Dev_B_();
                obj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Refresh in progress. Please try after some time ");

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                Test_All_Applications__UAT_B_ obj = new Test_All_Applications__UAT_B_();
                obj.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(" Refresh in progress. Please try after some time ");
            }
        }
    }

    
}

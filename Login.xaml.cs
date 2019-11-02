using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bool IsAuthenticated(string ldap, string usr, string pwd)
        {
            bool authenticated = false;

            try
            {
                DirectoryEntry entry = new DirectoryEntry(ldap, usr, pwd);
                using (var context = new PrincipalContext(ContextType.Domain, "<Domain>", "<Generic Username>", "<Password>")) 	//intentionally removed
                {
                    //Username and password for authentication.
                    if (context.ValidateCredentials(usr, pwd))
                    { authenticated = true; }
                }
            }
            catch (DirectoryServicesCOMException cex)
            {
                Console.WriteLine(cex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return authenticated;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (IsAuthenticated("LDAP://<Active Directory Server Name>/CN=<Generic Username>,​OU=Generic,​OU=UsersMisc,​DC=nu,​DC=com", UsernameEmail.Text, passwordBox1.Password)) 		//intentionally removed
            {
                MainWindow obj = new MainWindow();
                obj.Show();
                this.Close();
            }
            else if (IsAuthenticated("LDAP://<Active Directory Server Name>/CN=<Generic Username>,​OU=Generic,​OU=UsersMisc,​DC=nu,​DC=com", UsernameEmail.Text, passwordBox1.Password))  	//intentionally removed
            {
                MainWindow obj = new MainWindow();
                obj.Show();
                this.Close();
            }

            else
            {
                errormessage.Text = "Incorrect Username or Password";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System.Diagnostics;

namespace Redmine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Login");
                var host = "http://testred.ru";
                var login = "user1";
                var password = "12345678";
                var a = new RedmineManager(host, login, password);
                User currentUser = a.GetCurrentUser();
                //Debug.WriteLine("Current user: {0}.", currentUser.FirstName);
                Menu m = new Menu(login, password);
                m.Show();
                this.Hide();
            }
            catch 
            { 
                MessageBox.Show("Неправильный логин или пароль."); 
            }
        }
    }
}

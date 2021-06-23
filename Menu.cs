using Redmine.Net.Api;
using Redmine.Net.Api.Async;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Redmine
{
    public partial class Menu : Form
    {
        public static string host = "http://testred.ru";
        public static string login = "";
        public static string password = "";
        public Menu(string login, string password)
        {
            InitializeComponent();
            Redmine.Menu.login = login;
            Redmine.Menu.password = password;
            var manager = new RedmineManager(host, login, password);

            var parameters = new NameValueCollection {  };
            parameters.Add(RedmineKeys.STATUS_ID, "open");
            parameters.Add(RedmineKeys.ASSIGNED_TO_ID, "me");
            foreach (var issue in manager.GetObjects<Issue>(parameters))
            {
                int i = 0;
                Debug.WriteLine(issue.Id);
                dataGridView1.Rows[i].Cells[0].Value = issue.Id;
                dataGridView1.Rows[i].Cells[1].Value = issue.Subject;
                dataGridView1.Rows[i].Cells[2].Value = issue.AssignedTo.Name;
                i++;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

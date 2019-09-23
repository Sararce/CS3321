using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentLogin
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (users.Contains(usersbox.Text) && pass.Contains(passbox.Text) && Array.IndexOf(users.ToArray(), usersbox.Text)
                == Array.IndexOf(pass.ToArray(), passbox.Text))
            {
                Student stu = new Student();
                stu.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect username/password");
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader("ID.txt");
            string line = "";
            while ((line = str.ReadLine()) != null)
            {
                string[] components = line.Split("".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
              
                
            }
            str.Close();
        }

        
    }
}

using Session_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_01
{
    public partial class Login : Form
    {
        private Model1 db = new Model1();
        public Login()
        {
            InitializeComponent();
            pass.PasswordChar = '•';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            if (register.close == 1) Show();
            else Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string em = this.em.Text;
            string un = this.un.Text;
            string pass = this.pass.Text;
            if (string.IsNullOrWhiteSpace(em) && string.IsNullOrWhiteSpace(un))
            {
                MessageBox.Show("Please enter username");
                return;
            }
            var users = db.Users.ToList();
            foreach (User u in users)
            {
                if((u.Username == em && u.Password == pass && u.UserTypeID == 1)
                    || (u.Username == un && u.Password == pass && u.UserTypeID == 2))
                {
                    MessageBox.Show("Login successful");
                    Hide();
                    Management m = new Management(u);
                    m.ShowDialog();
                    if (m.close == 1) Show();
                    else Close();
                    return;
                }
            }
            MessageBox.Show("Username or Password is wrong");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) pass.PasswordChar = (char)0;
            else pass.PasswordChar = '•';
        }
    }
}

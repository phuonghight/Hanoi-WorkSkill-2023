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
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) this.txtpassword.PasswordChar = (char)0;
            else this.txtpassword.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strEmpl = this.txtempl.Text;
            String strUsername = this.txtusername.Text;
            String strPass = this.txtpassword.Text;
            Session1Entities db = new Session1Entities();
            User user = (from u in db.Users 
                        where (u.Username == strEmpl || u.Username == strUsername) 
                        && u.Password == strPass 
                        select u).SingleOrDefault<User>();
            if (user != null)
            {
                MessageBox.Show("Login successfull", "Success");
                Hide();
                Management m = new Management(user);
                m.ShowDialog();
                if (m.close == 1) Show();
                else Close();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong", "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Register r = new Register();
            r.ShowDialog();
            if (r.status == 1)
                Show();
            else Close();
        }
    }
}

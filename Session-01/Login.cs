using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Solution_01
{
    public partial class Login : Form
    {
        private static Entities db = new Entities();
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '•';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckbox.Checked) password.PasswordChar = (char)0;
            else password.PasswordChar = '•';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            if(register.close == 1) Show();
            else Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> users = db.Users.ToList();
            foreach (User user in users)
            {
                if ((employee.Text==user.Username&&password.Text==user.Password
                    &&user.UserTypeID==1)||(username.Text == user.Username 
                    && password.Text == user.Password&& user.UserTypeID == 2))
                {
                    MessageBox.Show("Login successfull");
                    Hide();
                    Management management = new Management(user);
                    management.ShowDialog();
                    if (management.close == 1) Show();
                    else Close();
                    return;
                }
            }
            MessageBox.Show("Username or password is wrong");
        }
    }
}

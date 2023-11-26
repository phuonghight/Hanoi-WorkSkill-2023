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
    public partial class Register : Form
    {
        public int close;
        private Model1 db = new Model1();

        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close = 1;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Term().ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(un.Text))
            {
                MessageBox.Show("Please enter username");
                return;
            } 
            else if (string.IsNullOrWhiteSpace(fn.Text))
            {
                MessageBox.Show("Please enter full name");
                return;
            } 
            else if (string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }
            else if (pass.Text != repass.Text)
            {
                MessageBox.Show("RePassword is wrong");
                return;
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("View and agree to the Term");
                return;
            }
            var users = db.Users.ToList();
            foreach (User u in users)
            {
                if (u.Username == un.Text)
                {
                    MessageBox.Show("Username is already");
                    return;
                }
            }
            User user = new User()
            {
                ID = users.OrderByDescending(u => u.ID).First().ID + 1,
                GUID = Guid.NewGuid(),
                UserTypeID = 2,
                Username = un.Text,
                FullName = fn.Text,
                Password = pass.Text,
                Gender = female.Checked,
                FamilyCount = (int)familyCount.Value,
                BirthDate = birthday.Value
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Register successful");
            Management m = new Management(user);
            m.ShowDialog();
            if (m.close == 1) Show();
            else Close();
        }
    }
}

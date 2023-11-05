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
        public int status {  get; set; }
        public Register()
        {
            InitializeComponent();
            this.status = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.status = 1;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Term().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Please enter your username", "Error");
                return;
            }
            else if (fullName.Text == "")
            {
                MessageBox.Show("Please enter your full name", "Error");
                return;
            }
            else if (birthday.Value > DateTime.Now)
            {
                MessageBox.Show("Please select Date older", "Error");
                return;
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Please enter your password", "Error");
                return;
            }
            else if (password.Text != rePassword.Text)
            {
                MessageBox.Show("The repassword is wrong", "Error");
                return;
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("Read and Agree to the Term and Conditions", "Error");
                return;
            }

            Session1Entities db = new Session1Entities();
            long id = db.Users.OrderByDescending(u => u.ID).FirstOrDefault().ID;

            User user = new User()
            {
                ID = id + 1,
                Username = username.Text,
                FullName = fullName.Text,
                Password = password.Text,
                FamilyCount = (int)familyCount.Value,
                UserTypeID = 2,
                BirthDate = birthday.Value,
                Gender = femaleRadio.Checked,
                GUID = Guid.NewGuid(),
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Register Successfull", "Success");
            Close();
            new Management(user);
        }
    }
}

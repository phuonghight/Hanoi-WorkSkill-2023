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
    public partial class Register : Form
    {
        public int close;
        private Entities db = new Entities();
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Term().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close = 1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Please enter username");
                return;
            }
            else if (fullName.Text == "")
            {
                MessageBox.Show("Please enter full name");
                return;
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Please enter password");
                return;
            }
            else if (password.Text != repassword.Text)
            {
                MessageBox.Show("repassword is wrong");
                return;
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("Please agree to the Term and Condition");
                return;
            }

            User user = new User()
            {
                ID = db.Users.OrderByDescending(x => x.ID).FirstOrDefault().ID+1,
                GUID = Guid.NewGuid(),
                Username = username.Text,
                FullName = fullName.Text,
                Password = password.Text,
                FamilyCount = (int)familyCount.Value,
                Gender = femaleRadio.Checked,
                BirthDate = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                UserTypeID = db.UserTypes.Where(x=>x.ID==2).FirstOrDefault().ID
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Register successfull");
            Hide();
            Management management = new Management(user);
            management.ShowDialog();
            Close();
        }
    }
}

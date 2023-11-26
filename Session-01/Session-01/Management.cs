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
    public partial class Management : Form
    {
        public int close;
        private Model1 db = new Model1();
        private User user;
        public Management()
        {
            InitializeComponent();
        }
        public Management(User user)
        {
            InitializeComponent();
            this.user = user;
            loadTraveler();
            if (user.UserTypeID == 1) loadOwner();
            else addBtn.Hide();
        }
        private void loadTraveler()
        {
            dataGridView1.Rows.Clear();
            var Item = db.Items.ToList();
            foreach (Item item in Item)
            {
                dataGridView1.Rows.Add(item.Title, item.Capacity,
                    item.Area.Name, item.ItemType.Name);
            }
        }
        private void loadOwner()
        {
            dataGridView2.Rows.Clear();
            var Item = db.Items.Where(x => x.UserID == user.ID).ToList();
            foreach (Item item in Item)
            {
                dataGridView2.Rows.Add(item.Title, item.Capacity,
                    item.Area.Name, item.ItemType.Name, "Edit detail");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close = 1;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            AddEditListing add = new AddEditListing(user);
            add.ShowDialog();
            if (add.close == 1)
            {
                Show();
                loadTraveler();
                loadOwner();
            }
            else Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridView2.SelectedCells[0].ColumnIndex;
            if (col == 4)
            {
                int row = dataGridView2.SelectedCells[0].RowIndex;
                Hide();
                AddEditListing add = new AddEditListing(db.Items
                    .Where(x => x.UserID == user.ID).ToArray()[row]);
                add.ShowDialog();
                if (add.close == 1)
                {
                    Show();
                    loadTraveler();
                    loadOwner();
                }
                else Close();
            }
        }
    }
}

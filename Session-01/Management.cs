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
    public partial class Management : Form
    {
        public int close;
        private User user;
        private Entities db = new Entities();
        public Management()
        {
            InitializeComponent();
        }
        public Management(User user)
        {
            InitializeComponent();
            this.user = user;
            loadTraveler();
            loadOwner();
        }
        private void loadTraveler()
        {
            List<Item> items = db.Items.ToList();
            foreach (var item in items)
            {
                dataGridView1.Rows.Add(item.Title, item.Area.Name,
                    item.Capacity, item.ItemType.Name);
            }
        }
        private void loadOwner()
        {
            dataGridView2.Rows.Clear();
            List<Item> items = db.Items.Where(x => x.UserID==user.ID).ToList();
            foreach (var item in items)
            {
                dataGridView2.Rows.Add(item.Title, item.Area.Name,
                    item.Capacity, item.ItemType.Name, "Edit Details");
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
                List<Item> items = db.Items.Where(x => x.UserID == user.ID).ToList();
                Hide();
                AddEditListing edit = new AddEditListing(items[row]);
                edit.ShowDialog();
                if (edit.close == 1)
                {
                    Show();
                    loadOwner();
                }
                else Close();
            }
        }
    }
}

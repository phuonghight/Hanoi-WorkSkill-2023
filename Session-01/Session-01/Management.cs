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
        private User user;
        public int close = 0;

        private static Session1Entities db = new Session1Entities();
        private static List<Item> Items = db.Items.ToList();
        public Management()
        {
            InitializeComponent();
        }
        public Management(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            loadDtgvTraveler();
            if (user.UserTypeID == 1)
            {
                loadDtgvOwner();
            }
        }

        private void loadDtgvTraveler()
        {
           foreach (Item item in Items)
            {
                dtgvTraveler.Rows.Add(item.Title, item.Area.Name, item.Capacity, item.ItemType.Name);
            }
        }

        private void loadDtgvOwner()
        {
            List<Item> items = Items.Where(i => i.UserID == this.user.ID).ToList();
            foreach (Item item in items )
            {
                dtgvOwner.Rows.Add(item.Title, item.Area.Name,
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
            AddEditListing add = new AddEditListing(this.user);
            add.ShowDialog();
            if (add.close == 1) Show();
            else Close();
        }

        private void dtgvOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgvOwner.SelectedCells[0].RowIndex;
            List<Item> items = Items.Where(i => i.UserID == this.user.ID).ToList();
            Hide();
            AddEditListing add = new AddEditListing(items[row]);
            add.ShowDialog();
            if (add.close == 1) Show();
            else Close();
        }
    }
}

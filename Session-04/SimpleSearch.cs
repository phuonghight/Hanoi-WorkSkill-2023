using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Solution_04
{
    public partial class SimpleSearch : Form
    {
        public SimpleSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AdvancedSearch advanced = new AdvancedSearch();
            advanced.ShowDialog();
            if (advanced.close == 1) Show();
            else Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string keyword = title.Text;
            int capacity = (int)capcity.Value;
            int nights = (int)this.nights.Value;
            Entities db = new Entities();
            HashSet<Item> result = (from item in db.Items
                                 join iam in db.ItemAmenities on item.ID equals iam.ItemID
                                 join iatt in db.ItemAttractions on item.ID equals iatt.ItemID
                                 where item.Capacity >= capacity
                                 && item.MaximumNights - item.MinimumNights >= nights
                                 && (item.Title.Contains(keyword) 
                                 || item.Area.Name.Contains(keyword)
                                 || item.ItemType.Name.Contains(keyword)
                                 || iam.Amenity.Name.Contains(keyword)
                                 || iatt.Attraction.Name.Contains(keyword)
                                 )
                                 select item)
                                 .ToHashSet();
            if (result.Count > 0 )
            {
                foreach ( Item item in result )
                {
                    double avg = 0;
                    List<ItemScore> itemScores = db.ItemScores
                        .Where(x => x.ItemID == item.ID)
                        .ToList();
                    HashSet<Booking> bookings = (from booking in db.Bookings
                                              join bd in db.BookingDetails on booking.ID equals bd.BookingID
                                              join ip in db.ItemPrices on bd.ItemPriceID equals ip.ID
                                              where ip.ItemID == item.ID
                                              select booking).ToHashSet();
                    if (itemScores.Count > 0)
                    {
                        avg = itemScores.Average(x => x.Value);
                    }
                    dataGridView1.Rows.Add(item.Title, item.Area.Name,
                        avg, bookings.Count, bookings.Sum(x => x.AmountPaid));
                }
            }
            else
            {
                MessageBox.Show("Not found");
                return;
            }
        }
    }
}

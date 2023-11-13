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
    public partial class AdvancedSearch : Form
    {
        public int close;
        private Entities db = new Entities();
        public AdvancedSearch()
        {
            InitializeComponent();
            if (fromDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The starting date must not be before the current date");
                return;
            }
            else if (fromDate.Value.Date > toDate.Value.Date)
            {
                MessageBox.Show("The ending date cannot be before the starting date");
                return;
            }
            area.Items.AddRange(db.Areas.Select(x=>x.Name).ToArray());
            area.AutoCompleteCustomSource.AddRange(db.Areas.Select(x => x.Name).ToArray());

            attraction.Items.AddRange(db.Attractions.Select(x => x.Name).ToArray());

            title.Items.AddRange(db.Items.Select(x => x.Title).ToArray());
            title.AutoCompleteCustomSource.AddRange(db.Items.Select(x => x.Title).ToArray());

            type.Items.AddRange(db.ItemTypes.Select(x => x.Name).ToArray());

            amenity1.Items.AddRange(db.Amenities.Select(x => x.Name).ToArray());
            amenity2.Items.AddRange(db.Amenities.Select(x => x.Name).ToArray());
            amenity3.Items.AddRange(db.Amenities.Select(x => x.Name).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close = 1;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int capacity = (int)this.capacity.Value;
            int nights = (int)this.nights.Value;
            Entities db = new Entities();
            HashSet<Item> result = (from item in db.Items
                                    join iam in db.ItemAmenities on item.ID equals iam.ItemID
                                    join iatt in db.ItemAttractions on item.ID equals iatt.ItemID
                                    where item.Capacity >= capacity
                                    && item.MaximumNights - item.MinimumNights >= nights
                                    && (item.Title == (string)title.SelectedValue
                                    && item.Area.Name == (string)area.SelectedValue
                                    && item.ItemType.Name == (string)type.SelectedValue
                                    && iatt.Attraction.Name == (string)attraction.SelectedValue
                                    && item.ItemAmenities.Select(x => x.Amenity.Name).ToList()
                                    .Contains((string)amenity1.SelectedValue))
                                    select item)
                                 .ToHashSet();
            if (result.Count > 0)
            {
                foreach (Item item in result)
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

        private void amenity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((string)amenity1.SelectedValue);
        }
    }
}

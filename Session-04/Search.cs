using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class Search : Form
    {
        private Entities db = new Entities();
        public Search()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            String keyword = this.textBox1.Text;
            String from = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int duration = (int)this.duration.Value;
            int capacity = (int)this.capacity.Value;

            var result = (from item in db.Items
                          from iam in db.ItemAmenities
                          from iat in db.ItemAttractions
                          where item.Capacity > capacity &&  
                          item.MaximumNights - item.MinimumNights > duration &&
                          (item.ItemType.Name.Contains(keyword) ||
                          iam.Amenity.Name.Contains(keyword) ||
                          iat.Attraction.Name.Contains(keyword)) ||
                          item.Area.Name.Contains(keyword) ||
                          item.Title.Contains(keyword)
                          select item)
                          .ToHashSet();

            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    var itemScores = db.ItemScores.Where(i => i.ItemID == item.ID).ToList();
                    long sum = itemScores.Select(i => i.Value).Sum();
                    float average = itemScores.Count() > 0 ? sum / itemScores.Count() : 0;
                    var bookings = (from b in db.Bookings
                                    join bd in db.BookingDetails on b.ID equals bd.BookingID
                                    join ip in db.ItemPrices on bd.ItemPriceID equals ip.ID
                                    where ip.ItemID == item.ID
                                    select b).ToHashSet();
                    dataGridView1.Rows.Add(item.Title, item.Area.Name, average,
                        bookings.Count, bookings.Sum(b => b.AmountPaid));
                }
            }
            else MessageBox.Show("Not found", "Not found");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SearchAdvanced searchAdvanced = new SearchAdvanced();
            searchAdvanced.ShowDialog();
            if (searchAdvanced.status == 1) Show();
            else Close();
        }
    }
}

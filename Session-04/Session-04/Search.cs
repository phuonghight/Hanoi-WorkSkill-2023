using Session_04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_04
{
    public partial class Search : Form
    {
        private Model1 db = new Model1();

        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AdvancedSearch search = new AdvancedSearch();
            search.ShowDialog();
            if(search.close == 1) Show();
            else Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string q = keyword.Text;
            var result = (from item in db.Items
                          join ip in db.ItemPrices on item.ID equals ip.ItemID
                          join iam in db.ItemAmenities on item.ID equals iam.ItemID
                          join iatt in db.ItemAttractions on item.ID equals iatt.ItemID
                          where item.Capacity >= (int)capacity.Value &&
                          ip.Date >= date.Value &&
                          (
                            item.Title.Contains(q) || item.Area.Name.Contains(q) ||
                            item.ItemType.Name.Contains(q) || iam.Amenity.Name.Contains(q)
                            || iatt.Attraction.Name.Contains(q)
                          )
                          select item).ToHashSet();
            if(result.Count == 0 )
            {
                MessageBox.Show("Not Found!");
                return;
            }
            foreach( Item item in result )
            {
                double avg = item.ItemScores.Average( x => x.Value );
                var bookings = (from b in db.Bookings
                                join bd in db.BookingDetails on b.ID equals bd.BookingID
                                where bd.ItemPrice.ItemID == item.ID && !bd.isRefund
                                select b).ToHashSet();
                decimal price = item.ItemPrices
                    .Where(x => x.Date >= date.Value &&
                    x.Date <= date.Value.AddDays((int)nighst.Value))
                    .Sum( x => x.Price );
                dataGridView1.Rows.Add( item.Title, item.Area.Name,
                    avg, bookings.Count, price);
            }
        }
    }
}

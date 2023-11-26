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
    public partial class AdvancedSearch : Form
    {
        public int close;
        private Model1 db = new Model1();

        public AdvancedSearch()
        {
            InitializeComponent();
            area.Items.AddRange(db.Areas.Select(x => x.Name).ToArray());
            attraction.Items.AddRange(db.Attractions.Select(x => x.Name).ToArray());
            title.Items.AddRange(db.Items.Select(x => x.Title).ToArray());
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
            var result = (from ip in db.ItemPrices
                          where ip.Item.Capacity >= (int)capacity.Value &&
                          ip.Date >= startDate.Value && ip.Date <= endDate.Value
                          select ip).ToHashSet();
            if (result.Count == 0)
            {
                MessageBox.Show("Not Found!");
                return;
            }
            
            if (area.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.Area.Name != area.SelectedItem.ToString()
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (title.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.Title != title.SelectedItem.ToString()
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (attraction.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.ItemAttractions
                        .All(ia => ia.Attraction.Name != attraction.SelectedItem.ToString())
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (type.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.ItemType.Name != type.SelectedItem.ToString()
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (amenity1.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.ItemAmenities
                        .All(ia => ia.Amenity.Name != amenity1.SelectedItem.ToString())
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (amenity2.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.ItemAmenities
                        .All(ia => ia.Amenity.Name != amenity2.SelectedItem.ToString())
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (amenity3.SelectedIndex >= 0)
            {
                result.RemoveWhere(
                        x => x.Item.ItemAmenities
                        .All(ia => ia.Amenity.Name != amenity3.SelectedItem.ToString())
                    );
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (startPrice.Value > 0)
            {
                result.RemoveWhere(x => x.Price < startPrice.Value);
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }
            if (maxPrice.Value > 0)
            {
                result.RemoveWhere(x => x.Price > maxPrice.Value);
                if (result.Count == 0)
                {
                    MessageBox.Show("Not Found!");
                    return;
                }
            }

            foreach (ItemPrice ip in result)
            {
                double avg = ip.Item.ItemScores.Average(x => x.Value);
                var bookings = (from b in db.Bookings
                                join bd in db.BookingDetails on b.ID equals bd.BookingID
                                where bd.ItemPrice.ItemID == ip.Item.ID && !bd.isRefund
                                select b).ToHashSet();
                dataGridView1.Rows.Add(ip.Item.Title, ip.Item.Area.Name,
                    avg, bookings.Count, ip.Price, ip.Date.ToString("yyyy-MM-dd"));
            }
        }

        private void area_SelectedIndexChanged(object sender, EventArgs e)
        {
            attraction.Items.Clear();
            attraction.Items.AddRange(db.Attractions
                .Where(x => x.Area.Name == area.SelectedItem.ToString())
                .Select(x => x.Name)
                .ToArray());
            title.Items.Clear();
            title.Items.AddRange(db.Attractions
                .Where(x => x.Area.Name == area.SelectedItem.ToString())
                .Select(x => x.Name)
                .ToArray());
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("Ivalid Date");
                return;
            }
            nights.Value = (endDate.Value - startDate.Value).Days;
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("Ivalid Date");
                return;
            }
            nights.Value = (endDate.Value - startDate.Value).Days;
        }

        private void nights_ValueChanged(object sender, EventArgs e)
        {
            endDate.Value = startDate.Value.AddDays((int)nights.Value);
        }
    }
}

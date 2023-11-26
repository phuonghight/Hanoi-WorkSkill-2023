using Session_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_01
{
    public partial class AddEditListing : Form
    {
        public int close;
        private Model1 db = new Model1();
        private User user;
        private Item item = null;
        private int curTab = 0;

        public AddEditListing()
        {
            InitializeComponent();
        }
        public AddEditListing(User user)
        {
            InitializeComponent();
            item = null;
            this.user = user;
        }
        public AddEditListing(Item item)
        {
            InitializeComponent();
            this.item = item;
            user = item.User;
        }

        private void AddEditListing_Load(object sender, EventArgs e)
        {
            type.Items.AddRange(db.ItemTypes.Select(x => x.Name).ToArray());
            loadAmenity();
            loadAttraction();
            if (item != null)
            {
                type.SelectedIndex = db.ItemTypes.ToList()
                    .FindIndex(x => x.ID == item.ItemType.ID);
                title.Text = item.Title;
                approximateAddress.Text = item.ApproximateAddress;
                exactAddress.Text = item.ExactAddress;
                description.Text = item.Description;
                hostRules.Text = item.HostRules;
                capacity.Value = item.Capacity;
                beds.Value = item.NumberOfBeds;
                bedrooms.Value = item.NumberOfBedrooms;
                bathrooms.Value = item.NumberOfBedrooms;
                minimum.Value = item.MinimumNights;
                maximum.Value = item.MaximumNights;
            }
        }
        private void loadAmenity()
        {
            amenity.Rows.Clear();
            if (item == null)
            {
                var amen = db.Amenities.ToList();
                foreach (var am in amen)
                {
                    amenity.Rows.Add(am.Name, false);
                }
            } 
            else
            {
                List<long> ids = db.ItemAmenities
                    .Where(x => x.ItemID == item.ID)
                    .Select(x => x.AmenityID)
                    .ToList();
                var amen = db.Amenities.ToList();
                foreach (var am in amen)
                {
                    amenity.Rows.Add(am.Name, ids.Contains(am.ID));
                }
            }
        }
        private void loadAttraction()
        {
            this.attraction.Rows.Clear();
            var attraction = db.Attractions.ToList();
            foreach(var attr in attraction)
            {
                this.attraction.Rows.Add(attr.Name, attr.Area.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(curTab == 2)
            {
                Item item = new Item()
                {
                    UserID = user.ID,
                    Title = title.Text,
                    ApproximateAddress = approximateAddress.Text,
                    ExactAddress = exactAddress.Text,
                    Description = description.Text,
                    HostRules = hostRules.Text,
                    Capacity = (int)capacity.Value,
                    NumberOfBeds = (int)beds.Value,
                    NumberOfBedrooms = (int)bedrooms.Value,
                    NumberOfBathrooms = (int)bedrooms.Value,
                    MinimumNights = (int)minimum.Value,
                    MaximumNights = (int)maximum.Value,
                    ItemTypeID = db.ItemTypes.ToList()[type.SelectedIndex].ID,
                    AreaID = 1,
                };
                if (this.item == null)
                {
                    item.ID = db.Items.OrderByDescending(x => x.ID).FirstOrDefault().ID + 1;
                    item.GUID = Guid.NewGuid();
                }
                else
                {
                    item.ID = this.item.ID;
                    item.GUID = this.item.GUID;
                }
                List<ItemAmenity> itemAmenities = new List<ItemAmenity>();
                long iamId = db.ItemAmenities.OrderByDescending(x => x.ID).First().ID;
                for (int i = 0; i < this.amenity.Rows.Count; i++)
                {
                    if ((bool)this.amenity.Rows[i].Cells[1].Value)
                    {
                        ItemAmenity iam = new ItemAmenity()
                        {
                            ID = ++iamId,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            AmenityID = db.Amenities.ToArray()[i].ID,
                        };
                        itemAmenities.Add(iam);
                    }
                }
                item.ItemAmenities = itemAmenities;

                List<ItemAttraction> itemAttractions = new List<ItemAttraction>();
                long iattId = db.ItemAttractions.OrderByDescending(x => x.ID).First().ID;
                for (int i = 0; i < this.attraction.Rows.Count; i++)
                {
                    decimal distance;
                    long onFoot, bycar;
                    if (decimal.TryParse((string)this.attraction.Rows[i].Cells[2].Value, out distance)
                        && long.TryParse((string)this.attraction.Rows[i].Cells[3].Value, out onFoot)
                        && long.TryParse((string)this.attraction.Rows[i].Cells[4].Value, out bycar)
                        )
                    {
                        ItemAttraction iatt = new ItemAttraction()
                        {
                            ID = ++iattId,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            AttractionID = db.Attractions.ToArray()[i].ID,
                            Distance = distance,
                            DurationOnFoot = onFoot,
                            DurationByCar = bycar
                        };
                        itemAttractions.Add(iatt);
                    }
                }
                item.ItemAttractions = itemAttractions;

                if (this.item == null)
                {
                    db.Items.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("Add Successful");
                }
                else
                {
                    db.Items.Attach(item);
                    db.SaveChanges();
                    MessageBox.Show("Edit Successful");
                }
            }
            close = 1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curTab++;
            tabControl1.SelectedIndex = curTab;
            tabControl1.TabPages[curTab - 1].Enabled = false;
            if(curTab == 2)
            {
                nextBtn.Hide();
                saveBtn.Text = "Finish";
            }
        }
    }
}

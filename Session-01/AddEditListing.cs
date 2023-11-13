using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Re_Solution_01
{
    public partial class AddEditListing : Form
    {
        public int close;
        private Entities db = new Entities();
        private User user;
        private Item item;
        private int curTab = 0;
        public AddEditListing()
        {
            InitializeComponent();
        }
        public AddEditListing(User user)
        {
            InitializeComponent();
            this.user = user;
            item = null;
        }
        public AddEditListing(Item item)
        {
            InitializeComponent();
            this.item = item;
            user = item.User;
        }
        private void AddEditListing_Load(object sender, EventArgs e)
        {
            typeCbb.DataSource = db.ItemTypes.Select(x => x.Name).ToList();
            if (item == null)
            {

            }
            else
            {
                typeCbb.SelectedIndex = db.ItemTypes.ToList()
                    .FindIndex(x => x.ID == item.ItemTypeID);
                this.Text = "Edit Listing";
                title.Text = item.Title;
                capacity.Value = item.Capacity;
                beds.Value = item.NumberOfBeds;
                bedrooms.Value = item.NumberOfBedrooms;
                bathrooms.Value = item.NumberOfBathrooms;
                approximateAddress.Text = item.ApproximateAddress;
                exactAddress.Text = item.ExactAddress;
                description.Text = item.Description;
                hostRules.Text = item.HostRules;
                maximum.Value = item.MaximumNights;
                minimum.Value = item.MinimumNights;
            }
            loadAmenity();
            loadAttraction();
        }
        private void loadAmenity()
        {
            List<Amenity> amenities = db.Amenities.ToList();
            if (item == null)
            {
                foreach (Amenity am in amenities)
                {
                    dataGridView1.Rows.Add(am.Name, false);
                }
            }
            else
            {
                List<long> ids = db.ItemAmenities.Where(x => x.ItemID == item.ID)
                        .Select(x => x.AmenityID).ToList();
                foreach (Amenity am in amenities)
                {
                    dataGridView1.Rows.Add(am.Name, ids.Contains(am.ID));
                }
            }
        }
        private void loadAttraction()
        {
            List<Attraction> attractions = db.Attractions.ToList();
            if (item == null)
            {
                foreach (Attraction at in attractions)
                {
                    dataGridView2.Rows.Add(at.Name, at.Area.Name);
                }
            }
            else
            {
                foreach (Attraction at in attractions)
                {
                    dataGridView2.Rows.Add(at.Name, at.Area.Name);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (curTab == 2)
            {
                Item item = new Item()
                {
                    ItemTypeID = db.ItemTypes.ToList()[typeCbb.SelectedIndex].ID,
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
                    UserID = user.ID,
                };
                if(this.item==null)
                {
                    item.ID = db.ItemAmenities.OrderByDescending(x => x.ID)
                        .FirstOrDefault().ID + 1;
                    item.GUID = Guid.NewGuid();
                }
                else
                {
                    item.ID = this.item.ID;
                    item.GUID = this.item.GUID;
                }

                List<ItemAmenity> itemAmenities = new List<ItemAmenity>();
                long imId = db.ItemAmenities.OrderByDescending(x => x.ID)
                    .FirstOrDefault().ID + 1;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[1].Value) 
                    {
                        ItemAmenity im = new ItemAmenity()
                        {
                            ID = imId++,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            AmenityID = db.Amenities.ToList()[i].ID,
                        };
                        itemAmenities.Add(im);
                    }
                }
                item.ItemAmenities = itemAmenities;

                List<ItemAttraction> itemAttractions = new List<ItemAttraction>();
                long iatId = db.ItemAttractions.OrderByDescending(x => x.ID)
                    .FirstOrDefault().ID + 1;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    decimal Distance;
                    long DurationOnFoot, DurationByCar;
                    if (decimal.TryParse((string)dataGridView2.Rows[i].Cells[2].Value, out Distance)
                        && long.TryParse((string)dataGridView2.Rows[i].Cells[3].Value, out DurationOnFoot)
                        && long.TryParse((string)dataGridView2.Rows[i].Cells[4].Value, out DurationByCar))
                    {
                        ItemAttraction iat = new ItemAttraction()
                        {
                            ID = iatId++,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            Attraction = db.Attractions.ToList()[i],
                            Distance = Distance,
                            DurationOnFoot = DurationOnFoot,
                            DurationByCar = DurationByCar
                        };
                        itemAttractions.Add(iat);
                    }
                }
                if(itemAttractions.Count > 0)
                {
                    item.ItemAttractions = itemAttractions;
                    ItemAttraction minIat = itemAttractions[0];
                    item.AreaID = minIat.Attraction.AreaID;
                    foreach (ItemAttraction i in itemAttractions)
                    {
                        if (minIat.Distance > i.Distance)
                        {
                            item.AreaID = i.Attraction.AreaID;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a attraction");
                    return;
                }

                if(this.item == null)
                {
                    db.Items.Add(item);
                    db.SaveChanges();
                    MessageBox.Show("Add listing successfull");
                }
                else
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Edit listing successfull");
                }
            }
            close = 1;
            Close();
        }
    }
}

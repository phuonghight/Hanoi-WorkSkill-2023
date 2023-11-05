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
    public partial class AddEditListing : Form
    {
        public int close = 0;
        private User user;
        private Item item = null;
        private int curTab = 0;


        private static Session1Entities db = new Session1Entities();
        private static List<ItemType> ItemTypes = db.ItemTypes.ToList();
        private static List<Amenity> Amenities = db.Amenities.ToList();
        private static List<Attraction> Attractions = db.Attractions.ToList();

        public AddEditListing()
        {
            InitializeComponent();
        }
        public AddEditListing(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public AddEditListing(Item item)
        {
            InitializeComponent();
            this.item = item;
            this.user = item.User;
        }

        private void AddEditListing_Load(object sender, EventArgs e)
        {
            if (this.item == null) // Add
            {
                this.Text = "Add Listing";
                comboBox1.DataSource = ItemTypes.Select(it => it.Name).ToList();
            }
            else // Edit
            {
                this.Text = "Edit Listing";
                title.Text = item.Title;
                capacity.Value = item.Capacity;
                beds.Value = item.NumberOfBeds;
                bedrooms.Value = item.NumberOfBedrooms;
                bathrooms.Value = item.NumberOfBathrooms;
                approximateAddres.Text = item.ApproximateAddress;
                exactAddress.Text = item.ExactAddress;
                hostRules.Text = item.HostRules;
                max.Value = item.MaximumNights;
                min.Value = item.MinimumNights;
                comboBox1.DataSource = db.ItemTypes.Select(it => it.Name).ToList();
                comboBox1.SelectedIndex = db.ItemTypes.ToList().FindIndex(it => it.ID == item.ItemTypeID);
            }

            loadAmenityTable(db);
            loadAttractionTable(db);
        }

        private void loadAmenityTable(Session1Entities db)
        {
            if (this.item == null)
            {
                foreach (Amenity a in Amenities)
                {
                    dataGridView1.Rows.Add(a.Name, false);
                }
            } 
            else
            {
                List<ItemAmenity> iamens = db.ItemAmenities
                    .Where(iam => iam.ItemID == this.item.ID)
                    .ToList();
                foreach (Amenity a in Amenities)
                {
                    dataGridView1.Rows
                        .Add(a.Name, iamens.Select(ia => ia.AmenityID).Contains(a.ID));
                }
            }
        }

        private void loadAttractionTable(Session1Entities db)
        {
            if (this.item == null)
            {
                foreach (Attraction a in Attractions)
                {
                    dataGridView2.Rows.Add(a.Name, a.Area.Name, "", "", "");
                }
            }
            else
            {
                List<long> ids = db.ItemAttractions
                    .Where(ia => ia.ItemID == this.item.ID)
                    .Select (ia => ia.AttractionID)
                    .ToList();
                List<ItemAttraction> ItemAttraction = db.ItemAttractions
                    .Where(ia => ia.ItemID == this.item.ID)
                    .ToList();
                foreach (Attraction a in Attractions)
                {
                    if (!ids.Contains(a.ID))
                    {
                        dataGridView2.Rows.Add(a.Name, a.Area.Name, "", "", "");
                    }
                    else
                    {
                        ItemAttraction ia = ItemAttraction.Where(x => x.AttractionID == a.ID)
                            .FirstOrDefault();
                        dataGridView2.Rows.Add(a.Name, a.Area.Name, ia.Distance, 
                            ia.DurationOnFoot, ia.DurationByCar);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (curTab >= 2)
            {
                Session1Entities db = new Session1Entities();
                Item item = new Item()
                {
                    Title = title.Text,
                    Capacity = (int) capacity.Value,
                    NumberOfBeds = (int) beds.Value,
                    NumberOfBedrooms = (int)bedrooms.Value,
                    NumberOfBathrooms = (int)bathrooms.Value,
                    MinimumNights = (int)min.Value,
                    MaximumNights = (int)max.Value,
                    ApproximateAddress = approximateAddres.Text,
                    ExactAddress = exactAddress.Text,
                    Description = description.Text,
                    HostRules = hostRules.Text,
                    ItemTypeID = ItemTypes[comboBox1.SelectedIndex].ID,
                    UserID = this.user.ID,
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
                long itemAmenityIds = db.ItemAmenities.OrderByDescending(iam => iam.ID)
                    .FirstOrDefault().ID;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[1].Value)
                    {
                        ItemAmenity iam = new ItemAmenity()
                        {
                            ID = itemAmenityIds + 1,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            AmenityID = Amenities[i].ID,
                        };
                        itemAmenities.Add(iam);
                    }
                }
                item.ItemAmenities = itemAmenities;

                List<ItemAttraction> itemAttractions = new List<ItemAttraction>();
                long itemAttractionIds = db.ItemAttractions.OrderByDescending(iam => iam.ID)
                    .FirstOrDefault().ID;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    object distance = dataGridView2.Rows[i].Cells[2].Value;
                    object onFoot = dataGridView2.Rows[i].Cells[3].Value;
                    object byCar = dataGridView2.Rows[i].Cells[4].Value;

                    decimal distanceValue;
                    long onFootValue;
                    long byCarValue;

                    if (decimal.TryParse(distance.ToString(), out distanceValue) &&
                        long.TryParse(onFoot.ToString(), out onFootValue) &&
                        long.TryParse(byCar.ToString(), out byCarValue))
                    {
                        ItemAttraction att = new ItemAttraction()
                        {
                            ID = itemAttractionIds + 1,
                            GUID = Guid.NewGuid(),
                            ItemID = item.ID,
                            AttractionID = Attractions[i].ID,
                            Distance = distanceValue,
                            DurationOnFoot = onFootValue,
                            DurationByCar = byCarValue
                        };
                        itemAttractions.Add(att);
                        item.AreaID = Attractions[i].AreaID;
                    }
                }
                item.ItemAttractions = itemAttractions;

                if (this.item == null)
                {
                    db.Items.Add(item);
                }
                else
                {
                    db.Items.Attach(item);
                }
                db.SaveChanges();

                MessageBox.Show("Add Listing Successfull", "Success");
            }
            this.close = 1;
            Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.curTab++;
            tabControl1.SelectedIndex = this.curTab;
            tabControl1.TabPages[curTab - 1].Enabled = false;
            if (this.curTab == 2)
            {
                nextBtn.Hide();
                saveBtn.Text = "Finish";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            int col = dataGridView1.SelectedCells[0].ColumnIndex;
        }
    }
}

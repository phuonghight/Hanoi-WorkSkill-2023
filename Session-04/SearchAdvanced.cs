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
    public partial class SearchAdvanced : Form
    {
        public int status { get; set; }
        private static Entities db = new Entities();
        public SearchAdvanced()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = 1;
            Close();
        }

        private void SearchAdvanced_Load(object sender, EventArgs e)
        {
            List<Area> areas = db.Areas.ToList();
            areaCbb.DataSource = areas.Select(a => a.Name).ToList();
            List<Attraction> attractions = db.Attractions.ToList();
            attractionCbb.DataSource = attractions.Select(a => a.Name).ToList();

            titleCbb.Items.AddRange(db.Items.Select(i => i.Title).ToArray());
            titleCbb.AutoCompleteCustomSource.AddRange(db.Items.Select(i => i.Title).ToArray());

            var amenities = db.Amenities.Select(a => a.Name).ToArray();
            amenityCbb1.Items.AddRange(amenities);
            amenityCbb2.Items.AddRange(amenities);
            amenityCbb3.Items.AddRange(amenities);

            typeCbb.Items.AddRange(db.ItemTypes.Select(it => it.Name).ToArray());
        }

        private void amenityCbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var amenities = db.Amenities.Select(a => a.Name).ToList();
            amenities.Remove((string)amenityCbb1.SelectedItem);
            amenityCbb2.Items.Clear();
            amenityCbb2.Items.AddRange(amenities.ToArray());
            amenityCbb3.Items.Clear();
            amenityCbb3.Items.AddRange(amenities.ToArray());
        }

        private void amenityCbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var amenities = db.Amenities.Select(a => a.Name).ToList();
            amenities.Remove((string)amenityCbb2.SelectedItem);
            amenityCbb1.Items.Clear();
            amenityCbb1.Items.AddRange(amenities.ToArray());
            amenityCbb3.Items.Clear();
            amenityCbb3.Items.AddRange(amenities.ToArray());
        }

        private void amenityCbb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var amenities = db.Amenities.Select(a => a.Name).ToList();
            amenities.Remove((string)amenityCbb3.SelectedItem);
            amenityCbb1.Items.Clear();
            amenityCbb1.Items.AddRange(amenities.ToArray());
            amenityCbb2.Items.Clear();
            amenityCbb2.Items.AddRange(amenities.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

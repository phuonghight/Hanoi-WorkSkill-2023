namespace Session_01
{
    partial class AddEditListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bathrooms = new System.Windows.Forms.NumericUpDown();
            this.bedrooms = new System.Windows.Forms.NumericUpDown();
            this.beds = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.hostRules = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.exactAddress = new System.Windows.Forms.TextBox();
            this.approximateAddres = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Amenity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Attraction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnFoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(617, 400);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(698, 400);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Close";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bathrooms);
            this.tabPage1.Controls.Add(this.bedrooms);
            this.tabPage1.Controls.Add(this.beds);
            this.tabPage1.Controls.Add(this.min);
            this.tabPage1.Controls.Add(this.max);
            this.tabPage1.Controls.Add(this.capacity);
            this.tabPage1.Controls.Add(this.hostRules);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.exactAddress);
            this.tabPage1.Controls.Add(this.approximateAddres);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listing Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bathrooms
            // 
            this.bathrooms.Location = new System.Drawing.Point(690, 68);
            this.bathrooms.Name = "bathrooms";
            this.bathrooms.Size = new System.Drawing.Size(53, 22);
            this.bathrooms.TabIndex = 3;
            this.bathrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bedrooms
            // 
            this.bedrooms.Location = new System.Drawing.Point(472, 68);
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.Size = new System.Drawing.Size(53, 22);
            this.bedrooms.TabIndex = 3;
            this.bedrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // beds
            // 
            this.beds.Location = new System.Drawing.Point(256, 66);
            this.beds.Name = "beds";
            this.beds.Size = new System.Drawing.Size(53, 22);
            this.beds.TabIndex = 3;
            this.beds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(405, 308);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(52, 22);
            this.min.TabIndex = 3;
            this.min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(268, 308);
            this.max.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(65, 22);
            this.max.TabIndex = 3;
            this.max.UseWaitCursor = true;
            this.max.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(74, 66);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(53, 22);
            this.capacity.TabIndex = 3;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hostRules
            // 
            this.hostRules.Location = new System.Drawing.Point(164, 264);
            this.hostRules.Name = "hostRules";
            this.hostRules.Size = new System.Drawing.Size(591, 22);
            this.hostRules.TabIndex = 2;
            this.hostRules.Text = "Host rules";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(164, 218);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(591, 22);
            this.description.TabIndex = 2;
            this.description.Text = "Description";
            // 
            // exactAddress
            // 
            this.exactAddress.Location = new System.Drawing.Point(164, 169);
            this.exactAddress.Name = "exactAddress";
            this.exactAddress.Size = new System.Drawing.Size(591, 22);
            this.exactAddress.TabIndex = 2;
            this.exactAddress.Text = "Exact Address";
            // 
            // approximateAddres
            // 
            this.approximateAddres.Location = new System.Drawing.Point(164, 123);
            this.approximateAddres.Name = "approximateAddres";
            this.approximateAddres.Size = new System.Drawing.Size(591, 22);
            this.approximateAddres.TabIndex = 2;
            this.approximateAddres.Text = "Approximate Addres";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(443, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(314, 22);
            this.title.TabIndex = 2;
            this.title.Text = "title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reservation Time (Nights)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Host Rules";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of Bathrooms";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Bedrooms";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exact Addresss";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Approximate Addresss";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Minimum";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Beds";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Maximum";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tilte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amenity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amenity,
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(25, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 304);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Choose Available Amenities";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Distance of Attraction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attraction,
            this.Area,
            this.Distance,
            this.OnFoot,
            this.ByCar});
            this.dataGridView2.Location = new System.Drawing.Point(6, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(749, 317);
            this.dataGridView2.TabIndex = 0;
            // 
            // Amenity
            // 
            this.Amenity.HeaderText = "Amenity";
            this.Amenity.MinimumWidth = 6;
            this.Amenity.Name = "Amenity";
            this.Amenity.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Attraction
            // 
            this.Attraction.HeaderText = "Attraction";
            this.Attraction.MinimumWidth = 6;
            this.Attraction.Name = "Attraction";
            this.Attraction.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance (km)";
            this.Distance.MinimumWidth = 6;
            this.Distance.Name = "Distance";
            // 
            // OnFoot
            // 
            this.OnFoot.HeaderText = "On Foot (minutes)";
            this.OnFoot.MinimumWidth = 6;
            this.OnFoot.Name = "OnFoot";
            // 
            // ByCar
            // 
            this.ByCar.HeaderText = "By Car (minutes)";
            this.ByCar.MinimumWidth = 6;
            this.ByCar.Name = "ByCar";
            // 
            // AddEditListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddEditListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditListing";
            this.Load += new System.EventHandler(this.AddEditListing_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bathrooms;
        private System.Windows.Forms.NumericUpDown bedrooms;
        private System.Windows.Forms.NumericUpDown beds;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.TextBox hostRules;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox exactAddress;
        private System.Windows.Forms.TextBox approximateAddres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amenity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnFoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByCar;
    }
}
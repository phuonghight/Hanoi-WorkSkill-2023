namespace Re_Solution_01
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.beds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bedrooms = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.bathrooms = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.approximateAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exactAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hostRules = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maximum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.minimum = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Amenity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Attraction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnFoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bathrooms);
            this.tabPage1.Controls.Add(this.bedrooms);
            this.tabPage1.Controls.Add(this.beds);
            this.tabPage1.Controls.Add(this.minimum);
            this.tabPage1.Controls.Add(this.maximum);
            this.tabPage1.Controls.Add(this.capacity);
            this.tabPage1.Controls.Add(this.hostRules);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.exactAddress);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.approximateAddress);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.typeCbb);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listing Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amenity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // typeCbb
            // 
            this.typeCbb.FormattingEnabled = true;
            this.typeCbb.Location = new System.Drawing.Point(73, 11);
            this.typeCbb.Name = "typeCbb";
            this.typeCbb.Size = new System.Drawing.Size(258, 24);
            this.typeCbb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(432, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(230, 22);
            this.title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(86, 55);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(65, 22);
            this.capacity.TabIndex = 4;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Beds";
            // 
            // beds
            // 
            this.beds.Location = new System.Drawing.Point(232, 55);
            this.beds.Name = "beds";
            this.beds.Size = new System.Drawing.Size(65, 22);
            this.beds.TabIndex = 4;
            this.beds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bedrooms";
            // 
            // bedrooms
            // 
            this.bedrooms.Location = new System.Drawing.Point(418, 55);
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.Size = new System.Drawing.Size(65, 22);
            this.bedrooms.TabIndex = 4;
            this.bedrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bathrooms";
            // 
            // bathrooms
            // 
            this.bathrooms.Location = new System.Drawing.Point(597, 53);
            this.bathrooms.Name = "bathrooms";
            this.bathrooms.Size = new System.Drawing.Size(65, 22);
            this.bathrooms.TabIndex = 4;
            this.bathrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Approximate Address";
            // 
            // approximateAddress
            // 
            this.approximateAddress.Location = new System.Drawing.Point(174, 96);
            this.approximateAddress.Name = "approximateAddress";
            this.approximateAddress.Size = new System.Drawing.Size(488, 22);
            this.approximateAddress.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Exact Address";
            // 
            // exactAddress
            // 
            this.exactAddress.Location = new System.Drawing.Point(174, 134);
            this.exactAddress.Name = "exactAddress";
            this.exactAddress.Size = new System.Drawing.Size(488, 22);
            this.exactAddress.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(174, 174);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(488, 22);
            this.description.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Host Rules";
            // 
            // hostRules
            // 
            this.hostRules.Location = new System.Drawing.Point(174, 211);
            this.hostRules.Name = "hostRules";
            this.hostRules.Size = new System.Drawing.Size(488, 22);
            this.hostRules.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Reservation Time (Nights)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Maximum";
            // 
            // maximum
            // 
            this.maximum.Location = new System.Drawing.Point(289, 249);
            this.maximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(83, 22);
            this.maximum.TabIndex = 4;
            this.maximum.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Minimum";
            // 
            // minimum
            // 
            this.minimum.Location = new System.Drawing.Point(475, 249);
            this.minimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(83, 22);
            this.minimum.TabIndex = 4;
            this.minimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(632, 350);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 33);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Close";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(539, 350);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 33);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Choose Available Amenities";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amenity,
            this.choose});
            this.dataGridView1.Location = new System.Drawing.Point(7, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // Amenity
            // 
            this.Amenity.HeaderText = "Amenity";
            this.Amenity.MinimumWidth = 6;
            this.Amenity.Name = "Amenity";
            this.Amenity.ReadOnly = true;
            // 
            // choose
            // 
            this.choose.HeaderText = "";
            this.choose.MinimumWidth = 6;
            this.choose.Name = "choose";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(690, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attraction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attraction,
            this.Area,
            this.Distance,
            this.OnFoot,
            this.ByCar});
            this.dataGridView2.Location = new System.Drawing.Point(7, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(677, 273);
            this.dataGridView2.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(720, 399);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddEditListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Add Listing";
            this.Load += new System.EventHandler(this.AddEditListing_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown beds;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeCbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown bathrooms;
        private System.Windows.Forms.NumericUpDown bedrooms;
        private System.Windows.Forms.NumericUpDown maximum;
        private System.Windows.Forms.TextBox hostRules;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox exactAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox approximateAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minimum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amenity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnFoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByCar;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}
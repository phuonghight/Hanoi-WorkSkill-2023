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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.beds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bedrooms = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bathrooms = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
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
            this.minimum = new System.Windows.Forms.NumericUpDown();
            this.maximum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.amenity = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attraction = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amenity)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attraction)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(843, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hostRules);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.exactAddress);
            this.tabPage1.Controls.Add(this.approximateAddress);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.type);
            this.tabPage1.Controls.Add(this.bathrooms);
            this.tabPage1.Controls.Add(this.bedrooms);
            this.tabPage1.Controls.Add(this.beds);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.maximum);
            this.tabPage1.Controls.Add(this.minimum);
            this.tabPage1.Controls.Add(this.capacity);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listing Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.amenity);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amenity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacity";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(83, 49);
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(67, 22);
            this.capacity.TabIndex = 1;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Beds";
            // 
            // beds
            // 
            this.beds.Location = new System.Drawing.Point(282, 49);
            this.beds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beds.Name = "beds";
            this.beds.Size = new System.Drawing.Size(67, 22);
            this.beds.TabIndex = 1;
            this.beds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Bedrooms";
            // 
            // bedrooms
            // 
            this.bedrooms.Location = new System.Drawing.Point(509, 49);
            this.bedrooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.Size = new System.Drawing.Size(67, 22);
            this.bedrooms.TabIndex = 1;
            this.bedrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Bathrooms";
            // 
            // bathrooms
            // 
            this.bathrooms.Location = new System.Drawing.Point(739, 49);
            this.bathrooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bathrooms.Name = "bathrooms";
            this.bathrooms.Size = new System.Drawing.Size(67, 22);
            this.bathrooms.TabIndex = 1;
            this.bathrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(83, 14);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(286, 24);
            this.type.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(525, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(281, 22);
            this.title.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Approximate Address";
            // 
            // approximateAddress
            // 
            this.approximateAddress.Location = new System.Drawing.Point(160, 86);
            this.approximateAddress.Name = "approximateAddress";
            this.approximateAddress.Size = new System.Drawing.Size(646, 22);
            this.approximateAddress.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exact Address";
            // 
            // exactAddress
            // 
            this.exactAddress.Location = new System.Drawing.Point(160, 124);
            this.exactAddress.Name = "exactAddress";
            this.exactAddress.Size = new System.Drawing.Size(646, 22);
            this.exactAddress.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(160, 165);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(646, 22);
            this.description.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Host Rules";
            // 
            // hostRules
            // 
            this.hostRules.Location = new System.Drawing.Point(160, 209);
            this.hostRules.Name = "hostRules";
            this.hostRules.Size = new System.Drawing.Size(646, 22);
            this.hostRules.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reservation Times (Nights)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Minimum";
            // 
            // minimum
            // 
            this.minimum.Location = new System.Drawing.Point(298, 247);
            this.minimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(67, 22);
            this.minimum.TabIndex = 1;
            this.minimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maximum
            // 
            this.maximum.Location = new System.Drawing.Point(467, 247);
            this.maximum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maximum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(67, 22);
            this.maximum.TabIndex = 1;
            this.maximum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Maximum";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(745, 341);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 33);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Close";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(618, 341);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(107, 33);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Choose Available Amenities";
            // 
            // amenity
            // 
            this.amenity.AllowUserToAddRows = false;
            this.amenity.AllowUserToDeleteRows = false;
            this.amenity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.amenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.amenity.Location = new System.Drawing.Point(33, 50);
            this.amenity.Name = "amenity";
            this.amenity.RowHeadersVisible = false;
            this.amenity.RowHeadersWidth = 51;
            this.amenity.RowTemplate.Height = 24;
            this.amenity.Size = new System.Drawing.Size(407, 233);
            this.amenity.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amenity";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.attraction);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attraction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // attraction
            // 
            this.attraction.AllowUserToAddRows = false;
            this.attraction.AllowUserToDeleteRows = false;
            this.attraction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attraction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.attraction.Location = new System.Drawing.Point(7, 23);
            this.attraction.Name = "attraction";
            this.attraction.RowHeadersVisible = false;
            this.attraction.RowHeadersWidth = 51;
            this.attraction.RowTemplate.Height = 24;
            this.attraction.Size = new System.Drawing.Size(822, 260);
            this.attraction.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Attraction";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Area";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Distance (km)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "On foot (minutes)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "By car (minutes)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // AddEditListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 386);
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
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amenity)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attraction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox exactAddress;
        private System.Windows.Forms.TextBox approximateAddress;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.NumericUpDown bathrooms;
        private System.Windows.Forms.NumericUpDown bedrooms;
        private System.Windows.Forms.NumericUpDown beds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox hostRules;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown maximum;
        private System.Windows.Forms.NumericUpDown minimum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView amenity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView attraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
namespace Session_04
{
    partial class AdvancedSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.nights = new System.Windows.Forms.NumericUpDown();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amenity1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.startPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.attraction = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.amenity3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.amenity2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservation";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount Payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.attraction);
            this.panel1.Controls.Add(this.amenity2);
            this.panel1.Controls.Add(this.amenity3);
            this.panel1.Controls.Add(this.amenity1);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.area);
            this.panel1.Controls.Add(this.capacity);
            this.panel1.Controls.Add(this.maxPrice);
            this.panel1.Controls.Add(this.startPrice);
            this.panel1.Controls.Add(this.nights);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 215);
            this.panel1.TabIndex = 3;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(607, 49);
            this.capacity.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(70, 22);
            this.capacity.TabIndex = 4;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nights
            // 
            this.nights.Location = new System.Drawing.Point(438, 48);
            this.nights.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nights.Name = "nights";
            this.nights.Size = new System.Drawing.Size(70, 22);
            this.nights.TabIndex = 4;
            this.nights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nights.ValueChanged += new System.EventHandler(this.nights_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(62, 48);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(112, 22);
            this.startDate.TabIndex = 3;
            this.startDate.Value = new System.DateTime(2022, 10, 10, 0, 0, 0, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Advanced Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Properties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Area";
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.Location = new System.Drawing.Point(60, 10);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(163, 24);
            this.area.TabIndex = 5;
            this.area.SelectedIndexChanged += new System.EventHandler(this.area_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Title";
            // 
            // title
            // 
            this.title.FormattingEnabled = true;
            this.title.Location = new System.Drawing.Point(571, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(163, 24);
            this.title.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Amenity";
            // 
            // amenity1
            // 
            this.amenity1.FormattingEnabled = true;
            this.amenity1.Location = new System.Drawing.Point(81, 128);
            this.amenity1.Name = "amenity1";
            this.amenity1.Size = new System.Drawing.Size(163, 24);
            this.amenity1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "to";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(245, 48);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(112, 22);
            this.endDate.TabIndex = 3;
            this.endDate.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Start Pricing";
            // 
            // startPrice
            // 
            this.startPrice.Location = new System.Drawing.Point(115, 88);
            this.startPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startPrice.Name = "startPrice";
            this.startPrice.Size = new System.Drawing.Size(70, 22);
            this.startPrice.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Max Pricing";
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(362, 90);
            this.maxPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(70, 22);
            this.maxPrice.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Type";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(570, 89);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(163, 24);
            this.type.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Attraction";
            // 
            // attraction
            // 
            this.attraction.FormattingEnabled = true;
            this.attraction.Location = new System.Drawing.Point(331, 10);
            this.attraction.Name = "attraction";
            this.attraction.Size = new System.Drawing.Size(163, 24);
            this.attraction.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(516, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Amenity";
            // 
            // amenity3
            // 
            this.amenity3.FormattingEnabled = true;
            this.amenity3.Location = new System.Drawing.Point(573, 128);
            this.amenity3.Name = "amenity3";
            this.amenity3.Size = new System.Drawing.Size(163, 24);
            this.amenity3.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Amenity";
            // 
            // amenity2
            // 
            this.amenity2.FormattingEnabled = true;
            this.amenity2.Location = new System.Drawing.Point(333, 128);
            this.amenity2.Name = "amenity2";
            this.amenity2.Size = new System.Drawing.Size(163, 24);
            this.amenity2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear Form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check-in at";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Advanced Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.NumericUpDown nights;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox attraction;
        private System.Windows.Forms.ComboBox amenity2;
        private System.Windows.Forms.ComboBox amenity3;
        private System.Windows.Forms.ComboBox amenity1;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox title;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.NumericUpDown maxPrice;
        private System.Windows.Forms.NumericUpDown startPrice;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
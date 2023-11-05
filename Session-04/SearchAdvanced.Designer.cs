namespace Session4
{
    partial class SearchAdvanced
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
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompletedReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleCbb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.attractionCbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amenityCbb3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.amenityCbb2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.amenityCbb1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.typeCbb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.areaCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.startPrice = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
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
            this.Property,
            this.Area,
            this.AverageScore,
            this.TotalCompletedReservation,
            this.AmountPayable});
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // Property
            // 
            this.Property.HeaderText = "Property";
            this.Property.MinimumWidth = 6;
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "Average Score";
            this.AverageScore.MinimumWidth = 6;
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.ReadOnly = true;
            // 
            // TotalCompletedReservation
            // 
            this.TotalCompletedReservation.HeaderText = "Total completed reservation";
            this.TotalCompletedReservation.MinimumWidth = 6;
            this.TotalCompletedReservation.Name = "TotalCompletedReservation";
            this.TotalCompletedReservation.ReadOnly = true;
            // 
            // AmountPayable
            // 
            this.AmountPayable.HeaderText = "Amount Payable";
            this.AmountPayable.MinimumWidth = 6;
            this.AmountPayable.Name = "AmountPayable";
            this.AmountPayable.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxPrice);
            this.panel1.Controls.Add(this.startPrice);
            this.panel1.Controls.Add(this.titleCbb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.attractionCbb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.amenityCbb3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.amenityCbb2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.amenityCbb1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.typeCbb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.areaCbb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capacity);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.toDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 193);
            this.panel1.TabIndex = 4;
            // 
            // titleCbb
            // 
            this.titleCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.titleCbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titleCbb.FormattingEnabled = true;
            this.titleCbb.Location = new System.Drawing.Point(570, 7);
            this.titleCbb.Name = "titleCbb";
            this.titleCbb.Size = new System.Drawing.Size(168, 24);
            this.titleCbb.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Propertiy Title";
            // 
            // attractionCbb
            // 
            this.attractionCbb.FormattingEnabled = true;
            this.attractionCbb.Location = new System.Drawing.Point(304, 7);
            this.attractionCbb.Name = "attractionCbb";
            this.attractionCbb.Size = new System.Drawing.Size(168, 24);
            this.attractionCbb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Attraction";
            // 
            // amenityCbb3
            // 
            this.amenityCbb3.FormattingEnabled = true;
            this.amenityCbb3.Location = new System.Drawing.Point(570, 127);
            this.amenityCbb3.Name = "amenityCbb3";
            this.amenityCbb3.Size = new System.Drawing.Size(168, 24);
            this.amenityCbb3.TabIndex = 5;
            this.amenityCbb3.SelectedIndexChanged += new System.EventHandler(this.amenityCbb3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(509, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Amenity";
            // 
            // amenityCbb2
            // 
            this.amenityCbb2.FormattingEnabled = true;
            this.amenityCbb2.Location = new System.Drawing.Point(326, 127);
            this.amenityCbb2.Name = "amenityCbb2";
            this.amenityCbb2.Size = new System.Drawing.Size(168, 24);
            this.amenityCbb2.TabIndex = 5;
            this.amenityCbb2.SelectedIndexChanged += new System.EventHandler(this.amenityCbb2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Amenity";
            // 
            // amenityCbb1
            // 
            this.amenityCbb1.FormattingEnabled = true;
            this.amenityCbb1.Location = new System.Drawing.Point(77, 127);
            this.amenityCbb1.Name = "amenityCbb1";
            this.amenityCbb1.Size = new System.Drawing.Size(168, 24);
            this.amenityCbb1.TabIndex = 5;
            this.amenityCbb1.SelectedIndexChanged += new System.EventHandler(this.amenityCbb1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Amenity";
            // 
            // typeCbb
            // 
            this.typeCbb.FormattingEnabled = true;
            this.typeCbb.Location = new System.Drawing.Point(570, 84);
            this.typeCbb.Name = "typeCbb";
            this.typeCbb.Size = new System.Drawing.Size(168, 24);
            this.typeCbb.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Property Type";
            // 
            // areaCbb
            // 
            this.areaCbb.FormattingEnabled = true;
            this.areaCbb.Location = new System.Drawing.Point(53, 7);
            this.areaCbb.Name = "areaCbb";
            this.areaCbb.Size = new System.Drawing.Size(168, 24);
            this.areaCbb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(601, 46);
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(65, 22);
            this.capacity.TabIndex = 3;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(403, 46);
            this.duration.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(72, 22);
            this.duration.TabIndex = 3;
            this.duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(219, 46);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(117, 22);
            this.toDate.TabIndex = 2;
            this.toDate.Value = new System.DateTime(2023, 11, 2, 14, 20, 35, 0);
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(58, 46);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(117, 22);
            this.fromDate.TabIndex = 2;
            this.fromDate.Value = new System.DateTime(2023, 11, 2, 14, 20, 35, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "People";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "and";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nights";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search Propertise";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear Form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simple Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Starting Price";
            // 
            // startPrice
            // 
            this.startPrice.Location = new System.Drawing.Point(109, 85);
            this.startPrice.Name = "startPrice";
            this.startPrice.Size = new System.Drawing.Size(81, 22);
            this.startPrice.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(235, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Maximum Price";
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(339, 84);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(81, 22);
            this.maxPrice.TabIndex = 6;
            // 
            // SearchAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Search Properties or Listing Advanced";
            this.Load += new System.EventHandler(this.SearchAdvanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompletedReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox attractionCbb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox areaCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox titleCbb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox amenityCbb3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox amenityCbb2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox amenityCbb1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox typeCbb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown maxPrice;
        private System.Windows.Forms.NumericUpDown startPrice;
        private System.Windows.Forms.Label label15;
    }
}
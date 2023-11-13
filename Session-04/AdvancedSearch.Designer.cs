namespace Re_Solution_04
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.nights = new System.Windows.Forms.NumericUpDown();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startPrice = new System.Windows.Forms.NumericUpDown();
            this.maxPrice = new System.Windows.Forms.NumericUpDown();
            this.attraction = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.amenity2 = new System.Windows.Forms.ComboBox();
            this.amenity3 = new System.Windows.Forms.ComboBox();
            this.amenity1 = new System.Windows.Forms.ComboBox();
            this.area = new System.Windows.Forms.ComboBox();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nights)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amout payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 287);
            this.panel2.TabIndex = 3;
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(660, 57);
            this.capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(59, 22);
            this.capacity.TabIndex = 4;
            this.capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nights
            // 
            this.nights.Location = new System.Drawing.Point(476, 54);
            this.nights.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nights.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nights.Name = "nights";
            this.nights.Size = new System.Drawing.Size(59, 22);
            this.nights.TabIndex = 4;
            this.nights.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(73, 51);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(122, 22);
            this.fromDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Simple Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Properties...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startPrice);
            this.panel1.Controls.Add(this.maxPrice);
            this.panel1.Controls.Add(this.attraction);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.amenity2);
            this.panel1.Controls.Add(this.amenity3);
            this.panel1.Controls.Add(this.amenity1);
            this.panel1.Controls.Add(this.area);
            this.panel1.Controls.Add(this.capacity);
            this.panel1.Controls.Add(this.nights);
            this.panel1.Controls.Add(this.toDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 234);
            this.panel1.TabIndex = 2;
            // 
            // startPrice
            // 
            this.startPrice.Location = new System.Drawing.Point(110, 103);
            this.startPrice.Name = "startPrice";
            this.startPrice.Size = new System.Drawing.Size(99, 22);
            this.startPrice.TabIndex = 6;
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(371, 103);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(99, 22);
            this.maxPrice.TabIndex = 6;
            // 
            // attraction
            // 
            this.attraction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.attraction.FormattingEnabled = true;
            this.attraction.Location = new System.Drawing.Point(335, 11);
            this.attraction.Name = "attraction";
            this.attraction.Size = new System.Drawing.Size(160, 24);
            this.attraction.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.title.FormattingEnabled = true;
            this.title.Location = new System.Drawing.Point(618, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 24);
            this.title.TabIndex = 5;
            // 
            // type
            // 
            this.type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(625, 103);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(162, 24);
            this.type.TabIndex = 5;
            // 
            // amenity2
            // 
            this.amenity2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.amenity2.FormattingEnabled = true;
            this.amenity2.Location = new System.Drawing.Point(351, 151);
            this.amenity2.Name = "amenity2";
            this.amenity2.Size = new System.Drawing.Size(162, 24);
            this.amenity2.TabIndex = 5;
            // 
            // amenity3
            // 
            this.amenity3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.amenity3.FormattingEnabled = true;
            this.amenity3.Location = new System.Drawing.Point(625, 148);
            this.amenity3.Name = "amenity3";
            this.amenity3.Size = new System.Drawing.Size(162, 24);
            this.amenity3.TabIndex = 5;
            // 
            // amenity1
            // 
            this.amenity1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.amenity1.FormattingEnabled = true;
            this.amenity1.Location = new System.Drawing.Point(77, 148);
            this.amenity1.Name = "amenity1";
            this.amenity1.Size = new System.Drawing.Size(162, 24);
            this.amenity1.TabIndex = 5;
            this.amenity1.SelectedIndexChanged += new System.EventHandler(this.amenity1_SelectedIndexChanged);
            // 
            // area
            // 
            this.area.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.area.FormattingEnabled = true;
            this.area.Location = new System.Drawing.Point(73, 11);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(162, 24);
            this.area.TabIndex = 5;
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(274, 54);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(122, 22);
            this.toDate.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Starting price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Maximum price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(517, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Property Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Attraction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Amenity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(564, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amenity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Property Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amenity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Area";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clear form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Advanced Search";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.NumericUpDown nights;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox attraction;
        private System.Windows.Forms.ComboBox title;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox amenity2;
        private System.Windows.Forms.ComboBox amenity3;
        private System.Windows.Forms.ComboBox amenity1;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown startPrice;
        private System.Windows.Forms.NumericUpDown maxPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
    }
}
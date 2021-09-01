
namespace KGM_Personal
{
    partial class PersonelUygulamaGüncelleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelUygulamaGüncelleme));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePersonalListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kGM_Personal_ListDataSet = new KGM_Personal.KGM_Personal_ListDataSet();
            this.table_Personal_ListesiTableAdapter = new KGM_Personal.KGM_Personal_ListDataSetTableAdapters.Table_Personal_ListesiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableUygulamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_UygulamalarTableAdapter = new KGM_Personal.KGM_Personal_ListDataSetTableAdapters.Table_UygulamalarTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uygulamaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGM_Personal_ListDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUygulamalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personel - Uygulama Güncelleme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.departmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePersonalListesiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 344);
            this.dataGridView1.TabIndex = 6;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // departmanDataGridViewTextBoxColumn
            // 
            this.departmanDataGridViewTextBoxColumn.DataPropertyName = "Departman";
            this.departmanDataGridViewTextBoxColumn.HeaderText = "Departman";
            this.departmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanDataGridViewTextBoxColumn.Name = "departmanDataGridViewTextBoxColumn";
            // 
            // tablePersonalListesiBindingSource
            // 
            this.tablePersonalListesiBindingSource.DataMember = "Table_Personal_Listesi";
            this.tablePersonalListesiBindingSource.DataSource = this.kGM_Personal_ListDataSet;
            // 
            // kGM_Personal_ListDataSet
            // 
            this.kGM_Personal_ListDataSet.DataSetName = "KGM_Personal_ListDataSet";
            this.kGM_Personal_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_Personal_ListesiTableAdapter
            // 
            this.table_Personal_ListesiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(407, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Güncelleme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 171);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 126);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 82);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departman :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(964, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uygulama Güncelleme";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 108);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(208, 22);
            this.textBox7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Uygulama Adı :";
            // 
            // tableUygulamalarBindingSource
            // 
            this.tableUygulamalarBindingSource.DataMember = "Table_Uygulamalar";
            this.tableUygulamalarBindingSource.DataSource = this.kGM_Personal_ListDataSet;
            // 
            // table_UygulamalarTableAdapter
            // 
            this.table_UygulamalarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.uygulamaadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tableUygulamalarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(684, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(274, 344);
            this.dataGridView2.TabIndex = 10;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uygulamaadDataGridViewTextBoxColumn
            // 
            this.uygulamaadDataGridViewTextBoxColumn.DataPropertyName = "Uygulama_ad";
            this.uygulamaadDataGridViewTextBoxColumn.HeaderText = "Uygulama_ad";
            this.uygulamaadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uygulamaadDataGridViewTextBoxColumn.Name = "uygulamaadDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(50, 43);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(62, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID :";
            // 
            // PersonelUygulamaGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(153)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1209, 598);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonelUygulamaGüncelleme";
            this.Text = "PersonelUygulamaGüncelleme";
            this.Load += new System.EventHandler(this.PersonelUygulamaGüncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGM_Personal_ListDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUygulamalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KGM_Personal_ListDataSet kGM_Personal_ListDataSet;
        private System.Windows.Forms.BindingSource tablePersonalListesiBindingSource;
        private KGM_Personal_ListDataSetTableAdapters.Table_Personal_ListesiTableAdapter table_Personal_ListesiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tableUygulamalarBindingSource;
        private KGM_Personal_ListDataSetTableAdapters.Table_UygulamalarTableAdapter table_UygulamalarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uygulamaadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
    }
}
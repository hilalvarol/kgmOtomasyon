
namespace KGM_Personal
{
    partial class PersonelUygulamaArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelUygulamaArama));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kGM_Personal_ListDataSet = new KGM_Personal.KGM_Personal_ListDataSet();
            this.tablePersonalListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_Personal_ListesiTableAdapter = new KGM_Personal.KGM_Personal_ListDataSetTableAdapters.Table_Personal_ListesiTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableUygulamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_UygulamalarTableAdapter = new KGM_Personal.KGM_Personal_ListDataSetTableAdapters.Table_UygulamalarTableAdapter();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uygulamaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGM_Personal_ListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUygulamalarBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView2.Location = new System.Drawing.Point(848, 262);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(336, 327);
            this.dataGridView2.TabIndex = 9;
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
            this.dataGridView1.Location = new System.Drawing.Point(7, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 327);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personel - Uygulama Arama";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 36);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(848, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 36);
            this.textBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(647, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1082, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kGM_Personal_ListDataSet
            // 
            this.kGM_Personal_ListDataSet.DataSetName = "KGM_Personal_ListDataSet";
            this.kGM_Personal_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePersonalListesiBindingSource
            // 
            this.tablePersonalListesiBindingSource.DataMember = "Table_Personal_Listesi";
            this.tablePersonalListesiBindingSource.DataSource = this.kGM_Personal_ListDataSet;
            // 
            // table_Personal_ListesiTableAdapter
            // 
            this.table_Personal_ListesiTableAdapter.ClearBeforeFill = true;
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
            // tableUygulamalarBindingSource
            // 
            this.tableUygulamalarBindingSource.DataMember = "Table_Uygulamalar";
            this.tableUygulamalarBindingSource.DataSource = this.kGM_Personal_ListDataSet;
            // 
            // table_UygulamalarTableAdapter
            // 
            this.table_UygulamalarTableAdapter.ClearBeforeFill = true;
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
            // PersonelUygulamaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(153)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1196, 601);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonelUygulamaArama";
            this.Text = "PersonelUygulamaArama";
            this.Load += new System.EventHandler(this.PersonelUygulamaArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGM_Personal_ListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonalListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUygulamalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private KGM_Personal_ListDataSet kGM_Personal_ListDataSet;
        private System.Windows.Forms.BindingSource tablePersonalListesiBindingSource;
        private KGM_Personal_ListDataSetTableAdapters.Table_Personal_ListesiTableAdapter table_Personal_ListesiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableUygulamalarBindingSource;
        private KGM_Personal_ListDataSetTableAdapters.Table_UygulamalarTableAdapter table_UygulamalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uygulamaadDataGridViewTextBoxColumn;
    }
}
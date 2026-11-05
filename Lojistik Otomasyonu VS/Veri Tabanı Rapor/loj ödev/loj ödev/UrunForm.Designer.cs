namespace loj_ödev
{
    partial class UrunForm
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
            this.txtkg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label_plaka = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmxmüşteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnveri = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.ürünTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.ürünTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(247, 44);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(100, 20);
            this.txtkg.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ağırlık";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(411, 43);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 6;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_model.Location = new System.Drawing.Point(371, 47);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(34, 16);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "Fiyat";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(75, 44);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(0, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 67);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ara";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(0, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 67);
            this.button6.TabIndex = 9;
            this.button6.Text = "Yeni Kayıt";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_plaka
            // 
            this.label_plaka.AutoSize = true;
            this.label_plaka.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_plaka.Location = new System.Drawing.Point(10, 47);
            this.label_plaka.Name = "label_plaka";
            this.label_plaka.Size = new System.Drawing.Size(57, 16);
            this.label_plaka.TabIndex = 0;
            this.label_plaka.Text = "Ürün Adı";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(0, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 67);
            this.button8.TabIndex = 11;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.cmxmüşteri);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtkg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtfiyat);
            this.panel2.Controls.Add(this.label_model);
            this.panel2.Controls.Add(this.txtad);
            this.panel2.Controls.Add(this.label_plaka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 100);
            this.panel2.TabIndex = 17;
            // 
            // cmxmüşteri
            // 
            this.cmxmüşteri.FormattingEnabled = true;
            this.cmxmüşteri.Location = new System.Drawing.Point(589, 43);
            this.cmxmüşteri.Name = "cmxmüşteri";
            this.cmxmüşteri.Size = new System.Drawing.Size(168, 21);
            this.cmxmüşteri.TabIndex = 12;
            this.cmxmüşteri.SelectedIndexChanged += new System.EventHandler(this.cmxmüşteri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(532, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnveri);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 618);
            this.panel1.TabIndex = 16;
            // 
            // btnveri
            // 
            this.btnveri.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnveri.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnveri.Location = new System.Drawing.Point(0, 335);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(106, 67);
            this.btnveri.TabIndex = 12;
            this.btnveri.Text = "Veri Çek";
            this.btnveri.UseVisualStyleBackColor = false;
            this.btnveri.Click += new System.EventHandler(this.btnveri_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(106, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(904, 518);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataMember = "ürün";
            this.ürünBindingSource.DataSource = this.lojistikDataSet;
            // 
            // lojistikDataSet
            // 
            this.lojistikDataSet.DataSetName = "lojistikDataSet";
            this.lojistikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTableAdapter
            // 
            this.ürünTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 13;
            this.button1.Text = "Veri Çek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 618);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UrunForm";
            this.Text = "UrunForm";
            this.Load += new System.EventHandler(this.UrunForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label_plaka;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private lojistikDataSetTableAdapters.ürünTableAdapter ürünTableAdapter;
        private System.Windows.Forms.Button btnveri;
        private System.Windows.Forms.ComboBox cmxmüşteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
namespace loj_ödev
{
    partial class musterilerform
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
            this.richtxtadres = new System.Windows.Forms.RichTextBox();
            this.txtfrim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label_marka = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.label_tip = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label_plaka = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müşteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.müşteriTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.müşteriTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxtadres
            // 
            this.richtxtadres.Location = new System.Drawing.Point(730, 18);
            this.richtxtadres.Name = "richtxtadres";
            this.richtxtadres.Size = new System.Drawing.Size(212, 72);
            this.richtxtadres.TabIndex = 11;
            this.richtxtadres.Text = "";
            // 
            // txtfrim
            // 
            this.txtfrim.Location = new System.Drawing.Point(247, 44);
            this.txtfrim.Name = "txtfrim";
            this.txtfrim.Size = new System.Drawing.Size(100, 20);
            this.txtfrim.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frima Adı";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(574, 44);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 8;
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Location = new System.Drawing.Point(524, 47);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(43, 13);
            this.label_marka.TabIndex = 7;
            this.label_marka.Text = "Telefon";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(398, 44);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 6;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(371, 47);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(21, 13);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "TC";
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Location = new System.Drawing.Point(692, 47);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(39, 13);
            this.label_tip.TabIndex = 3;
            this.label_tip.Text = "Adress";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(75, 44);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 2;
            // 
            // label_plaka
            // 
            this.label_plaka.AutoSize = true;
            this.label_plaka.Location = new System.Drawing.Point(10, 47);
            this.label_plaka.Name = "label_plaka";
            this.label_plaka.Size = new System.Drawing.Size(65, 13);
            this.label_plaka.TabIndex = 0;
            this.label_plaka.Text = "AD_SOYAD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.richtxtadres);
            this.panel2.Controls.Add(this.txtfrim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txttel);
            this.panel2.Controls.Add(this.label_marka);
            this.panel2.Controls.Add(this.txttc);
            this.panel2.Controls.Add(this.label_model);
            this.panel2.Controls.Add(this.label_tip);
            this.panel2.Controls.Add(this.txtad);
            this.panel2.Controls.Add(this.label_plaka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 100);
            this.panel2.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(0, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 67);
            this.button8.TabIndex = 11;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(0, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 67);
            this.button6.TabIndex = 9;
            this.button6.Text = "Yeni Kayıt";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 553);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "Vericek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(106, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 553);
            this.panel3.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // müşteriBindingSource
            // 
            this.müşteriBindingSource.DataMember = "müşteri";
            this.müşteriBindingSource.DataSource = this.lojistikDataSet;
            // 
            // lojistikDataSet
            // 
            this.lojistikDataSet.DataSetName = "lojistikDataSet";
            this.lojistikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müşteriTableAdapter
            // 
            this.müşteriTableAdapter.ClearBeforeFill = true;
            // 
            // musterilerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "musterilerform";
            this.Text = "musterilerform";
            this.Load += new System.EventHandler(this.musterilerform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtadres;
        private System.Windows.Forms.TextBox txtfrim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label_marka;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label_plaka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource müşteriBindingSource;
        private lojistikDataSetTableAdapters.müşteriTableAdapter müşteriTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
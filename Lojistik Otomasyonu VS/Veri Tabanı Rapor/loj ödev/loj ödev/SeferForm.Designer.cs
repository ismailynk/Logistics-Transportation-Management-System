namespace loj_ödev
{
    partial class SeferForm
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
            this.button7 = new System.Windows.Forms.Button();
            this.label_plaka = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmxsiparis = new System.Windows.Forms.ComboBox();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.cmxsorumlu = new System.Windows.Forms.ComboBox();
            this.cmxsofor = new System.Windows.Forms.ComboBox();
            this.cmxarac = new System.Windows.Forms.ComboBox();
            this.datebit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datebas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtguzergah = new System.Windows.Forms.TextBox();
            this.personellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idseferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guzergahseferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bastarihseferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonelsoforDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsiparişDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bittarihseferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorumlupersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.seferTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.seferTableAdapter();
            this.aracTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.aracTableAdapter();
            this.personellTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.personellTableAdapter();
            this.lojistikDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soforsorguToolStrip = new System.Windows.Forms.ToolStrip();
            this.soforsorguToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSetBindingSource)).BeginInit();
            this.soforsorguToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(0, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 67);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ara";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label_plaka
            // 
            this.label_plaka.AutoSize = true;
            this.label_plaka.Location = new System.Drawing.Point(13, 21);
            this.label_plaka.Name = "label_plaka";
            this.label_plaka.Size = new System.Drawing.Size(53, 13);
            this.label_plaka.TabIndex = 0;
            this.label_plaka.Text = "Güzergah";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(0, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 67);
            this.button8.TabIndex = 11;
            this.button8.Text = "Bilgileri Göster";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.cmxsiparis);
            this.panel2.Controls.Add(this.cmxsorumlu);
            this.panel2.Controls.Add(this.cmxsofor);
            this.panel2.Controls.Add(this.cmxarac);
            this.panel2.Controls.Add(this.datebit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.datebas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtguzergah);
            this.panel2.Controls.Add(this.label_plaka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(106, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 95);
            this.panel2.TabIndex = 17;
            // 
            // cmxsiparis
            // 
            this.cmxsiparis.DataSource = this.aracBindingSource;
            this.cmxsiparis.DisplayMember = "plaka_arac";
            this.cmxsiparis.FormattingEnabled = true;
            this.cmxsiparis.Location = new System.Drawing.Point(659, 54);
            this.cmxsiparis.Name = "cmxsiparis";
            this.cmxsiparis.Size = new System.Drawing.Size(121, 21);
            this.cmxsiparis.TabIndex = 19;
            this.cmxsiparis.ValueMember = "id_arac";
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataMember = "arac";
            this.aracBindingSource.DataSource = this.lojistikDataSet;
            // 
            // lojistikDataSet
            // 
            this.lojistikDataSet.DataSetName = "lojistikDataSet";
            this.lojistikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmxsorumlu
            // 
            this.cmxsorumlu.DataSource = this.aracBindingSource;
            this.cmxsorumlu.DisplayMember = "plaka_arac";
            this.cmxsorumlu.FormattingEnabled = true;
            this.cmxsorumlu.Location = new System.Drawing.Point(466, 18);
            this.cmxsorumlu.Name = "cmxsorumlu";
            this.cmxsorumlu.Size = new System.Drawing.Size(121, 21);
            this.cmxsorumlu.TabIndex = 18;
            this.cmxsorumlu.ValueMember = "id_arac";
            // 
            // cmxsofor
            // 
            this.cmxsofor.FormattingEnabled = true;
            this.cmxsofor.Location = new System.Drawing.Point(265, 17);
            this.cmxsofor.Name = "cmxsofor";
            this.cmxsofor.Size = new System.Drawing.Size(121, 21);
            this.cmxsofor.TabIndex = 17;
            // 
            // cmxarac
            // 
            this.cmxarac.DataSource = this.aracBindingSource;
            this.cmxarac.DisplayMember = "plaka_arac";
            this.cmxarac.FormattingEnabled = true;
            this.cmxarac.Location = new System.Drawing.Point(655, 18);
            this.cmxarac.Name = "cmxarac";
            this.cmxarac.Size = new System.Drawing.Size(121, 21);
            this.cmxarac.TabIndex = 16;
            this.cmxarac.ValueMember = "id_arac";
            // 
            // datebit
            // 
            this.datebit.CustomFormat = "Short";
            this.datebit.DataBindings.Add(new System.Windows.Forms.Binding("Format", global::loj_ödev.Properties.Settings.Default, "kısa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.datebit.Format = global::loj_ödev.Properties.Settings.Default.kısa;
            this.datebit.Location = new System.Drawing.Point(374, 54);
            this.datebit.Name = "datebit";
            this.datebit.Size = new System.Drawing.Size(200, 20);
            this.datebit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sipariş Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Araç Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sorumlu Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şoför Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitiş tarihi";
            // 
            // datebas
            // 
            this.datebas.CustomFormat = "Short";
            this.datebas.DataBindings.Add(new System.Windows.Forms.Binding("Format", global::loj_ödev.Properties.Settings.Default, "kısa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.datebas.Format = global::loj_ödev.Properties.Settings.Default.kısa;
            this.datebas.Location = new System.Drawing.Point(94, 54);
            this.datebas.Name = "datebas";
            this.datebas.Size = new System.Drawing.Size(200, 20);
            this.datebas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç tarihi";
            // 
            // txtguzergah
            // 
            this.txtguzergah.Location = new System.Drawing.Point(78, 18);
            this.txtguzergah.Name = "txtguzergah";
            this.txtguzergah.Size = new System.Drawing.Size(100, 20);
            this.txtguzergah.TabIndex = 2;
            // 
            // personellBindingSource
            // 
            this.personellBindingSource.DataMember = "personell";
            this.personellBindingSource.DataSource = this.lojistikDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 650);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idseferDataGridViewTextBoxColumn,
            this.guzergahseferDataGridViewTextBoxColumn,
            this.bastarihseferDataGridViewTextBoxColumn,
            this.idaracDataGridViewTextBoxColumn,
            this.idpersonelsoforDataGridViewTextBoxColumn,
            this.idsiparişDataGridViewTextBoxColumn,
            this.bittarihseferDataGridViewTextBoxColumn,
            this.sorumlupersonelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seferBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(971, 555);
            this.dataGridView1.TabIndex = 18;
            // 
            // idseferDataGridViewTextBoxColumn
            // 
            this.idseferDataGridViewTextBoxColumn.DataPropertyName = "id_sefer";
            this.idseferDataGridViewTextBoxColumn.HeaderText = "id_sefer";
            this.idseferDataGridViewTextBoxColumn.Name = "idseferDataGridViewTextBoxColumn";
            this.idseferDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guzergahseferDataGridViewTextBoxColumn
            // 
            this.guzergahseferDataGridViewTextBoxColumn.DataPropertyName = "guzergah_sefer";
            this.guzergahseferDataGridViewTextBoxColumn.HeaderText = "guzergah_sefer";
            this.guzergahseferDataGridViewTextBoxColumn.Name = "guzergahseferDataGridViewTextBoxColumn";
            // 
            // bastarihseferDataGridViewTextBoxColumn
            // 
            this.bastarihseferDataGridViewTextBoxColumn.DataPropertyName = "bas_tarih_sefer";
            this.bastarihseferDataGridViewTextBoxColumn.HeaderText = "bas_tarih_sefer";
            this.bastarihseferDataGridViewTextBoxColumn.Name = "bastarihseferDataGridViewTextBoxColumn";
            // 
            // idaracDataGridViewTextBoxColumn
            // 
            this.idaracDataGridViewTextBoxColumn.DataPropertyName = "id_arac";
            this.idaracDataGridViewTextBoxColumn.HeaderText = "id_arac";
            this.idaracDataGridViewTextBoxColumn.Name = "idaracDataGridViewTextBoxColumn";
            // 
            // idpersonelsoforDataGridViewTextBoxColumn
            // 
            this.idpersonelsoforDataGridViewTextBoxColumn.DataPropertyName = "id_personel_sofor";
            this.idpersonelsoforDataGridViewTextBoxColumn.HeaderText = "id_personel_sofor";
            this.idpersonelsoforDataGridViewTextBoxColumn.Name = "idpersonelsoforDataGridViewTextBoxColumn";
            // 
            // idsiparişDataGridViewTextBoxColumn
            // 
            this.idsiparişDataGridViewTextBoxColumn.DataPropertyName = "id_sipariş";
            this.idsiparişDataGridViewTextBoxColumn.HeaderText = "id_sipariş";
            this.idsiparişDataGridViewTextBoxColumn.Name = "idsiparişDataGridViewTextBoxColumn";
            // 
            // bittarihseferDataGridViewTextBoxColumn
            // 
            this.bittarihseferDataGridViewTextBoxColumn.DataPropertyName = "bit_tarih_sefer";
            this.bittarihseferDataGridViewTextBoxColumn.HeaderText = "bit_tarih_sefer";
            this.bittarihseferDataGridViewTextBoxColumn.Name = "bittarihseferDataGridViewTextBoxColumn";
            // 
            // sorumlupersonelDataGridViewTextBoxColumn
            // 
            this.sorumlupersonelDataGridViewTextBoxColumn.DataPropertyName = "sorumlu_personel";
            this.sorumlupersonelDataGridViewTextBoxColumn.HeaderText = "sorumlu_personel";
            this.sorumlupersonelDataGridViewTextBoxColumn.Name = "sorumlupersonelDataGridViewTextBoxColumn";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "sefer";
            this.seferBindingSource.DataSource = this.lojistikDataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(106, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 555);
            this.panel3.TabIndex = 18;
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // aracTableAdapter
            // 
            this.aracTableAdapter.ClearBeforeFill = true;
            // 
            // personellTableAdapter
            // 
            this.personellTableAdapter.ClearBeforeFill = true;
            // 
            // lojistikDataSetBindingSource
            // 
            this.lojistikDataSetBindingSource.DataSource = this.lojistikDataSet;
            this.lojistikDataSetBindingSource.Position = 0;
            // 
            // soforsorguToolStrip
            // 
            this.soforsorguToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soforsorguToolStripButton});
            this.soforsorguToolStrip.Location = new System.Drawing.Point(0, 0);
            this.soforsorguToolStrip.Name = "soforsorguToolStrip";
            this.soforsorguToolStrip.Size = new System.Drawing.Size(1077, 25);
            this.soforsorguToolStrip.TabIndex = 19;
            this.soforsorguToolStrip.Text = "soforsorguToolStrip";
            // 
            // soforsorguToolStripButton
            // 
            this.soforsorguToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.soforsorguToolStripButton.Name = "soforsorguToolStripButton";
            this.soforsorguToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.soforsorguToolStripButton.Text = "soforsorgu";
            this.soforsorguToolStripButton.Click += new System.EventHandler(this.soforsorguToolStripButton_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "Yeni Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soforsorguToolStrip);
            this.Name = "SeferForm";
            this.Text = "SeferForm";
            this.Load += new System.EventHandler(this.SeferForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSetBindingSource)).EndInit();
            this.soforsorguToolStrip.ResumeLayout(false);
            this.soforsorguToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label_plaka;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datebas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datebit;
        private System.Windows.Forms.Panel panel3;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private lojistikDataSetTableAdapters.seferTableAdapter seferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idseferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guzergahseferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bastarihseferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonelsoforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsiparişDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bittarihseferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorumlupersonelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmxarac;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private lojistikDataSetTableAdapters.aracTableAdapter aracTableAdapter;
        private System.Windows.Forms.ComboBox cmxsiparis;
        private System.Windows.Forms.ComboBox cmxsorumlu;
        private System.Windows.Forms.ComboBox cmxsofor;
        private System.Windows.Forms.TextBox txtguzergah;
        private System.Windows.Forms.BindingSource personellBindingSource;
        private lojistikDataSetTableAdapters.personellTableAdapter personellTableAdapter;
        private System.Windows.Forms.BindingSource lojistikDataSetBindingSource;
        private System.Windows.Forms.ToolStrip soforsorguToolStrip;
        private System.Windows.Forms.ToolStripButton soforsorguToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}
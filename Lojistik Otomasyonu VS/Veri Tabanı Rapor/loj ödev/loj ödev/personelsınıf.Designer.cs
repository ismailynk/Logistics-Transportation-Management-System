namespace loj_ödev
{
    partial class personelsınıf
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
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtpz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.sınıfpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sınıf_personelTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.sınıf_personelTableAdapter();
            this.idsınıfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyonsınıfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maaşpozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfpersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "veri çek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(3, 268);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 67);
            this.button8.TabIndex = 11;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(0, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 67);
            this.button6.TabIndex = 9;
            this.button6.Text = "Yeni Kayıt";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtpz
            // 
            this.txtpz.Location = new System.Drawing.Point(248, 29);
            this.txtpz.Name = "txtpz";
            this.txtpz.Size = new System.Drawing.Size(100, 20);
            this.txtpz.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pozisyon";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(407, 29);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(100, 20);
            this.txtmaas.TabIndex = 6;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(372, 32);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(33, 13);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "Maaş";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.txtpz);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtmaas);
            this.panel2.Controls.Add(this.label_model);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 79);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 537);
            this.panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsınıfDataGridViewTextBoxColumn,
            this.pozisyonsınıfDataGridViewTextBoxColumn,
            this.maaşpozisyonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sınıfpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(106, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 458);
            this.dataGridView1.TabIndex = 23;
            // 
            // lojistikDataSet
            // 
            this.lojistikDataSet.DataSetName = "lojistikDataSet";
            this.lojistikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sınıfpersonelBindingSource
            // 
            this.sınıfpersonelBindingSource.DataMember = "sınıf_personel";
            this.sınıfpersonelBindingSource.DataSource = this.lojistikDataSet;
            // 
            // sınıf_personelTableAdapter
            // 
            this.sınıf_personelTableAdapter.ClearBeforeFill = true;
            // 
            // idsınıfDataGridViewTextBoxColumn
            // 
            this.idsınıfDataGridViewTextBoxColumn.DataPropertyName = "id_sınıf";
            this.idsınıfDataGridViewTextBoxColumn.HeaderText = "id_sınıf";
            this.idsınıfDataGridViewTextBoxColumn.Name = "idsınıfDataGridViewTextBoxColumn";
            this.idsınıfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pozisyonsınıfDataGridViewTextBoxColumn
            // 
            this.pozisyonsınıfDataGridViewTextBoxColumn.DataPropertyName = "pozisyon_sınıf";
            this.pozisyonsınıfDataGridViewTextBoxColumn.HeaderText = "pozisyon_sınıf";
            this.pozisyonsınıfDataGridViewTextBoxColumn.Name = "pozisyonsınıfDataGridViewTextBoxColumn";
            // 
            // maaşpozisyonDataGridViewTextBoxColumn
            // 
            this.maaşpozisyonDataGridViewTextBoxColumn.DataPropertyName = "maaş_pozisyon";
            this.maaşpozisyonDataGridViewTextBoxColumn.HeaderText = "maaş_pozisyon";
            this.maaşpozisyonDataGridViewTextBoxColumn.Name = "maaşpozisyonDataGridViewTextBoxColumn";
            // 
            // personelsınıf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "personelsınıf";
            this.Text = "personelsınıf";
            this.Load += new System.EventHandler(this.personelsınıf_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfpersonelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtpz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource sınıfpersonelBindingSource;
        private lojistikDataSetTableAdapters.sınıf_personelTableAdapter sınıf_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsınıfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyonsınıfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maaşpozisyonDataGridViewTextBoxColumn;
    }
}
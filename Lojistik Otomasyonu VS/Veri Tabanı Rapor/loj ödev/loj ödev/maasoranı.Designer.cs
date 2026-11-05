namespace loj_ödev
{
    partial class maasoranı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtyıl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoran = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.sınıfpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sınıf_personelTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.sınıf_personelTableAdapter();
            this.maaskatsayıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maas_katsayıTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.maas_katsayıTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmaaskatsayıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yiloranıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maaskatsayıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 152);
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
            this.button8.Location = new System.Drawing.Point(0, 79);
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
            this.button6.Location = new System.Drawing.Point(0, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 67);
            this.button6.TabIndex = 9;
            this.button6.Text = "Yeni Kayıt";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 478);
            this.panel1.TabIndex = 23;
            // 
            // txtyıl
            // 
            this.txtyıl.Location = new System.Drawing.Point(248, 29);
            this.txtyıl.Name = "txtyıl";
            this.txtyıl.Size = new System.Drawing.Size(100, 20);
            this.txtyıl.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yıl";
            // 
            // txtoran
            // 
            this.txtoran.Location = new System.Drawing.Point(416, 29);
            this.txtoran.Name = "txtoran";
            this.txtoran.Size = new System.Drawing.Size(100, 20);
            this.txtoran.TabIndex = 6;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(372, 32);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(38, 13);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "ORAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.txtyıl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtoran);
            this.panel2.Controls.Add(this.label_model);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 79);
            this.panel2.TabIndex = 24;
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
            // maaskatsayıBindingSource
            // 
            this.maaskatsayıBindingSource.DataMember = "maas_katsayı";
            this.maaskatsayıBindingSource.DataSource = this.lojistikDataSet;
            // 
            // maas_katsayıTableAdapter
            // 
            this.maas_katsayıTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmaaskatsayıDataGridViewTextBoxColumn,
            this.personelyiliDataGridViewTextBoxColumn,
            this.yiloranıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maaskatsayıBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(106, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 478);
            this.dataGridView1.TabIndex = 25;
            // 
            // idmaaskatsayıDataGridViewTextBoxColumn
            // 
            this.idmaaskatsayıDataGridViewTextBoxColumn.DataPropertyName = "id_maas_katsayı";
            this.idmaaskatsayıDataGridViewTextBoxColumn.HeaderText = "id_maas_katsayı";
            this.idmaaskatsayıDataGridViewTextBoxColumn.Name = "idmaaskatsayıDataGridViewTextBoxColumn";
            this.idmaaskatsayıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelyiliDataGridViewTextBoxColumn
            // 
            this.personelyiliDataGridViewTextBoxColumn.DataPropertyName = "personel_yili";
            this.personelyiliDataGridViewTextBoxColumn.HeaderText = "personel_yili";
            this.personelyiliDataGridViewTextBoxColumn.Name = "personelyiliDataGridViewTextBoxColumn";
            // 
            // yiloranıDataGridViewTextBoxColumn
            // 
            this.yiloranıDataGridViewTextBoxColumn.DataPropertyName = "yil_oranı";
            this.yiloranıDataGridViewTextBoxColumn.HeaderText = "yil_oranı";
            this.yiloranıDataGridViewTextBoxColumn.Name = "yiloranıDataGridViewTextBoxColumn";
            // 
            // personelsınıfı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "personelsınıfı";
            this.Text = "personelsınıfı";
            this.Load += new System.EventHandler(this.personelsınıfı_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maaskatsayıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtyıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoran;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Panel panel2;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource sınıfpersonelBindingSource;
        private lojistikDataSetTableAdapters.sınıf_personelTableAdapter sınıf_personelTableAdapter;
        private System.Windows.Forms.BindingSource maaskatsayıBindingSource;
        private lojistikDataSetTableAdapters.maas_katsayıTableAdapter maas_katsayıTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaaskatsayıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yiloranıDataGridViewTextBoxColumn;
    }
}
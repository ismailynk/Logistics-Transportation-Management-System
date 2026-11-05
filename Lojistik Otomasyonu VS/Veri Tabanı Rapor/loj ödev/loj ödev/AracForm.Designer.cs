namespace loj_ödev
{
    partial class AracForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label_marka = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label_model = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.label_tip = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label_plaka = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idaracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaaracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiparacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojistikDataSet = new loj_ödev.lojistikDataSet();
            this.aracTableAdapter = new loj_ödev.lojistikDataSetTableAdapters.aracTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 585);
            this.panel1.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.button7.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.button6.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.txtmarka);
            this.panel2.Controls.Add(this.label_marka);
            this.panel2.Controls.Add(this.txtmodel);
            this.panel2.Controls.Add(this.label_model);
            this.panel2.Controls.Add(this.txttip);
            this.panel2.Controls.Add(this.label_tip);
            this.panel2.Controls.Add(this.txtplaka);
            this.panel2.Controls.Add(this.label_plaka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 100);
            this.panel2.TabIndex = 2;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(641, 44);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 8;
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_marka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_marka.Location = new System.Drawing.Point(591, 47);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(51, 16);
            this.label_marka.TabIndex = 7;
            this.label_marka.Text = "Marka";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(487, 44);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(100, 20);
            this.txtmodel.TabIndex = 6;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_model.Location = new System.Drawing.Point(430, 47);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(51, 16);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "Model";
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(324, 44);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(100, 20);
            this.txttip.TabIndex = 4;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_tip.Location = new System.Drawing.Point(247, 45);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(71, 16);
            this.label_tip.TabIndex = 3;
            this.label_tip.Text = "Arac Tipi";
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(132, 43);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(100, 20);
            this.txtplaka.TabIndex = 2;
            // 
            // label_plaka
            // 
            this.label_plaka.AutoSize = true;
            this.label_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_plaka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_plaka.Location = new System.Drawing.Point(42, 47);
            this.label_plaka.Name = "label_plaka";
            this.label_plaka.Size = new System.Drawing.Size(84, 16);
            this.label_plaka.TabIndex = 0;
            this.label_plaka.Text = "Arac Plaka";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaracDataGridViewTextBoxColumn,
            this.plakaaracDataGridViewTextBoxColumn,
            this.tiparacDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(106, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 485);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idaracDataGridViewTextBoxColumn
            // 
            this.idaracDataGridViewTextBoxColumn.DataPropertyName = "id_arac";
            this.idaracDataGridViewTextBoxColumn.HeaderText = "id_arac";
            this.idaracDataGridViewTextBoxColumn.Name = "idaracDataGridViewTextBoxColumn";
            this.idaracDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plakaaracDataGridViewTextBoxColumn
            // 
            this.plakaaracDataGridViewTextBoxColumn.DataPropertyName = "plaka_arac";
            this.plakaaracDataGridViewTextBoxColumn.HeaderText = "PLAKA";
            this.plakaaracDataGridViewTextBoxColumn.Name = "plakaaracDataGridViewTextBoxColumn";
            // 
            // tiparacDataGridViewTextBoxColumn
            // 
            this.tiparacDataGridViewTextBoxColumn.DataPropertyName = "tip_arac";
            this.tiparacDataGridViewTextBoxColumn.HeaderText = "TİP";
            this.tiparacDataGridViewTextBoxColumn.Name = "tiparacDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
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
            // aracTableAdapter
            // 
            this.aracTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "VERİ çek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 67);
            this.button2.TabIndex = 13;
            this.button2.Text = "Tazele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AracForm";
            this.Text = "AracForm";
            this.Load += new System.EventHandler(this.AracForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojistikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label_marka;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label_plaka;
        private lojistikDataSet lojistikDataSet;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private lojistikDataSetTableAdapters.aracTableAdapter aracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaaracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiparacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
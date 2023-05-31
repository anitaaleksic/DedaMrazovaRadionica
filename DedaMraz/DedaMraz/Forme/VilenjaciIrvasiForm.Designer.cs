namespace DedaMraz.Forme
{
    partial class VilenjaciIrvasiForm
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
            this.btnObrisiVilenjakaIrvasi = new System.Windows.Forms.Button();
            this.btnDodajVilenjakaIrvasi = new System.Windows.Forms.Button();
            this.vilenjaciirvasi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPesma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiVilenjakaIrvasi
            // 
            this.btnObrisiVilenjakaIrvasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisiVilenjakaIrvasi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisiVilenjakaIrvasi.FlatAppearance.BorderSize = 3;
            this.btnObrisiVilenjakaIrvasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiVilenjakaIrvasi.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisiVilenjakaIrvasi.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisiVilenjakaIrvasi.Location = new System.Drawing.Point(11, 144);
            this.btnObrisiVilenjakaIrvasi.Name = "btnObrisiVilenjakaIrvasi";
            this.btnObrisiVilenjakaIrvasi.Size = new System.Drawing.Size(197, 89);
            this.btnObrisiVilenjakaIrvasi.TabIndex = 1;
            this.btnObrisiVilenjakaIrvasi.Text = "Obrisi vilenjaka";
            this.btnObrisiVilenjakaIrvasi.UseVisualStyleBackColor = true;
            this.btnObrisiVilenjakaIrvasi.Click += new System.EventHandler(this.btnObrisiVilenjakaIrvasi_Click);
            // 
            // btnDodajVilenjakaIrvasi
            // 
            this.btnDodajVilenjakaIrvasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaIrvasi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaIrvasi.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaIrvasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaIrvasi.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaIrvasi.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaIrvasi.Location = new System.Drawing.Point(11, 33);
            this.btnDodajVilenjakaIrvasi.Name = "btnDodajVilenjakaIrvasi";
            this.btnDodajVilenjakaIrvasi.Size = new System.Drawing.Size(197, 89);
            this.btnDodajVilenjakaIrvasi.TabIndex = 2;
            this.btnDodajVilenjakaIrvasi.Text = "Dodaj vilenjaka";
            this.btnDodajVilenjakaIrvasi.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaIrvasi.Click += new System.EventHandler(this.btnDodajVilenjakaIrvasi_Click);
            // 
            // vilenjaciirvasi
            // 
            this.vilenjaciirvasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.vilenjaciirvasi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.vilenjaciirvasi.FullRowSelect = true;
            this.vilenjaciirvasi.GridLines = true;
            this.vilenjaciirvasi.HideSelection = false;
            this.vilenjaciirvasi.Location = new System.Drawing.Point(18, 21);
            this.vilenjaciirvasi.Name = "vilenjaciirvasi";
            this.vilenjaciirvasi.Size = new System.Drawing.Size(503, 351);
            this.vilenjaciirvasi.TabIndex = 4;
            this.vilenjaciirvasi.UseCompatibleStateImageBehavior = false;
            this.vilenjaciirvasi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zemlja porekla";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Radni staz";
            this.columnHeader4.Width = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.vilenjaciirvasi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 393);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vilenjaci za irvase";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox2.Controls.Add(this.btnDodajVilenjakaIrvasi);
            this.groupBox2.Controls.Add(this.btnObrisiVilenjakaIrvasi);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(574, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 250);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uredi vilenjaka";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox3.Controls.Add(this.btnPesma);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(575, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 137);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesme";
            // 
            // btnPesma
            // 
            this.btnPesma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPesma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPesma.FlatAppearance.BorderSize = 3;
            this.btnPesma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesma.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPesma.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPesma.Location = new System.Drawing.Point(10, 27);
            this.btnPesma.Name = "btnPesma";
            this.btnPesma.Size = new System.Drawing.Size(197, 89);
            this.btnPesma.TabIndex = 2;
            this.btnPesma.Text = "Pesme";
            this.btnPesma.UseVisualStyleBackColor = true;
            this.btnPesma.Click += new System.EventHandler(this.btnPesma_Click);
            // 
            // VilenjaciIrvasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(824, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VilenjaciIrvasiForm";
            this.Text = "VILENJACI ZA IRVASE";
            this.Load += new System.EventHandler(this.VilenjaciIrvasiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisiVilenjakaIrvasi;
        private System.Windows.Forms.Button btnDodajVilenjakaIrvasi;
        private System.Windows.Forms.ListView vilenjaciirvasi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesma;
    }
}
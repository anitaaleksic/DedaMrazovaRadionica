namespace DedaMraz.Forme
{
    partial class IrvasiForm
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
            this.btnDodajIrvasa = new System.Windows.Forms.Button();
            this.btnIzmeniIrvasa = new System.Windows.Forms.Button();
            this.btnVlasnikIrvasa = new System.Windows.Forms.Button();
            this.gbUrediIrvase = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbVlasnik = new System.Windows.Forms.GroupBox();
            this.irvasi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUrediIrvase.SuspendLayout();
            this.gbVlasnik.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajIrvasa
            // 
            this.btnDodajIrvasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajIrvasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajIrvasa.FlatAppearance.BorderSize = 3;
            this.btnDodajIrvasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajIrvasa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajIrvasa.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajIrvasa.Location = new System.Drawing.Point(23, 36);
            this.btnDodajIrvasa.Name = "btnDodajIrvasa";
            this.btnDodajIrvasa.Size = new System.Drawing.Size(235, 53);
            this.btnDodajIrvasa.TabIndex = 1;
            this.btnDodajIrvasa.Text = "Dodaj irvasa";
            this.btnDodajIrvasa.UseVisualStyleBackColor = true;
            this.btnDodajIrvasa.Click += new System.EventHandler(this.btnDodajIrvasa_Click);
            // 
            // btnIzmeniIrvasa
            // 
            this.btnIzmeniIrvasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnIzmeniIrvasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnIzmeniIrvasa.FlatAppearance.BorderSize = 3;
            this.btnIzmeniIrvasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniIrvasa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnIzmeniIrvasa.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzmeniIrvasa.Location = new System.Drawing.Point(23, 219);
            this.btnIzmeniIrvasa.Name = "btnIzmeniIrvasa";
            this.btnIzmeniIrvasa.Size = new System.Drawing.Size(235, 54);
            this.btnIzmeniIrvasa.TabIndex = 3;
            this.btnIzmeniIrvasa.Text = "Izmeni irvasa";
            this.btnIzmeniIrvasa.UseVisualStyleBackColor = true;
            this.btnIzmeniIrvasa.Click += new System.EventHandler(this.btnIzmeniIrvasa_Click);
            // 
            // btnVlasnikIrvasa
            // 
            this.btnVlasnikIrvasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnVlasnikIrvasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnVlasnikIrvasa.FlatAppearance.BorderSize = 3;
            this.btnVlasnikIrvasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVlasnikIrvasa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnVlasnikIrvasa.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnVlasnikIrvasa.Location = new System.Drawing.Point(23, 33);
            this.btnVlasnikIrvasa.Name = "btnVlasnikIrvasa";
            this.btnVlasnikIrvasa.Size = new System.Drawing.Size(235, 58);
            this.btnVlasnikIrvasa.TabIndex = 4;
            this.btnVlasnikIrvasa.Text = "Vilenjaci";
            this.btnVlasnikIrvasa.UseVisualStyleBackColor = true;
            this.btnVlasnikIrvasa.Click += new System.EventHandler(this.btnVlasnikIrvasa_Click);
            // 
            // gbUrediIrvase
            // 
            this.gbUrediIrvase.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.gbUrediIrvase.Controls.Add(this.btnObrisi);
            this.gbUrediIrvase.Controls.Add(this.btnIzmeniIrvasa);
            this.gbUrediIrvase.Controls.Add(this.btnDodajIrvasa);
            this.gbUrediIrvase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbUrediIrvase.Location = new System.Drawing.Point(567, 12);
            this.gbUrediIrvase.Name = "gbUrediIrvase";
            this.gbUrediIrvase.Size = new System.Drawing.Size(277, 296);
            this.gbUrediIrvase.TabIndex = 5;
            this.gbUrediIrvase.TabStop = false;
            this.gbUrediIrvase.Text = "Uredi irvase";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisi.FlatAppearance.BorderSize = 3;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisi.Location = new System.Drawing.Point(23, 129);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(235, 52);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi irvasa";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // gbVlasnik
            // 
            this.gbVlasnik.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.gbVlasnik.Controls.Add(this.btnVlasnikIrvasa);
            this.gbVlasnik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbVlasnik.Location = new System.Drawing.Point(567, 325);
            this.gbVlasnik.Name = "gbVlasnik";
            this.gbVlasnik.Size = new System.Drawing.Size(280, 113);
            this.gbVlasnik.TabIndex = 6;
            this.gbVlasnik.TabStop = false;
            this.gbVlasnik.Text = "Vilenjaci";
            // 
            // irvasi
            // 
            this.irvasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.irvasi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.irvasi.FullRowSelect = true;
            this.irvasi.GridLines = true;
            this.irvasi.HideSelection = false;
            this.irvasi.Location = new System.Drawing.Point(25, 21);
            this.irvasi.Name = "irvasi";
            this.irvasi.Size = new System.Drawing.Size(491, 391);
            this.irvasi.TabIndex = 7;
            this.irvasi.UseCompatibleStateImageBehavior = false;
            this.irvasi.View = System.Windows.Forms.View.Details;
            this.irvasi.SelectedIndexChanged += new System.EventHandler(this.irvasi_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Nadimak";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pol";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum Rodjenja";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.irvasi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 425);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Irvasi";
            // 
            // IrvasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVlasnik);
            this.Controls.Add(this.gbUrediIrvase);
            this.Name = "IrvasiForm";
            this.Text = "IRVASI";
            this.Load += new System.EventHandler(this.IrvasiForm_Load);
            this.gbUrediIrvase.ResumeLayout(false);
            this.gbVlasnik.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajIrvasa;
        private System.Windows.Forms.Button btnObrisiIrvasa;
        private System.Windows.Forms.Button btnIzmeniIrvasa;
        private System.Windows.Forms.Button btnVlasnikIrvasa;
        private System.Windows.Forms.GroupBox gbUrediIrvase;
        private System.Windows.Forms.GroupBox gbVlasnik;
        private System.Windows.Forms.ListView irvasi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
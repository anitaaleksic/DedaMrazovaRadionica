namespace DedaMraz.Forme
{
    partial class VilenjaciIgrackeForm
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
            this.btnObrisiVilenjakaIgracke = new System.Windows.Forms.Button();
            this.btnDodajVilenjakaIgracke = new System.Windows.Forms.Button();
            this.vilenjaciigracke = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiVilenjakaIgracke
            // 
            this.btnObrisiVilenjakaIgracke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisiVilenjakaIgracke.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisiVilenjakaIgracke.FlatAppearance.BorderSize = 3;
            this.btnObrisiVilenjakaIgracke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiVilenjakaIgracke.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisiVilenjakaIgracke.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisiVilenjakaIgracke.Location = new System.Drawing.Point(689, 279);
            this.btnObrisiVilenjakaIgracke.Name = "btnObrisiVilenjakaIgracke";
            this.btnObrisiVilenjakaIgracke.Size = new System.Drawing.Size(192, 89);
            this.btnObrisiVilenjakaIgracke.TabIndex = 1;
            this.btnObrisiVilenjakaIgracke.Text = "Obrisi vilenjaka";
            this.btnObrisiVilenjakaIgracke.UseVisualStyleBackColor = true;
            this.btnObrisiVilenjakaIgracke.Click += new System.EventHandler(this.btnObrisiVilenjakaIgracke_Click);
            // 
            // btnDodajVilenjakaIgracke
            // 
            this.btnDodajVilenjakaIgracke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaIgracke.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaIgracke.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaIgracke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaIgracke.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaIgracke.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaIgracke.Location = new System.Drawing.Point(689, 42);
            this.btnDodajVilenjakaIgracke.Name = "btnDodajVilenjakaIgracke";
            this.btnDodajVilenjakaIgracke.Size = new System.Drawing.Size(192, 89);
            this.btnDodajVilenjakaIgracke.TabIndex = 2;
            this.btnDodajVilenjakaIgracke.Text = "Dodaj vilenjaka";
            this.btnDodajVilenjakaIgracke.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaIgracke.Click += new System.EventHandler(this.btnDodajVilenjakaIgracke_Click);
            // 
            // vilenjaciigracke
            // 
            this.vilenjaciigracke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.vilenjaciigracke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.vilenjaciigracke.FullRowSelect = true;
            this.vilenjaciigracke.GridLines = true;
            this.vilenjaciigracke.HideSelection = false;
            this.vilenjaciigracke.Location = new System.Drawing.Point(26, 30);
            this.vilenjaciigracke.Name = "vilenjaciigracke";
            this.vilenjaciigracke.Size = new System.Drawing.Size(610, 326);
            this.vilenjaciigracke.TabIndex = 4;
            this.vilenjaciigracke.UseCompatibleStateImageBehavior = false;
            this.vilenjaciigracke.View = System.Windows.Forms.View.Details;
            this.vilenjaciigracke.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Specijalizovan za";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ocena";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.vilenjaciigracke);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 371);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vilenjaci za igracke";
            // 
            // VilenjaciIgrackeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(888, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVilenjakaIgracke);
            this.Controls.Add(this.btnObrisiVilenjakaIgracke);
            this.Name = "VilenjaciIgrackeForm";
            this.Text = "VILENJACI ZA IGRACKE";
            this.Load += new System.EventHandler(this.VilenjaciIgrackeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        #endregion
        private System.Windows.Forms.Button btnObrisiVilenjakaIgracke;
        private System.Windows.Forms.Button btnDodajVilenjakaIgracke;
        private System.Windows.Forms.ListView vilenjaciigracke;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
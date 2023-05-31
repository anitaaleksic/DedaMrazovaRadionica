namespace DedaMraz.Forme
{
    partial class VilenjaciPokloniForm
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
            this.btnObrisiVilenjakaPokloni = new System.Windows.Forms.Button();
            this.btnDodajVilenjakaPokloni = new System.Windows.Forms.Button();
            this.vilenjacipokloni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiVilenjakaPokloni
            // 
            this.btnObrisiVilenjakaPokloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisiVilenjakaPokloni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisiVilenjakaPokloni.FlatAppearance.BorderSize = 3;
            this.btnObrisiVilenjakaPokloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiVilenjakaPokloni.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisiVilenjakaPokloni.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisiVilenjakaPokloni.Location = new System.Drawing.Point(566, 278);
            this.btnObrisiVilenjakaPokloni.Name = "btnObrisiVilenjakaPokloni";
            this.btnObrisiVilenjakaPokloni.Size = new System.Drawing.Size(222, 91);
            this.btnObrisiVilenjakaPokloni.TabIndex = 1;
            this.btnObrisiVilenjakaPokloni.Text = "Obrisi vilenjaka";
            this.btnObrisiVilenjakaPokloni.UseVisualStyleBackColor = true;
            this.btnObrisiVilenjakaPokloni.Click += new System.EventHandler(this.btnObrisiVilenjakaPokloni_Click);
            // 
            // btnDodajVilenjakaPokloni
            // 
            this.btnDodajVilenjakaPokloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaPokloni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaPokloni.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaPokloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaPokloni.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaPokloni.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaPokloni.Location = new System.Drawing.Point(566, 43);
            this.btnDodajVilenjakaPokloni.Name = "btnDodajVilenjakaPokloni";
            this.btnDodajVilenjakaPokloni.Size = new System.Drawing.Size(222, 91);
            this.btnDodajVilenjakaPokloni.TabIndex = 2;
            this.btnDodajVilenjakaPokloni.Text = "Dodaj vilenjaka";
            this.btnDodajVilenjakaPokloni.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaPokloni.Click += new System.EventHandler(this.btnDodajVilenjakaPokloni_Click);
            // 
            // vilenjacipokloni
            // 
            this.vilenjacipokloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.vilenjacipokloni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.vilenjacipokloni.FullRowSelect = true;
            this.vilenjacipokloni.GridLines = true;
            this.vilenjacipokloni.HideSelection = false;
            this.vilenjacipokloni.Location = new System.Drawing.Point(18, 21);
            this.vilenjacipokloni.Name = "vilenjacipokloni";
            this.vilenjacipokloni.Size = new System.Drawing.Size(503, 326);
            this.vilenjacipokloni.TabIndex = 3;
            this.vilenjacipokloni.UseCompatibleStateImageBehavior = false;
            this.vilenjacipokloni.View = System.Windows.Forms.View.Details;
            this.vilenjacipokloni.SelectedIndexChanged += new System.EventHandler(this.vilenjacipokloni_SelectedIndexChanged);
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
            this.columnHeader4.Width = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.vilenjacipokloni);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 359);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vilenjaci za poklone";
            // 
            // VilenjaciPokloniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(798, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVilenjakaPokloni);
            this.Controls.Add(this.btnObrisiVilenjakaPokloni);
            this.Name = "VilenjaciPokloniForm";
            this.Text = "VILENJACI ZA POKLONE";
            this.Load += new System.EventHandler(this.VilenjaciPokloniForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisiVilenjakaPokloni;
        private System.Windows.Forms.Button btnDodajVilenjakaPokloni;
        private System.Windows.Forms.ListView vilenjacipokloni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
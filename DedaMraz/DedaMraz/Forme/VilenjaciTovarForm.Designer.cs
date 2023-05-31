namespace DedaMraz.Forme
{
    partial class VilenjaciTovarForm
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
            this.btnObrisiVilenjakaTovar = new System.Windows.Forms.Button();
            this.btnDodajVilenjakaTovar = new System.Windows.Forms.Button();
            this.vilenjacitovar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiVilenjakaTovar
            // 
            this.btnObrisiVilenjakaTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisiVilenjakaTovar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisiVilenjakaTovar.FlatAppearance.BorderSize = 3;
            this.btnObrisiVilenjakaTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiVilenjakaTovar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisiVilenjakaTovar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisiVilenjakaTovar.Location = new System.Drawing.Point(535, 279);
            this.btnObrisiVilenjakaTovar.Name = "btnObrisiVilenjakaTovar";
            this.btnObrisiVilenjakaTovar.Size = new System.Drawing.Size(228, 92);
            this.btnObrisiVilenjakaTovar.TabIndex = 1;
            this.btnObrisiVilenjakaTovar.Text = "Obrisi vilenjaka";
            this.btnObrisiVilenjakaTovar.UseVisualStyleBackColor = true;
            this.btnObrisiVilenjakaTovar.Click += new System.EventHandler(this.btnObrisiVilenjakaTovar_Click);
            // 
            // btnDodajVilenjakaTovar
            // 
            this.btnDodajVilenjakaTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaTovar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaTovar.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaTovar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaTovar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaTovar.Location = new System.Drawing.Point(535, 50);
            this.btnDodajVilenjakaTovar.Name = "btnDodajVilenjakaTovar";
            this.btnDodajVilenjakaTovar.Size = new System.Drawing.Size(228, 92);
            this.btnDodajVilenjakaTovar.TabIndex = 2;
            this.btnDodajVilenjakaTovar.Text = "Dodaj vilenjaka";
            this.btnDodajVilenjakaTovar.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaTovar.Click += new System.EventHandler(this.button1_Click);
            // 
            // vilenjacitovar
            // 
            this.vilenjacitovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.vilenjacitovar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.vilenjacitovar.FullRowSelect = true;
            this.vilenjacitovar.GridLines = true;
            this.vilenjacitovar.HideSelection = false;
            this.vilenjacitovar.LabelWrap = false;
            this.vilenjacitovar.Location = new System.Drawing.Point(19, 38);
            this.vilenjacitovar.Name = "vilenjacitovar";
            this.vilenjacitovar.Size = new System.Drawing.Size(461, 321);
            this.vilenjacitovar.TabIndex = 3;
            this.vilenjacitovar.UseCompatibleStateImageBehavior = false;
            this.vilenjacitovar.View = System.Windows.Forms.View.Details;
            this.vilenjacitovar.SelectedIndexChanged += new System.EventHandler(this.vilenjacitovar_SelectedIndexChanged);
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
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Radni staz";
            this.columnHeader4.Width = 121;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.vilenjacitovar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 370);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vilenjaci za tovar";
            // 
            // VilenjaciTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(767, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVilenjakaTovar);
            this.Controls.Add(this.btnObrisiVilenjakaTovar);
            this.Name = "VilenjaciTovarForm";
            this.Text = "VILENJACI ZA TOVAR";
            this.Load += new System.EventHandler(this.VilenjaciTovarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnObrisiVilenjakaTovar;
        private System.Windows.Forms.Button btnDodajVilenjakaTovar;
        private System.Windows.Forms.ListView vilenjacitovar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
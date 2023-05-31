namespace DedaMraz.Forme
{
    partial class PismoForm
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
            this.listViewPisma = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListaZelja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrikaziTekst = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPisma
            // 
            this.listViewPisma.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPisma.AllowDrop = true;
            this.listViewPisma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.listViewPisma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewPisma.FullRowSelect = true;
            this.listViewPisma.GridLines = true;
            this.listViewPisma.HideSelection = false;
            this.listViewPisma.LabelWrap = false;
            this.listViewPisma.Location = new System.Drawing.Point(23, 33);
            this.listViewPisma.Name = "listViewPisma";
            this.listViewPisma.Size = new System.Drawing.Size(390, 293);
            this.listViewPisma.TabIndex = 1;
            this.listViewPisma.UseCompatibleStateImageBehavior = false;
            this.listViewPisma.View = System.Windows.Forms.View.Details;
            this.listViewPisma.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum slanja";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum prijema";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Indeks dobrote";
            // 
            // btnListaZelja
            // 
            this.btnListaZelja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnListaZelja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnListaZelja.FlatAppearance.BorderSize = 3;
            this.btnListaZelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaZelja.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnListaZelja.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnListaZelja.Location = new System.Drawing.Point(27, 375);
            this.btnListaZelja.Name = "btnListaZelja";
            this.btnListaZelja.Size = new System.Drawing.Size(741, 66);
            this.btnListaZelja.TabIndex = 2;
            this.btnListaZelja.Text = "Lista zelja";
            this.btnListaZelja.UseVisualStyleBackColor = true;
            this.btnListaZelja.Click += new System.EventHandler(this.btnListaZelja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.btnPrikaziTekst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listViewPisma);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 348);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pisma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tekst pisma";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.textBox1.Location = new System.Drawing.Point(456, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 157);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // btnPrikaziTekst
            // 
            this.btnPrikaziTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPrikaziTekst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPrikaziTekst.FlatAppearance.BorderSize = 3;
            this.btnPrikaziTekst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziTekst.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziTekst.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPrikaziTekst.Location = new System.Drawing.Point(456, 258);
            this.btnPrikaziTekst.Name = "btnPrikaziTekst";
            this.btnPrikaziTekst.Size = new System.Drawing.Size(244, 58);
            this.btnPrikaziTekst.TabIndex = 4;
            this.btnPrikaziTekst.Text = "Prikazi tekst";
            this.btnPrikaziTekst.UseVisualStyleBackColor = true;
            this.btnPrikaziTekst.Click += new System.EventHandler(this.btnPrikaziTekst_Click);
            // 
            // PismoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListaZelja);
            this.Name = "PismoForm";
            this.Text = "PISMA";
            this.Load += new System.EventHandler(this.PismoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewPisma;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnListaZelja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrikaziTekst;
    }
}
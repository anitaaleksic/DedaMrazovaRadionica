namespace DedaMraz.Forme
{
    partial class PesmeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPesme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPesma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnPrikaziTekst = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.listViewPesme);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesme";
            // 
            // listViewPesme
            // 
            this.listViewPesme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.listViewPesme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPesme.FullRowSelect = true;
            this.listViewPesme.GridLines = true;
            this.listViewPesme.HideSelection = false;
            this.listViewPesme.Location = new System.Drawing.Point(17, 33);
            this.listViewPesme.Name = "listViewPesme";
            this.listViewPesme.Size = new System.Drawing.Size(171, 336);
            this.listViewPesme.TabIndex = 0;
            this.listViewPesme.UseCompatibleStateImageBehavior = false;
            this.listViewPesme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            // 
            // btnPesma
            // 
            this.btnPesma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPesma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPesma.FlatAppearance.BorderSize = 3;
            this.btnPesma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesma.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPesma.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPesma.Location = new System.Drawing.Point(22, 448);
            this.btnPesma.Name = "btnPesma";
            this.btnPesma.Size = new System.Drawing.Size(538, 64);
            this.btnPesma.TabIndex = 3;
            this.btnPesma.Text = "Dodaj pesmu";
            this.btnPesma.UseVisualStyleBackColor = true;
            this.btnPesma.Click += new System.EventHandler(this.btnPesma_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.textBox1.Location = new System.Drawing.Point(264, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 249);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(261, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tekst pesme:";
            // 
            // btnPrikaziTekst
            // 
            this.btnPrikaziTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPrikaziTekst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPrikaziTekst.FlatAppearance.BorderSize = 3;
            this.btnPrikaziTekst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziTekst.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPrikaziTekst.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPrikaziTekst.Location = new System.Drawing.Point(264, 332);
            this.btnPrikaziTekst.Name = "btnPrikaziTekst";
            this.btnPrikaziTekst.Size = new System.Drawing.Size(296, 86);
            this.btnPrikaziTekst.TabIndex = 5;
            this.btnPrikaziTekst.Text = "Prikazi tekst";
            this.btnPrikaziTekst.UseVisualStyleBackColor = true;
            this.btnPrikaziTekst.Click += new System.EventHandler(this.btnPrikaziTekst_Click);
            // 
            // PesmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(597, 524);
            this.Controls.Add(this.btnPrikaziTekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesma);
            this.Controls.Add(this.groupBox1);
            this.Name = "PesmeForm";
            this.Text = "PESME";
            this.Load += new System.EventHandler(this.PesmeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listViewPesme;
        private System.Windows.Forms.Button btnPesma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnPrikaziTekst;
    }
}
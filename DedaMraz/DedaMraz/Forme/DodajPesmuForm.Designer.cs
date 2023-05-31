namespace DedaMraz.Forme
{
    partial class DodajPesmuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTekstPesme = new System.Windows.Forms.TextBox();
            this.btnPesma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNazivPesme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tekst pesme:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTekstPesme
            // 
            this.textBoxTekstPesme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.textBoxTekstPesme.Location = new System.Drawing.Point(40, 127);
            this.textBoxTekstPesme.Multiline = true;
            this.textBoxTekstPesme.Name = "textBoxTekstPesme";
            this.textBoxTekstPesme.Size = new System.Drawing.Size(296, 249);
            this.textBoxTekstPesme.TabIndex = 5;
            // 
            // btnPesma
            // 
            this.btnPesma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPesma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPesma.FlatAppearance.BorderSize = 3;
            this.btnPesma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesma.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPesma.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPesma.Location = new System.Drawing.Point(66, 426);
            this.btnPesma.Name = "btnPesma";
            this.btnPesma.Size = new System.Drawing.Size(296, 64);
            this.btnPesma.TabIndex = 7;
            this.btnPesma.Text = "Dodaj";
            this.btnPesma.UseVisualStyleBackColor = true;
            this.btnPesma.Click += new System.EventHandler(this.btnPesma_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.textBoxNazivPesme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTekstPesme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesma";
            // 
            // textBoxNazivPesme
            // 
            this.textBoxNazivPesme.Location = new System.Drawing.Point(132, 41);
            this.textBoxNazivPesme.Name = "textBoxNazivPesme";
            this.textBoxNazivPesme.Size = new System.Drawing.Size(204, 22);
            this.textBoxNazivPesme.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv";
            // 
            // DodajPesmuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(430, 523);
            this.Controls.Add(this.btnPesma);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "DodajPesmuForm";
            this.Text = "DODAJ PESMU";
            this.Load += new System.EventHandler(this.DodajPesmuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTekstPesme;
        private System.Windows.Forms.Button btnPesma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNazivPesme;
        private System.Windows.Forms.Label label2;
    }
}
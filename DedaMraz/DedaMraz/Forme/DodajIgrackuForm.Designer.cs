namespace DedaMraz.Forme
{
    partial class DodajIgrackuForm
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
            this.numRedniBroj = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.btnDodajPoklon = new System.Windows.Forms.Button();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.comboBoxSifraPoklona = new System.Windows.Forms.ComboBox();
            this.comboBoxIzradio = new System.Windows.Forms.ComboBox();
            this.comboBoxZelja = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNapraviIgracku = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedniBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.numRedniBroj);
            this.groupBox1.Controls.Add(this.comboBoxTip);
            this.groupBox1.Controls.Add(this.btnDodajPoklon);
            this.groupBox1.Controls.Add(this.textBoxOpis);
            this.groupBox1.Controls.Add(this.comboBoxSifraPoklona);
            this.groupBox1.Controls.Add(this.comboBoxIzradio);
            this.groupBox1.Controls.Add(this.comboBoxZelja);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igracka";
            // 
            // numRedniBroj
            // 
            this.numRedniBroj.Location = new System.Drawing.Point(459, 119);
            this.numRedniBroj.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRedniBroj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRedniBroj.Name = "numRedniBroj";
            this.numRedniBroj.Size = new System.Drawing.Size(157, 22);
            this.numRedniBroj.TabIndex = 14;
            this.numRedniBroj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(459, 58);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(157, 24);
            this.comboBoxTip.TabIndex = 13;
            // 
            // btnDodajPoklon
            // 
            this.btnDodajPoklon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajPoklon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajPoklon.FlatAppearance.BorderSize = 3;
            this.btnDodajPoklon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPoklon.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPoklon.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajPoklon.Location = new System.Drawing.Point(22, 240);
            this.btnDodajPoklon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajPoklon.Name = "btnDodajPoklon";
            this.btnDodajPoklon.Size = new System.Drawing.Size(284, 59);
            this.btnDodajPoklon.TabIndex = 12;
            this.btnDodajPoklon.Text = "Dodaj poklon";
            this.btnDodajPoklon.UseVisualStyleBackColor = false;
            this.btnDodajPoklon.Click += new System.EventHandler(this.btnDodajPoklon_Click);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(459, 179);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(157, 120);
            this.textBoxOpis.TabIndex = 11;
            // 
            // comboBoxSifraPoklona
            // 
            this.comboBoxSifraPoklona.FormattingEnabled = true;
            this.comboBoxSifraPoklona.Location = new System.Drawing.Point(149, 179);
            this.comboBoxSifraPoklona.Name = "comboBoxSifraPoklona";
            this.comboBoxSifraPoklona.Size = new System.Drawing.Size(157, 24);
            this.comboBoxSifraPoklona.TabIndex = 8;
            // 
            // comboBoxIzradio
            // 
            this.comboBoxIzradio.FormattingEnabled = true;
            this.comboBoxIzradio.Location = new System.Drawing.Point(149, 121);
            this.comboBoxIzradio.Name = "comboBoxIzradio";
            this.comboBoxIzradio.Size = new System.Drawing.Size(157, 24);
            this.comboBoxIzradio.TabIndex = 7;
            // 
            // comboBoxZelja
            // 
            this.comboBoxZelja.FormattingEnabled = true;
            this.comboBoxZelja.Location = new System.Drawing.Point(149, 58);
            this.comboBoxZelja.Name = "comboBoxZelja";
            this.comboBoxZelja.Size = new System.Drawing.Size(157, 24);
            this.comboBoxZelja.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Redni broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifra poklona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izradio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Po zelji:";
            // 
            // btnNapraviIgracku
            // 
            this.btnNapraviIgracku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnNapraviIgracku.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnNapraviIgracku.FlatAppearance.BorderSize = 3;
            this.btnNapraviIgracku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNapraviIgracku.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviIgracku.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnNapraviIgracku.Location = new System.Drawing.Point(36, 375);
            this.btnNapraviIgracku.Margin = new System.Windows.Forms.Padding(4);
            this.btnNapraviIgracku.Name = "btnNapraviIgracku";
            this.btnNapraviIgracku.Size = new System.Drawing.Size(656, 70);
            this.btnNapraviIgracku.TabIndex = 5;
            this.btnNapraviIgracku.Text = "Napravi igracku";
            this.btnNapraviIgracku.UseVisualStyleBackColor = false;
            this.btnNapraviIgracku.Click += new System.EventHandler(this.btnNapraviIgracku_Click);
            // 
            // DodajIgrackuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(744, 460);
            this.Controls.Add(this.btnNapraviIgracku);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajIgrackuForm";
            this.Text = "DODAJ IGRACKU";
            this.Load += new System.EventHandler(this.DodajIgrackuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedniBroj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.ComboBox comboBoxSifraPoklona;
        private System.Windows.Forms.ComboBox comboBoxIzradio;
        private System.Windows.Forms.ComboBox comboBoxZelja;
        private System.Windows.Forms.Button btnDodajPoklon;
        private System.Windows.Forms.Button btnNapraviIgracku;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.NumericUpDown numRedniBroj;
    }
}
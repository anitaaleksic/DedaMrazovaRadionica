namespace DedaMraz.Forme
{
    partial class DodajTimForm
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
            this.comboKoor = new System.Windows.Forms.ComboBox();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnDodajKoordinatora = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koordinator";
            // 
            // comboKoor
            // 
            this.comboKoor.FormattingEnabled = true;
            this.comboKoor.Location = new System.Drawing.Point(99, 21);
            this.comboKoor.Name = "comboKoor";
            this.comboKoor.Size = new System.Drawing.Size(238, 24);
            this.comboKoor.TabIndex = 1;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajTim.FlatAppearance.BorderSize = 3;
            this.btnDodajTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajTim.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajTim.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajTim.Location = new System.Drawing.Point(376, 44);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(170, 145);
            this.btnDodajTim.TabIndex = 3;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // btnDodajKoordinatora
            // 
            this.btnDodajKoordinatora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajKoordinatora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajKoordinatora.FlatAppearance.BorderSize = 3;
            this.btnDodajKoordinatora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKoordinatora.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajKoordinatora.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajKoordinatora.Location = new System.Drawing.Point(74, 88);
            this.btnDodajKoordinatora.Name = "btnDodajKoordinatora";
            this.btnDodajKoordinatora.Size = new System.Drawing.Size(263, 89);
            this.btnDodajKoordinatora.TabIndex = 4;
            this.btnDodajKoordinatora.Text = "Dodaj koordinatora";
            this.btnDodajKoordinatora.UseVisualStyleBackColor = true;
            this.btnDodajKoordinatora.Click += new System.EventHandler(this.btnDodajKoordinatora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDodajKoordinatora);
            this.groupBox1.Controls.Add(this.comboKoor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koordinator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "(samo vilenjaci koji vec nisu koordinatori;\r\n           dodajte vilenjaka po potr" +
    "ebi)";
            // 
            // DodajTimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(558, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajTim);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "DodajTimForm";
            this.Text = "DODAJ TIM";
            this.Load += new System.EventHandler(this.DodajTimForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKoor;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnDodajKoordinatora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}
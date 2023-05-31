
namespace DedaMraz.Forme
{
    partial class DodajVilenjakaPoklonForm
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxZemljaPorekla = new System.Windows.Forms.TextBox();
            this.textBoxRadniStaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajVilenjakaPoklon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(175, 37);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(202, 22);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBoxZemljaPorekla
            // 
            this.textBoxZemljaPorekla.Location = new System.Drawing.Point(175, 111);
            this.textBoxZemljaPorekla.Name = "textBoxZemljaPorekla";
            this.textBoxZemljaPorekla.Size = new System.Drawing.Size(202, 22);
            this.textBoxZemljaPorekla.TabIndex = 1;
            // 
            // textBoxRadniStaz
            // 
            this.textBoxRadniStaz.Location = new System.Drawing.Point(175, 182);
            this.textBoxRadniStaz.Name = "textBoxRadniStaz";
            this.textBoxRadniStaz.Size = new System.Drawing.Size(202, 22);
            this.textBoxRadniStaz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zemlja porekla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radni staz";
            // 
            // btnDodajVilenjakaPoklon
            // 
            this.btnDodajVilenjakaPoklon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaPoklon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaPoklon.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaPoklon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaPoklon.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaPoklon.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaPoklon.Location = new System.Drawing.Point(12, 261);
            this.btnDodajVilenjakaPoklon.Name = "btnDodajVilenjakaPoklon";
            this.btnDodajVilenjakaPoklon.Size = new System.Drawing.Size(401, 77);
            this.btnDodajVilenjakaPoklon.TabIndex = 6;
            this.btnDodajVilenjakaPoklon.Text = "Dodaj";
            this.btnDodajVilenjakaPoklon.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaPoklon.Click += new System.EventHandler(this.btnDodajVilenjakaPoklon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.textBoxRadniStaz);
            this.groupBox1.Controls.Add(this.textBoxIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxZemljaPorekla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // DodajVilenjakaPoklonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(439, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVilenjakaPoklon);
            this.Name = "DodajVilenjakaPoklonForm";
            this.Text = "DODAJ VILENJAKA ZA POKLONE";
            this.Load += new System.EventHandler(this.DodajVilenjakaPoklonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxZemljaPorekla;
        private System.Windows.Forms.TextBox textBoxRadniStaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajVilenjakaPoklon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
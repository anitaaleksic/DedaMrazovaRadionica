
namespace DedaMraz.Forme
{
    partial class DodajVilenjakaIrvasForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZemljaPorekla = new System.Windows.Forms.TextBox();
            this.textBoxRadniStaz = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboIrvas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zemlja porekla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(79, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radni staz";
            // 
            // textBoxZemljaPorekla
            // 
            this.textBoxZemljaPorekla.Location = new System.Drawing.Point(188, 102);
            this.textBoxZemljaPorekla.Name = "textBoxZemljaPorekla";
            this.textBoxZemljaPorekla.Size = new System.Drawing.Size(168, 22);
            this.textBoxZemljaPorekla.TabIndex = 4;
            // 
            // textBoxRadniStaz
            // 
            this.textBoxRadniStaz.Location = new System.Drawing.Point(188, 178);
            this.textBoxRadniStaz.Name = "textBoxRadniStaz";
            this.textBoxRadniStaz.Size = new System.Drawing.Size(168, 22);
            this.textBoxRadniStaz.TabIndex = 5;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(188, 35);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(168, 22);
            this.textBoxIme.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(16, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zaduzen za irvasa:";
            // 
            // comboIrvas
            // 
            this.comboIrvas.FormattingEnabled = true;
            this.comboIrvas.Location = new System.Drawing.Point(191, 251);
            this.comboIrvas.Name = "comboIrvas";
            this.comboIrvas.Size = new System.Drawing.Size(165, 24);
            this.comboIrvas.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.comboIrvas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIme);
            this.groupBox1.Controls.Add(this.textBoxRadniStaz);
            this.groupBox1.Controls.Add(this.textBoxZemljaPorekla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 302);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // DodajVilenjakaIrvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(406, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "DodajVilenjakaIrvasForm";
            this.Text = "DODAJ VILENJAKA ZA IRVASE";
            this.Load += new System.EventHandler(this.DodajVilenjakaIrvasForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZemljaPorekla;
        private System.Windows.Forms.TextBox textBoxRadniStaz;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboIrvas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
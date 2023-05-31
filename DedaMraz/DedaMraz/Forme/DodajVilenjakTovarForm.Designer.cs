
namespace DedaMraz.Forme
{
    partial class DodajVilenjakTovarForm
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
            this.textboxIme = new System.Windows.Forms.TextBox();
            this.textboxZemljaPorekla = new System.Windows.Forms.TextBox();
            this.textboxRadnistaz = new System.Windows.Forms.TextBox();
            this.btnDodajVilenjakaTovar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combotovar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zemlja porekla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radni staz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxIme
            // 
            this.textboxIme.Location = new System.Drawing.Point(177, 44);
            this.textboxIme.Name = "textboxIme";
            this.textboxIme.Size = new System.Drawing.Size(178, 22);
            this.textboxIme.TabIndex = 3;
            // 
            // textboxZemljaPorekla
            // 
            this.textboxZemljaPorekla.Location = new System.Drawing.Point(177, 119);
            this.textboxZemljaPorekla.Name = "textboxZemljaPorekla";
            this.textboxZemljaPorekla.Size = new System.Drawing.Size(178, 22);
            this.textboxZemljaPorekla.TabIndex = 4;
            // 
            // textboxRadnistaz
            // 
            this.textboxRadnistaz.Location = new System.Drawing.Point(177, 194);
            this.textboxRadnistaz.Name = "textboxRadnistaz";
            this.textboxRadnistaz.Size = new System.Drawing.Size(178, 22);
            this.textboxRadnistaz.TabIndex = 5;
            // 
            // btnDodajVilenjakaTovar
            // 
            this.btnDodajVilenjakaTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajVilenjakaTovar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajVilenjakaTovar.FlatAppearance.BorderSize = 3;
            this.btnDodajVilenjakaTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVilenjakaTovar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajVilenjakaTovar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajVilenjakaTovar.Location = new System.Drawing.Point(12, 343);
            this.btnDodajVilenjakaTovar.Name = "btnDodajVilenjakaTovar";
            this.btnDodajVilenjakaTovar.Size = new System.Drawing.Size(368, 65);
            this.btnDodajVilenjakaTovar.TabIndex = 6;
            this.btnDodajVilenjakaTovar.Text = "Dodaj";
            this.btnDodajVilenjakaTovar.UseVisualStyleBackColor = true;
            this.btnDodajVilenjakaTovar.Click += new System.EventHandler(this.btnDodajVilenjakaTovar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zaduzen za tovar:";
            // 
            // combotovar
            // 
            this.combotovar.FormattingEnabled = true;
            this.combotovar.Location = new System.Drawing.Point(177, 265);
            this.combotovar.Name = "combotovar";
            this.combotovar.Size = new System.Drawing.Size(175, 24);
            this.combotovar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.combotovar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textboxRadnistaz);
            this.groupBox1.Controls.Add(this.textboxIme);
            this.groupBox1.Controls.Add(this.textboxZemljaPorekla);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // DodajVilenjakTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajVilenjakaTovar);
            this.Name = "DodajVilenjakTovarForm";
            this.Text = "DODAJ VILENJAKA ZA TOVAR";
            this.Load += new System.EventHandler(this.DodajVilenjakTovarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxIme;
        private System.Windows.Forms.TextBox textboxZemljaPorekla;
        private System.Windows.Forms.TextBox textboxRadnistaz;
        private System.Windows.Forms.Button btnDodajVilenjakaTovar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combotovar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
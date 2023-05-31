namespace DedaMraz.Forme
{
    partial class DodajPoklonForm
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
            this.textboxPosveta = new System.Windows.Forms.TextBox();
            this.textboxBoja = new System.Windows.Forms.TextBox();
            this.comboTovar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpakujPoklon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboVilenjak = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.comboVilenjak);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textboxPosveta);
            this.groupBox1.Controls.Add(this.textboxBoja);
            this.groupBox1.Controls.Add(this.comboTovar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paketic";
            // 
            // textboxPosveta
            // 
            this.textboxPosveta.Location = new System.Drawing.Point(122, 120);
            this.textboxPosveta.Name = "textboxPosveta";
            this.textboxPosveta.Size = new System.Drawing.Size(150, 22);
            this.textboxPosveta.TabIndex = 5;
            // 
            // textboxBoja
            // 
            this.textboxBoja.Location = new System.Drawing.Point(122, 56);
            this.textboxBoja.Name = "textboxBoja";
            this.textboxBoja.Size = new System.Drawing.Size(150, 22);
            this.textboxBoja.TabIndex = 4;
            this.textboxBoja.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboTovar
            // 
            this.comboTovar.FormattingEnabled = true;
            this.comboTovar.Location = new System.Drawing.Point(122, 180);
            this.comboTovar.Name = "comboTovar";
            this.comboTovar.Size = new System.Drawing.Size(150, 24);
            this.comboTovar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tovar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posveta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boja";
            // 
            // btnSpakujPoklon
            // 
            this.btnSpakujPoklon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnSpakujPoklon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnSpakujPoklon.FlatAppearance.BorderSize = 3;
            this.btnSpakujPoklon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpakujPoklon.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpakujPoklon.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnSpakujPoklon.Location = new System.Drawing.Point(43, 338);
            this.btnSpakujPoklon.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpakujPoklon.Name = "btnSpakujPoklon";
            this.btnSpakujPoklon.Size = new System.Drawing.Size(303, 70);
            this.btnSpakujPoklon.TabIndex = 4;
            this.btnSpakujPoklon.Text = "Spakuj poklon";
            this.btnSpakujPoklon.UseVisualStyleBackColor = false;
            this.btnSpakujPoklon.Click += new System.EventHandler(this.btnSpakujPoklon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spakovao\r\n   vilenjak";
            // 
            // comboVilenjak
            // 
            this.comboVilenjak.FormattingEnabled = true;
            this.comboVilenjak.Location = new System.Drawing.Point(122, 246);
            this.comboVilenjak.Name = "comboVilenjak";
            this.comboVilenjak.Size = new System.Drawing.Size(150, 24);
            this.comboVilenjak.TabIndex = 7;
            // 
            // DodajPoklonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.btnSpakujPoklon);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajPoklonForm";
            this.Text = "SPAKUJ POKLON";
            this.Load += new System.EventHandler(this.SpakujPoklonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPosveta;
        private System.Windows.Forms.TextBox textboxBoja;
        private System.Windows.Forms.ComboBox comboTovar;
        private System.Windows.Forms.Button btnSpakujPoklon;
        private System.Windows.Forms.ComboBox comboVilenjak;
        private System.Windows.Forms.Label label4;
    }
}
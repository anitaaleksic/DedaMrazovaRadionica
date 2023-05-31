namespace DedaMraz.Forme
{
    partial class DodajZeljuForm
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
            this.textboxZelja1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajZelju = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxZelja1
            // 
            this.textboxZelja1.Location = new System.Drawing.Point(28, 64);
            this.textboxZelja1.Name = "textboxZelja1";
            this.textboxZelja1.Size = new System.Drawing.Size(238, 22);
            this.textboxZelja1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox2.Controls.Add(this.textboxZelja1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 125);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zelja";
            // 
            // btnDodajZelju
            // 
            this.btnDodajZelju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajZelju.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajZelju.FlatAppearance.BorderSize = 3;
            this.btnDodajZelju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZelju.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZelju.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajZelju.Location = new System.Drawing.Point(361, 55);
            this.btnDodajZelju.Name = "btnDodajZelju";
            this.btnDodajZelju.Size = new System.Drawing.Size(219, 53);
            this.btnDodajZelju.TabIndex = 22;
            this.btnDodajZelju.Text = "Dodaj zelju";
            this.btnDodajZelju.UseVisualStyleBackColor = true;
            this.btnDodajZelju.Click += new System.EventHandler(this.btnDodajZelju_Click);
            // 
            // DodajZeljuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(605, 196);
            this.Controls.Add(this.btnDodajZelju);
            this.Controls.Add(this.groupBox2);
            this.Name = "DodajZeljuForm";
            this.Text = "DODAJ ZELJU";
            this.Load += new System.EventHandler(this.DodajZeljuForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textboxZelja1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajZelju;
    }
}
namespace DedaMraz.Forme
{
    partial class DodajTovarForm
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
            this.btnPosaljiTovar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxGrad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosaljiTovar
            // 
            this.btnPosaljiTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPosaljiTovar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPosaljiTovar.FlatAppearance.BorderSize = 3;
            this.btnPosaljiTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosaljiTovar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosaljiTovar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPosaljiTovar.Location = new System.Drawing.Point(37, 123);
            this.btnPosaljiTovar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosaljiTovar.Name = "btnPosaljiTovar";
            this.btnPosaljiTovar.Size = new System.Drawing.Size(303, 70);
            this.btnPosaljiTovar.TabIndex = 6;
            this.btnPosaljiTovar.Text = "Posalji tovar";
            this.btnPosaljiTovar.UseVisualStyleBackColor = false;
            this.btnPosaljiTovar.Click += new System.EventHandler(this.btnPosaljiTovar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grad";
            // 
            // textboxGrad
            // 
            this.textboxGrad.Location = new System.Drawing.Point(109, 42);
            this.textboxGrad.Name = "textboxGrad";
            this.textboxGrad.Size = new System.Drawing.Size(201, 22);
            this.textboxGrad.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textboxGrad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 96);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tovar";
            // 
            // DodajTovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(395, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPosaljiTovar);
            this.Name = "DodajTovarForm";
            this.Text = "DODAJ TOVAR";
            this.Load += new System.EventHandler(this.PosaljiTovarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPosaljiTovar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxGrad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
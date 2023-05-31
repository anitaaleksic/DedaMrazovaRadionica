namespace DedaMraz.Forme
{
    partial class DodajPismoForm
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
            this.dateTimeDatumSlanja = new System.Windows.Forms.DateTimePicker();
            this.datetimeDatumPrijema = new System.Windows.Forms.DateTimePicker();
            this.numIndeksDobrote = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDete = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajDete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNapraviListuZelja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIndeksDobrote)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeDatumSlanja
            // 
            this.dateTimeDatumSlanja.Location = new System.Drawing.Point(171, 282);
            this.dateTimeDatumSlanja.Name = "dateTimeDatumSlanja";
            this.dateTimeDatumSlanja.Size = new System.Drawing.Size(331, 22);
            this.dateTimeDatumSlanja.TabIndex = 9;
            // 
            // datetimeDatumPrijema
            // 
            this.datetimeDatumPrijema.Location = new System.Drawing.Point(171, 322);
            this.datetimeDatumPrijema.Name = "datetimeDatumPrijema";
            this.datetimeDatumPrijema.Size = new System.Drawing.Size(331, 22);
            this.datetimeDatumPrijema.TabIndex = 10;
            // 
            // numIndeksDobrote
            // 
            this.numIndeksDobrote.DecimalPlaces = 1;
            this.numIndeksDobrote.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numIndeksDobrote.Location = new System.Drawing.Point(171, 230);
            this.numIndeksDobrote.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIndeksDobrote.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndeksDobrote.Name = "numIndeksDobrote";
            this.numIndeksDobrote.Size = new System.Drawing.Size(114, 22);
            this.numIndeksDobrote.TabIndex = 11;
            this.numIndeksDobrote.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tekst pisma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum slanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Datum prijema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Indeks dobrote";
            // 
            // comboDete
            // 
            this.comboDete.FormattingEnabled = true;
            this.comboDete.Location = new System.Drawing.Point(40, 65);
            this.comboDete.Name = "comboDete";
            this.comboDete.Size = new System.Drawing.Size(219, 24);
            this.comboDete.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(37, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pismo salje:";
            // 
            // btnDodajDete
            // 
            this.btnDodajDete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajDete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajDete.FlatAppearance.BorderSize = 3;
            this.btnDodajDete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDete.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDete.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajDete.Location = new System.Drawing.Point(40, 135);
            this.btnDodajDete.Name = "btnDodajDete";
            this.btnDodajDete.Size = new System.Drawing.Size(219, 53);
            this.btnDodajDete.TabIndex = 22;
            this.btnDodajDete.Text = "Dodaj dete";
            this.btnDodajDete.UseVisualStyleBackColor = true;
            this.btnDodajDete.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimeDatumSlanja);
            this.groupBox1.Controls.Add(this.datetimeDatumPrijema);
            this.groupBox1.Controls.Add(this.numIndeksDobrote);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 380);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.textBox1.Location = new System.Drawing.Point(46, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 141);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox2.Controls.Add(this.btnDodajDete);
            this.groupBox2.Controls.Add(this.comboDete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(549, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 215);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dete";
            // 
            // btnNapraviListuZelja
            // 
            this.btnNapraviListuZelja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnNapraviListuZelja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnNapraviListuZelja.FlatAppearance.BorderSize = 3;
            this.btnNapraviListuZelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNapraviListuZelja.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapraviListuZelja.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnNapraviListuZelja.Location = new System.Drawing.Point(589, 257);
            this.btnNapraviListuZelja.Name = "btnNapraviListuZelja";
            this.btnNapraviListuZelja.Size = new System.Drawing.Size(219, 115);
            this.btnNapraviListuZelja.TabIndex = 25;
            this.btnNapraviListuZelja.Text = "Napravi listu zelja";
            this.btnNapraviListuZelja.UseVisualStyleBackColor = true;
            this.btnNapraviListuZelja.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PosaljiPismoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(888, 413);
            this.Controls.Add(this.btnNapraviListuZelja);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PosaljiPismoForm";
            this.Text = "POSALJI PISMO";
            this.Load += new System.EventHandler(this.PosaljiPismoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIndeksDobrote)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeDatumSlanja;
        private System.Windows.Forms.DateTimePicker datetimeDatumPrijema;
        private System.Windows.Forms.NumericUpDown numIndeksDobrote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajDete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNapraviListuZelja;
    }
}
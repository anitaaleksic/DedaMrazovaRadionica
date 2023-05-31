namespace DedaMraz.Forme
{
    partial class PokloniForm
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
            this.pokloni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMagicneVestine = new System.Windows.Forms.GroupBox();
            this.groupBoxMagicneVestine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokloni
            // 
            this.pokloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.pokloni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.pokloni.FullRowSelect = true;
            this.pokloni.GridLines = true;
            this.pokloni.HideSelection = false;
            this.pokloni.Location = new System.Drawing.Point(34, 34);
            this.pokloni.Name = "pokloni";
            this.pokloni.Size = new System.Drawing.Size(322, 265);
            this.pokloni.TabIndex = 3;
            this.pokloni.UseCompatibleStateImageBehavior = false;
            this.pokloni.View = System.Windows.Forms.View.Details;
            this.pokloni.SelectedIndexChanged += new System.EventHandler(this.pokloni_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Boja";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Posveta";
            // 
            // groupBoxMagicneVestine
            // 
            this.groupBoxMagicneVestine.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxMagicneVestine.Controls.Add(this.pokloni);
            this.groupBoxMagicneVestine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxMagicneVestine.Location = new System.Drawing.Point(29, 21);
            this.groupBoxMagicneVestine.Name = "groupBoxMagicneVestine";
            this.groupBoxMagicneVestine.Size = new System.Drawing.Size(390, 318);
            this.groupBoxMagicneVestine.TabIndex = 4;
            this.groupBoxMagicneVestine.TabStop = false;
            this.groupBoxMagicneVestine.Text = "Pokloni";
            // 
            // PokloniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(507, 351);
            this.Controls.Add(this.groupBoxMagicneVestine);
            this.Name = "PokloniForm";
            this.Text = "POKLONI";
            this.Load += new System.EventHandler(this.PokloniForm_Load_1);
            this.groupBoxMagicneVestine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView pokloni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBoxMagicneVestine;
    }
}
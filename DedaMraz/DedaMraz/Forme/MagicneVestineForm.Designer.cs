namespace DedaMraz.Forme
{
    partial class MagicneVestineForm
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
            this.groupBoxMagicneVestine = new System.Windows.Forms.GroupBox();
            this.listViewMagicneVestine = new System.Windows.Forms.ListView();
            this.btnDodajMagicnuVestinu = new System.Windows.Forms.Button();
            this.groupBoxMagicneVestine.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMagicneVestine
            // 
            this.groupBoxMagicneVestine.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxMagicneVestine.Controls.Add(this.listViewMagicneVestine);
            this.groupBoxMagicneVestine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxMagicneVestine.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMagicneVestine.Name = "groupBoxMagicneVestine";
            this.groupBoxMagicneVestine.Size = new System.Drawing.Size(247, 279);
            this.groupBoxMagicneVestine.TabIndex = 0;
            this.groupBoxMagicneVestine.TabStop = false;
            this.groupBoxMagicneVestine.Text = "Magicne vestine";
            this.groupBoxMagicneVestine.Enter += new System.EventHandler(this.groupBoxMagicneVestine_Enter);
            // 
            // listViewMagicneVestine
            // 
            this.listViewMagicneVestine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.listViewMagicneVestine.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewMagicneVestine.FullRowSelect = true;
            this.listViewMagicneVestine.GridLines = true;
            this.listViewMagicneVestine.HideSelection = false;
            this.listViewMagicneVestine.Location = new System.Drawing.Point(16, 39);
            this.listViewMagicneVestine.Name = "listViewMagicneVestine";
            this.listViewMagicneVestine.Size = new System.Drawing.Size(208, 213);
            this.listViewMagicneVestine.TabIndex = 4;
            this.listViewMagicneVestine.UseCompatibleStateImageBehavior = false;
            this.listViewMagicneVestine.View = System.Windows.Forms.View.Details;
            this.listViewMagicneVestine.SelectedIndexChanged += new System.EventHandler(this.listViewMagicneVestine_SelectedIndexChanged);
            // 
            // btnDodajMagicnuVestinu
            // 
            this.btnDodajMagicnuVestinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajMagicnuVestinu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajMagicnuVestinu.FlatAppearance.BorderSize = 3;
            this.btnDodajMagicnuVestinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajMagicnuVestinu.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajMagicnuVestinu.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajMagicnuVestinu.Location = new System.Drawing.Point(12, 314);
            this.btnDodajMagicnuVestinu.Name = "btnDodajMagicnuVestinu";
            this.btnDodajMagicnuVestinu.Size = new System.Drawing.Size(247, 138);
            this.btnDodajMagicnuVestinu.TabIndex = 4;
            this.btnDodajMagicnuVestinu.Text = "Dodaj magicnu vestinu";
            this.btnDodajMagicnuVestinu.UseVisualStyleBackColor = true;
            this.btnDodajMagicnuVestinu.Click += new System.EventHandler(this.btnDodajMagicnuVestinu_Click);
            // 
            // MagicneVestineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(324, 464);
            this.Controls.Add(this.btnDodajMagicnuVestinu);
            this.Controls.Add(this.groupBoxMagicneVestine);
            this.Name = "MagicneVestineForm";
            this.Text = "MAGICNE VESTINE";
            this.Load += new System.EventHandler(this.MagicneVestineForm_Load);
            this.groupBoxMagicneVestine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMagicneVestine;
        private System.Windows.Forms.ListView listViewMagicneVestine;
        private System.Windows.Forms.Button btnDodajMagicnuVestinu;
    }
}

namespace DedaMraz.Forme
{
    partial class ListaZeljaForm
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
            this.listazelja = new System.Windows.Forms.ListView();
            this.btnIgracka = new System.Windows.Forms.Button();
            this.btnPoklon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listazelja
            // 
            this.listazelja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.listazelja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listazelja.FullRowSelect = true;
            this.listazelja.GridLines = true;
            this.listazelja.HideSelection = false;
            this.listazelja.Location = new System.Drawing.Point(18, 21);
            this.listazelja.Name = "listazelja";
            this.listazelja.Size = new System.Drawing.Size(199, 218);
            this.listazelja.TabIndex = 0;
            this.listazelja.UseCompatibleStateImageBehavior = false;
            this.listazelja.View = System.Windows.Forms.View.Details;
            this.listazelja.SelectedIndexChanged += new System.EventHandler(this.listazelja_SelectedIndexChanged);
            // 
            // btnIgracka
            // 
            this.btnIgracka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnIgracka.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnIgracka.FlatAppearance.BorderSize = 3;
            this.btnIgracka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgracka.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnIgracka.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnIgracka.Location = new System.Drawing.Point(271, 186);
            this.btnIgracka.Name = "btnIgracka";
            this.btnIgracka.Size = new System.Drawing.Size(215, 76);
            this.btnIgracka.TabIndex = 2;
            this.btnIgracka.Text = "Igracka";
            this.btnIgracka.UseVisualStyleBackColor = true;
            this.btnIgracka.Click += new System.EventHandler(this.btnIgracka_Click);
            // 
            // btnPoklon
            // 
            this.btnPoklon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnPoklon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnPoklon.FlatAppearance.BorderSize = 3;
            this.btnPoklon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoklon.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPoklon.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPoklon.Location = new System.Drawing.Point(271, 12);
            this.btnPoklon.Name = "btnPoklon";
            this.btnPoklon.Size = new System.Drawing.Size(215, 76);
            this.btnPoklon.TabIndex = 3;
            this.btnPoklon.Text = "Poklon";
            this.btnPoklon.UseVisualStyleBackColor = true;
            this.btnPoklon.Click += new System.EventHandler(this.btnPoklon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBox1.Controls.Add(this.listazelja);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zelja";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Naziv";
            // 
            // ListaZeljaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(530, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPoklon);
            this.Controls.Add(this.btnIgracka);
            this.Name = "ListaZeljaForm";
            this.Text = "LISTA ZELJA";
            this.Load += new System.EventHandler(this.ListaZeljaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listazelja;
        private System.Windows.Forms.Button btnIgracka;
        private System.Windows.Forms.Button btnPoklon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
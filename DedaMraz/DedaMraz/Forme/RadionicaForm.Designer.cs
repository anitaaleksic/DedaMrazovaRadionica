namespace DedaMraz.Forme
{
    partial class RadionicaForm
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
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listViewDeloviRadionice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxUredi = new System.Windows.Forms.GroupBox();
            this.btnIzmeniDeoRadionice = new System.Windows.Forms.Button();
            this.btnObrisiDeoRadionice = new System.Windows.Forms.Button();
            this.btnDodajDeoRadionice = new System.Windows.Forms.Button();
            this.groupBoxVilenjaci = new System.Windows.Forms.GroupBox();
            this.btnVilenjaci = new System.Windows.Forms.Button();
            this.groupBoxVestine = new System.Windows.Forms.GroupBox();
            this.btnMagicneVestine = new System.Windows.Forms.Button();
            this.Timovi = new System.Windows.Forms.GroupBox();
            this.btnTimovi = new System.Windows.Forms.Button();
            this.groupBoxLista.SuspendLayout();
            this.groupBoxUredi.SuspendLayout();
            this.groupBoxVilenjaci.SuspendLayout();
            this.groupBoxVestine.SuspendLayout();
            this.Timovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxLista.Controls.Add(this.listViewDeloviRadionice);
            this.groupBoxLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLista.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(645, 669);
            this.groupBoxLista.TabIndex = 0;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Delovi radionice";
            // 
            // listViewDeloviRadionice
            // 
            this.listViewDeloviRadionice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.listViewDeloviRadionice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDeloviRadionice.FullRowSelect = true;
            this.listViewDeloviRadionice.GridLines = true;
            this.listViewDeloviRadionice.HideSelection = false;
            this.listViewDeloviRadionice.Location = new System.Drawing.Point(18, 34);
            this.listViewDeloviRadionice.Name = "listViewDeloviRadionice";
            this.listViewDeloviRadionice.Size = new System.Drawing.Size(617, 628);
            this.listViewDeloviRadionice.TabIndex = 0;
            this.listViewDeloviRadionice.UseCompatibleStateImageBehavior = false;
            this.listViewDeloviRadionice.View = System.Windows.Forms.View.Details;
            this.listViewDeloviRadionice.SelectedIndexChanged += new System.EventHandler(this.listViewDeloviRadionice_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj vilenjaka";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Igracke";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sef";
            this.columnHeader5.Width = 135;
            // 
            // groupBoxUredi
            // 
            this.groupBoxUredi.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxUredi.Controls.Add(this.btnIzmeniDeoRadionice);
            this.groupBoxUredi.Controls.Add(this.btnObrisiDeoRadionice);
            this.groupBoxUredi.Controls.Add(this.btnDodajDeoRadionice);
            this.groupBoxUredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxUredi.Location = new System.Drawing.Point(674, 12);
            this.groupBoxUredi.Name = "groupBoxUredi";
            this.groupBoxUredi.Size = new System.Drawing.Size(385, 306);
            this.groupBoxUredi.TabIndex = 1;
            this.groupBoxUredi.TabStop = false;
            this.groupBoxUredi.Text = "Uredi radionicu";
            // 
            // btnIzmeniDeoRadionice
            // 
            this.btnIzmeniDeoRadionice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnIzmeniDeoRadionice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnIzmeniDeoRadionice.FlatAppearance.BorderSize = 3;
            this.btnIzmeniDeoRadionice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniDeoRadionice.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnIzmeniDeoRadionice.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzmeniDeoRadionice.Location = new System.Drawing.Point(29, 212);
            this.btnIzmeniDeoRadionice.Name = "btnIzmeniDeoRadionice";
            this.btnIzmeniDeoRadionice.Size = new System.Drawing.Size(336, 58);
            this.btnIzmeniDeoRadionice.TabIndex = 2;
            this.btnIzmeniDeoRadionice.Text = "Izmeni deo radionice";
            this.btnIzmeniDeoRadionice.UseVisualStyleBackColor = true;
            this.btnIzmeniDeoRadionice.Click += new System.EventHandler(this.btnIzmeniDeoRadionice_Click);
            // 
            // btnObrisiDeoRadionice
            // 
            this.btnObrisiDeoRadionice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnObrisiDeoRadionice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnObrisiDeoRadionice.FlatAppearance.BorderSize = 3;
            this.btnObrisiDeoRadionice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiDeoRadionice.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnObrisiDeoRadionice.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnObrisiDeoRadionice.Location = new System.Drawing.Point(29, 126);
            this.btnObrisiDeoRadionice.Name = "btnObrisiDeoRadionice";
            this.btnObrisiDeoRadionice.Size = new System.Drawing.Size(336, 58);
            this.btnObrisiDeoRadionice.TabIndex = 1;
            this.btnObrisiDeoRadionice.Text = "Obrisi deo radionice";
            this.btnObrisiDeoRadionice.UseVisualStyleBackColor = true;
            this.btnObrisiDeoRadionice.Click += new System.EventHandler(this.btnObrisiDeoRadionice_Click);
            // 
            // btnDodajDeoRadionice
            // 
            this.btnDodajDeoRadionice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnDodajDeoRadionice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnDodajDeoRadionice.FlatAppearance.BorderSize = 3;
            this.btnDodajDeoRadionice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDeoRadionice.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDodajDeoRadionice.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajDeoRadionice.Location = new System.Drawing.Point(29, 44);
            this.btnDodajDeoRadionice.Name = "btnDodajDeoRadionice";
            this.btnDodajDeoRadionice.Size = new System.Drawing.Size(336, 58);
            this.btnDodajDeoRadionice.TabIndex = 0;
            this.btnDodajDeoRadionice.Text = "Dodaj deo radionice";
            this.btnDodajDeoRadionice.UseVisualStyleBackColor = true;
            this.btnDodajDeoRadionice.Click += new System.EventHandler(this.btnDodajDeoRadionice_Click);
            // 
            // groupBoxVilenjaci
            // 
            this.groupBoxVilenjaci.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxVilenjaci.Controls.Add(this.btnVilenjaci);
            this.groupBoxVilenjaci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVilenjaci.Location = new System.Drawing.Point(674, 324);
            this.groupBoxVilenjaci.Name = "groupBoxVilenjaci";
            this.groupBoxVilenjaci.Size = new System.Drawing.Size(385, 115);
            this.groupBoxVilenjaci.TabIndex = 3;
            this.groupBoxVilenjaci.TabStop = false;
            this.groupBoxVilenjaci.Text = "Vilenjaci";
            // 
            // btnVilenjaci
            // 
            this.btnVilenjaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnVilenjaci.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnVilenjaci.FlatAppearance.BorderSize = 3;
            this.btnVilenjaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVilenjaci.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnVilenjaci.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnVilenjaci.Location = new System.Drawing.Point(38, 35);
            this.btnVilenjaci.Name = "btnVilenjaci";
            this.btnVilenjaci.Size = new System.Drawing.Size(336, 58);
            this.btnVilenjaci.TabIndex = 3;
            this.btnVilenjaci.Text = "Vilenjaci";
            this.btnVilenjaci.UseVisualStyleBackColor = true;
            this.btnVilenjaci.Click += new System.EventHandler(this.btnVilenjaci_Click);
            // 
            // groupBoxVestine
            // 
            this.groupBoxVestine.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.groupBoxVestine.Controls.Add(this.btnMagicneVestine);
            this.groupBoxVestine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVestine.Location = new System.Drawing.Point(674, 445);
            this.groupBoxVestine.Name = "groupBoxVestine";
            this.groupBoxVestine.Size = new System.Drawing.Size(385, 115);
            this.groupBoxVestine.TabIndex = 4;
            this.groupBoxVestine.TabStop = false;
            this.groupBoxVestine.Text = "Magicne vestine";
            this.groupBoxVestine.Enter += new System.EventHandler(this.groupBoxVestine_Enter);
            // 
            // btnMagicneVestine
            // 
            this.btnMagicneVestine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnMagicneVestine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnMagicneVestine.FlatAppearance.BorderSize = 3;
            this.btnMagicneVestine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagicneVestine.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnMagicneVestine.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnMagicneVestine.Location = new System.Drawing.Point(38, 34);
            this.btnMagicneVestine.Name = "btnMagicneVestine";
            this.btnMagicneVestine.Size = new System.Drawing.Size(336, 58);
            this.btnMagicneVestine.TabIndex = 3;
            this.btnMagicneVestine.Text = "Magicne vestine";
            this.btnMagicneVestine.UseVisualStyleBackColor = true;
            this.btnMagicneVestine.Click += new System.EventHandler(this.btnMagicneVestine_Click);
            // 
            // Timovi
            // 
            this.Timovi.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.Timovi.Controls.Add(this.btnTimovi);
            this.Timovi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Timovi.Location = new System.Drawing.Point(674, 566);
            this.Timovi.Name = "Timovi";
            this.Timovi.Size = new System.Drawing.Size(385, 115);
            this.Timovi.TabIndex = 5;
            this.Timovi.TabStop = false;
            this.Timovi.Text = "Timovi";
            // 
            // btnTimovi
            // 
            this.btnTimovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))));
            this.btnTimovi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(252)))), ((int)(((byte)(183)))));
            this.btnTimovi.FlatAppearance.BorderSize = 3;
            this.btnTimovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimovi.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnTimovi.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnTimovi.Location = new System.Drawing.Point(38, 34);
            this.btnTimovi.Name = "btnTimovi";
            this.btnTimovi.Size = new System.Drawing.Size(336, 58);
            this.btnTimovi.TabIndex = 3;
            this.btnTimovi.Text = "Timovi";
            this.btnTimovi.UseVisualStyleBackColor = true;
            this.btnTimovi.Click += new System.EventHandler(this.btnTimovi_Click);
            // 
            // RadionicaForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(92)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::DedaMraz.Properties.Resources.snegic;
            this.ClientSize = new System.Drawing.Size(1080, 693);
            this.Controls.Add(this.Timovi);
            this.Controls.Add(this.groupBoxVestine);
            this.Controls.Add(this.groupBoxVilenjaci);
            this.Controls.Add(this.groupBoxUredi);
            this.Controls.Add(this.groupBoxLista);
            this.Name = "RadionicaForm";
            this.Text = "RADIONICA";
            this.Load += new System.EventHandler(this.RadionicaForm_Load);
            this.groupBoxLista.ResumeLayout(false);
            this.groupBoxUredi.ResumeLayout(false);
            this.groupBoxVilenjaci.ResumeLayout(false);
            this.groupBoxVestine.ResumeLayout(false);
            this.Timovi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.GroupBox groupBoxUredi;
        private System.Windows.Forms.GroupBox groupBoxVilenjaci;
        private System.Windows.Forms.GroupBox groupBoxVestine;
        private System.Windows.Forms.Button btnIzmeniDeoRadionice;
        private System.Windows.Forms.Button btnObrisiDeoRadionice;
        private System.Windows.Forms.Button btnDodajDeoRadionice;
        private System.Windows.Forms.Button btnVilenjaci;
        private System.Windows.Forms.Button btnMagicneVestine;
        private System.Windows.Forms.ListView listViewDeloviRadionice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox Timovi;
        private System.Windows.Forms.Button btnTimovi;
    }
}
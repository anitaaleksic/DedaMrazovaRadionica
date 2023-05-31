
namespace DedaMraz
{
    partial class Form1
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
            this.cmdPrikaziDete = new System.Windows.Forms.Button();
            this.btnManyToOne = new System.Windows.Forms.Button();
            this.btnOneToMany = new System.Windows.Forms.Button();
            this.btnManyToMany = new System.Windows.Forms.Button();
            this.btnDodajDeoRadionice = new System.Windows.Forms.Button();
            this.btnablePerClass = new System.Windows.Forms.Button();
            this.btnVratiSefa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPrikaziDete
            // 
            this.cmdPrikaziDete.Location = new System.Drawing.Point(91, 37);
            this.cmdPrikaziDete.Name = "cmdPrikaziDete";
            this.cmdPrikaziDete.Size = new System.Drawing.Size(156, 33);
            this.cmdPrikaziDete.TabIndex = 0;
            this.cmdPrikaziDete.Text = "Prikazi dete";
            this.cmdPrikaziDete.UseVisualStyleBackColor = true;
            this.cmdPrikaziDete.Click += new System.EventHandler(this.cmdPrikaziDete_Click);
            // 
            // btnManyToOne
            // 
            this.btnManyToOne.Location = new System.Drawing.Point(91, 99);
            this.btnManyToOne.Name = "btnManyToOne";
            this.btnManyToOne.Size = new System.Drawing.Size(155, 31);
            this.btnManyToOne.TabIndex = 1;
            this.btnManyToOne.Text = "ManyToOne";
            this.btnManyToOne.UseVisualStyleBackColor = true;
            this.btnManyToOne.Click += new System.EventHandler(this.btnManyToOne_Click);
            // 
            // btnOneToMany
            // 
            this.btnOneToMany.Location = new System.Drawing.Point(91, 155);
            this.btnOneToMany.Name = "btnOneToMany";
            this.btnOneToMany.Size = new System.Drawing.Size(155, 36);
            this.btnOneToMany.TabIndex = 2;
            this.btnOneToMany.Text = "OneToMany";
            this.btnOneToMany.UseVisualStyleBackColor = true;
            this.btnOneToMany.Click += new System.EventHandler(this.btnOneToMany_Click);
            // 
            // btnManyToMany
            // 
            this.btnManyToMany.Location = new System.Drawing.Point(93, 216);
            this.btnManyToMany.Name = "btnManyToMany";
            this.btnManyToMany.Size = new System.Drawing.Size(152, 37);
            this.btnManyToMany.TabIndex = 3;
            this.btnManyToMany.Text = "ManyToMany";
            this.btnManyToMany.UseVisualStyleBackColor = true;
            //this.btnManyToMany.Click += new System.EventHandler(this.btnManyToMany_Click);
            // 
            // btnDodajDeoRadionice
            // 
            this.btnDodajDeoRadionice.Location = new System.Drawing.Point(93, 280);
            this.btnDodajDeoRadionice.Name = "btnDodajDeoRadionice";
            this.btnDodajDeoRadionice.Size = new System.Drawing.Size(153, 36);
            this.btnDodajDeoRadionice.TabIndex = 4;
            this.btnDodajDeoRadionice.Text = "DodajDeoRadionice";
            this.btnDodajDeoRadionice.UseVisualStyleBackColor = true;
            this.btnDodajDeoRadionice.Click += new System.EventHandler(this.btnDodajDeoRadionice_Click);
            // 
            // btnablePerClass
            // 
            this.btnablePerClass.Location = new System.Drawing.Point(90, 340);
            this.btnablePerClass.Name = "btnablePerClass";
            this.btnablePerClass.Size = new System.Drawing.Size(154, 31);
            this.btnablePerClass.TabIndex = 5;
            this.btnablePerClass.Text = "TablePerClass";
            this.btnablePerClass.UseVisualStyleBackColor = true;
            this.btnablePerClass.Click += new System.EventHandler(this.btnablePerClass_Click);
            // 
            // btnVratiSefa
            // 
            this.btnVratiSefa.Location = new System.Drawing.Point(93, 392);
            this.btnVratiSefa.Name = "btnVratiSefa";
            this.btnVratiSefa.Size = new System.Drawing.Size(151, 35);
            this.btnVratiSefa.TabIndex = 6;
            this.btnVratiSefa.Text = "Vrati sefa";
            this.btnVratiSefa.UseVisualStyleBackColor = true;
            this.btnVratiSefa.Click += new System.EventHandler(this.btnVratiSefa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnVratiSefa);
            this.Controls.Add(this.btnablePerClass);
            this.Controls.Add(this.btnDodajDeoRadionice);
            this.Controls.Add(this.btnManyToMany);
            this.Controls.Add(this.btnOneToMany);
            this.Controls.Add(this.btnManyToOne);
            this.Controls.Add(this.cmdPrikaziDete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPrikaziDete;
        private System.Windows.Forms.Button btnManyToOne;
        private System.Windows.Forms.Button btnOneToMany;
        private System.Windows.Forms.Button btnManyToMany;
        private System.Windows.Forms.Button btnDodajDeoRadionice;
        private System.Windows.Forms.Button btnablePerClass;
        private System.Windows.Forms.Button btnVratiSefa;
    }
}


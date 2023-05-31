using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DedaMraz.Forme
{
    public partial class DodajVilenjakaIgrackeForm : Form
    {
        VilenjakIgrackeBasic vilenjaciigracke;
        public DodajVilenjakaIgrackeForm()
        {
            InitializeComponent();
            vilenjaciigracke = new VilenjakIgrackeBasic();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void popuniPodacima()
        {
            List<VilenjakIgrackeBasic> listavilenjaka = DTOManager.vratiSveVilenjakeIgracke();
            foreach (VilenjakIgrackeBasic s in listavilenjaka)
            {
                comboVil.Items.Add(s);
            }

            List<DeoRadionicePregled> listaradionica = DTOManager.vratiSveDeloveRadionice();
            foreach (DeoRadionicePregled s in listaradionica)
            {
                comboRad.Items.Add(s);
            }

            List<TimPregled> listatimova = DTOManager.vratiSveTimove();
            foreach (TimPregled s in listatimova)
            {
                comboTim.Items.Add(s);
            }
        }
        private void DodajVilenjakaIgrackeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodajVilenjakaIgracke_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate vilenjaka za igracke?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vilenjaciigracke.Ime = textboxImeVilenjakaIgracke.Text;
                this.vilenjaciigracke.Ocena = (float)numericupdownOcena.Value;
                this.vilenjaciigracke.RadniStaz = textboxRadniStazVilenjakaIgracke.Text;

                if (checkBoxSef.Checked == true)                
                    this.vilenjaciigracke.Sef = "Da";                
                else
                    this.vilenjaciigracke.Sef = "Ne";

                if (checkBoxMentor.Checked == true)
                    this.vilenjaciigracke.Mentor = "Da";
                else
                    this.vilenjaciigracke.Mentor = "Ne";

                if (checkBoxKoor.Checked == true)
                    this.vilenjaciigracke.Koordinator = "Da";
                else
                    this.vilenjaciigracke.Koordinator = "Ne";


                this.vilenjaciigracke.SpecijalizovanZa = SpecijalizovanZaVilenjakIgracke.Text;
                this.vilenjaciigracke.TrajanjeObuke = TrajanjeObukeVilenjakaIgracke.Text;
                this.vilenjaciigracke.ZemljaPorekla = textboxZemljaPoreklaVilenjakaIgracke.Text;
                VilenjakIgrackeBasic s = (VilenjakIgrackeBasic)comboVil.SelectedItem;
                DeoRadionicePregled d = (DeoRadionicePregled)comboRad.SelectedItem;
                TimPregled t = (TimPregled)comboTim.SelectedItem;
                DTOManager.DodajVilenjakaIgracke(this.vilenjaciigracke,s,d,t);
                MessageBox.Show("Uspesno ste dodali novog vilenjaka za igracke!");
                this.Close();
            }
            else
            {

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboRad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

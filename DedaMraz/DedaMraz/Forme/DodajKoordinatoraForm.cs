using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMraz.Forme
{
    public partial class DodajKoordinatoraForm : Form
    {
        VilenjakIgrackeBasic koordinator = new VilenjakIgrackeBasic();
        DeoRadioniceBasic deoRadionice;
        public DodajKoordinatoraForm()
        {
            InitializeComponent();
        }
        public DodajKoordinatoraForm(DeoRadioniceBasic deoRadionice)
        {
            InitializeComponent();
            this.deoRadionice = deoRadionice;
        }
        private void btnDodajVilenjakaIgracke_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate vilenjaka za igracke?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.koordinator.Ime = textboxImeVilenjakaIgracke.Text;
                this.koordinator.Ocena = (float)numericupdownOcena.Value;
                this.koordinator.RadniStaz = textboxRadniStazVilenjakaIgracke.Text;

                if (checkBoxSef.Checked == true)
                    this.koordinator.Sef = "Da";
                else
                    this.koordinator.Sef = "Ne";

                if (checkBoxMentor.Checked == true)
                    this.koordinator.Mentor = "Da";
                else
                    this.koordinator.Mentor = "Ne";

                    this.koordinator.Koordinator = "Da";


                this.koordinator.SpecijalizovanZa = SpecijalizovanZaVilenjakIgracke.Text;
                this.koordinator.TrajanjeObuke = TrajanjeObukeVilenjakaIgracke.Text;
                this.koordinator.ZemljaPorekla = textboxZemljaPoreklaVilenjakaIgracke.Text;
                VilenjakIgrackeBasic s = (VilenjakIgrackeBasic)comboVil.SelectedItem;
                DeoRadioniceBasic d = deoRadionice;
                TimBasic t = koordinator.Tim;
                DTOManager.DodajVilenjakaIgrackeKoor(this.koordinator, s, d, t);
                MessageBox.Show("Uspesno ste dodali novog koordinatora!");
                
                this.Close();
            }
        }

        private void DodajKoordinatoraForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            List<VilenjakIgrackeBasic> vilenjaci = DTOManager.vratiSveVilenjakeIgracke();
            foreach (VilenjakIgrackeBasic v in vilenjaci)
            {
                comboVil.Items.Add(v);  
            }
        }
    }
}

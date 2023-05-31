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
    public partial class DeoRadioniceAzurirajForm : Form
    {
        public DeoRadioniceBasic deoradionice;
        VilenjakIgrackeBasic sef;
        public DeoRadioniceAzurirajForm()
        {
            InitializeComponent();
        }
        public DeoRadioniceAzurirajForm(DeoRadioniceBasic d)
        {
            InitializeComponent();
            this.deoradionice = d;
        }
        public DeoRadioniceAzurirajForm(DeoRadioniceBasic d, VilenjakIgrackeBasic v)
        {
            InitializeComponent();
            this.deoradionice = d;
            sef = v;

        }
        public void popuniPodacima()
        {
            textboxAzurirajNazivRadionice.Text = this.deoradionice.Naziv;
            textboxAzurirajTipIgracaka.Text = this.deoradionice.TipIgracaka;
            
            numAzurirajBrojVilenjaka.Value = this.deoradionice.BrojVilenjaka;

            List<VilenjakIgrackeBasic> listavilenjaka = DTOManager.vratiSveVilenjakeIgrackeRadionicaa(deoradionice.ID);
            foreach (VilenjakIgrackeBasic s in listavilenjaka)
            {
                combosef.Items.Add(s);
            }
            combosef.SelectedIndex = 0;
            
        }

        private void btnAzurirajDeoRadionice_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene dela radionice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.deoradionice.Naziv = textboxAzurirajNazivRadionice.Text;
                this.deoradionice.TipIgracaka = textboxAzurirajTipIgracaka.Text;
                this.deoradionice.BrojVilenjaka =(int) numAzurirajBrojVilenjaka.Value;
                this.deoradionice.DatumPostavljanja = datetimeDatumPostavljanjaAzuriraj.Value;
                

                VilenjakIgrackeBasic s = (VilenjakIgrackeBasic)combosef.SelectedItem;

                

                DTOManager.azurirajDeoRadionice(this.deoradionice,s);
                MessageBox.Show("Uspesno ste azurirali deo radionice!");
                this.Close();
            }
        }

        private void DeoRadioniceAzurirajForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelAzurirajBrojVilenjaka_Click(object sender, EventArgs e)
        {

        }
    }
}

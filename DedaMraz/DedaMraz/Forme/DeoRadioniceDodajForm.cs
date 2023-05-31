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
    public partial class DeoRadioniceDodajForm : Form
    {
        DeoRadioniceBasic deoradionice;
        public DeoRadioniceDodajForm()
        {
            InitializeComponent();
            deoradionice = new DeoRadioniceBasic();
        }

        private void DeoRadioniceDodajForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<VilenjakIgrackeBasic> listavilenjaka = DTOManager.vratiSveVilenjakeIgrackeRadionicaa(deoradionice.ID);//promenjeno nmpyyy
            foreach (VilenjakIgrackeBasic s in listavilenjaka)
            {
               comboSef.Items.Add(s);
            }
        }
        private void btnDodajDeoRadionice_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate deo radionice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.deoradionice.Naziv = textBoxNaziv.Text;
                this.deoradionice.BrojVilenjaka =(int) numBrojVilenjaka.Value;
                this.deoradionice.DatumPostavljanja = dateTimeDatumPostavljanja.Value;
                this.deoradionice.TipIgracaka = TextBoxTipIgracaka.Text;
                VilenjakIgrackeBasic s = (VilenjakIgrackeBasic)comboSef.SelectedItem;
               
                DTOManager.dodajDeoRadionice(this.deoradionice, s);
                this.Close();
            }
            else
            {

            }
        }
    }
}

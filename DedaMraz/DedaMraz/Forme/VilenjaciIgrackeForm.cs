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
    public partial class VilenjaciIgrackeForm : Form
    {
        public VilenjaciIgrackeForm()
        {
            InitializeComponent();
        }
        DeoRadioniceBasic deoRadionice;
        public VilenjaciIgrackeForm(DeoRadioniceBasic dr)
        {
            InitializeComponent();
            deoRadionice = dr;
            
        }
        public void popuniPodacima()
        {

            vilenjaciigracke.Items.Clear();
            List<VilenjakIgrackeBasic> podaci = DTOManager.vratiSveVilenjakeIgracke();

            foreach (VilenjakIgrackeBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.ZemljaPorekla, p.RadniStaz, p.SpecijalizovanZa, p.Ocena.ToString()});
                vilenjaciigracke.Items.Add(item);

            }

            this.vilenjaciigracke.Refresh();
        }

      
        private void btnObrisiVilenjakaIgracke_Click(object sender, EventArgs e)
        {
            if (vilenjaciigracke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vilenjaka za igracke kojeg zelite da obrisete!");
                return;
            }

            int idvilenjaka = Int32.Parse(vilenjaciigracke.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vilenjaka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVilenjakaIgracke(idvilenjaka);
                MessageBox.Show("Brisanje vilenjaka za igracke je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void VilenjaciIgrackeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajVilenjakaIgracke_Click(object sender, EventArgs e)
        {
            DodajVilenjakaIgrackeForm forma = new DodajVilenjakaIgrackeForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}

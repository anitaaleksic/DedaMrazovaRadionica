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
    public partial class VilenjaciPokloniForm : Form
    {
        public VilenjaciPokloniForm()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {

            vilenjacipokloni.Items.Clear();
            List<VilenjakPokloniBasic> podaci = DTOManager.VratiSveVilenjakePoklone();



            foreach (VilenjakPokloniBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.ZemljaPorekla, p.RadniStaz });
                vilenjacipokloni.Items.Add(item);

            }

            this.vilenjacipokloni.Refresh();
        }
        private void btnObrisiVilenjakaPokloni_Click(object sender, EventArgs e)
        {
            if (vilenjacipokloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vilenjaka za poklone kojeg zelite da obrisete!");
                return;
            }

            int idvilenjaka = Int32.Parse(vilenjacipokloni.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vilenjaka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVilenjakaPokloni(idvilenjaka);
                MessageBox.Show("Brisanje vilenjaka za poklone je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void VilenjaciPokloniForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodajVilenjakaPokloni_Click(object sender, EventArgs e)
        {
            DodajVilenjakaPoklonForm forma = new DodajVilenjakaPoklonForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void vilenjacipokloni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

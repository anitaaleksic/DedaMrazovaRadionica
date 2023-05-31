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
    public partial class VilenjaciIrvasiForm : Form
    {
        public VilenjaciIrvasiForm()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {

            vilenjaciirvasi.Items.Clear();
            List<VilenjakIrvasiBasic> podaci = DTOManager.VratiSveVilenjakeIrvase();



            foreach (VilenjakIrvasiBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.ZemljaPorekla, p.RadniStaz });
                vilenjaciirvasi.Items.Add(item);

            }

            this.vilenjaciirvasi.Refresh();
        }
        private void btnObrisiVilenjakaIrvasi_Click(object sender, EventArgs e)
        {
            if (vilenjaciirvasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vilenjaka za irvase kojeg zelite da obrisete!");
                return;
            }

            int idvilenjaka = Int32.Parse(vilenjaciirvasi.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vilenjaka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVilenjakaIrvas(idvilenjaka);
                MessageBox.Show("Brisanje vilenjaka za irvase je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void VilenjaciIrvasiForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void btnDodajVilenjakaIrvasi_Click(object sender, EventArgs e)
        {
            DodajVilenjakaIrvasForm forma = new DodajVilenjakaIrvasForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnPesma_Click(object sender, EventArgs e)
        {
            if (vilenjaciirvasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vilenjaka za irvase za kog zelite da vidite pesme koje zna!");
                return;
            }

            int idvilenjaka = Int32.Parse(vilenjaciirvasi.SelectedItems[0].SubItems[0].Text);
            VilenjakIrvasiBasic vilenjak = DTOManager.vratiVilenjakaIrvasi(idvilenjaka);
            PesmeForm forma = new PesmeForm(vilenjak);
            forma.ShowDialog();
           
        }
    }
}

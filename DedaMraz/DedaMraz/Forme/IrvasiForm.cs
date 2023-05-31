using DedaMrazovaRadionica;
using NHibernate;
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
    public partial class IrvasiForm : Form
    {
        public IrvasiForm()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {


            irvasi.Items.Clear();
            List<IrvasPregled> podaci = DTOManager.vratiSveIrvase();



            foreach (IrvasPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.Nadimak, p.Pol.ToString(), p.DatumRodjenja.ToString()});
                irvasi.Items.Add(item);

            }
            irvasi.Refresh();
        }
       

        private void btnDodajIrvasa_Click(object sender, EventArgs e)
        {
            IrvasiDodajForm formaDodaj = new IrvasiDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniIrvasa_Click(object sender, EventArgs e)
        {
            if (irvasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cije podatke zelite da izmenite!");
                return;
            }

            int idIrvasa = Int32.Parse(irvasi.SelectedItems[0].SubItems[0].Text);
            IrvasBasic ob = DTOManager.vratiIrvasa(idIrvasa);
            IrvasiAzurirajForm formaDodaj = new IrvasiAzurirajForm(ob);
            formaDodaj.ShowDialog();

            this.popuniPodacima();
            
        }

        private void irvasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IrvasiForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void btnVlasnikIrvasa_Click(object sender, EventArgs e)
        {
            if(irvasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite irvasa za koga zelite da vidite zaduzene vilenjake!");
                return;
            }
            int idIrvasa = Int32.Parse(irvasi.SelectedItems[0].SubItems[0].Text);
            IrvasBasic irvas = DTOManager.vratiIrvasa(idIrvasa);
            List<VilenjakIrvasiBasic> vilenjaci = DTOManager.VratiSveVilenjakeZaduzeneZaIrvasa(idIrvasa);
            string ispisi = "";
            foreach(VilenjakIrvasiBasic v in vilenjaci)
            {
                ispisi += $"ID:{v.ID},\nIme:{v.Ime},\nZemlja porekla:{v.ZemljaPorekla},\nRadni staz:{v.RadniStaz};\n";
            }
            MessageBox.Show(ispisi);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (irvasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite irvasa kojeg zelite da obrisete!");
                return;
            }

            int idIrvasa = Int32.Parse(irvasi.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog irvasa?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiIrvasa(idIrvasa);
                MessageBox.Show("Brisanje irvasa je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}

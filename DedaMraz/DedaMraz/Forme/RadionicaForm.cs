using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DedaMraz.Entiteti;
using DedaMrazovaRadionica;
using NHibernate;

namespace DedaMraz.Forme
{
    public partial class RadionicaForm : Form
    {
        public RadionicaForm()
        {
            InitializeComponent();
        }


        private void RadionicaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewDeloviRadionice.Items.Clear();
            this.Text = $"RADIONICA";
            List<DeoRadionicePregled> podaci = DTOManager.vratiSveDeloveRadionice();

            foreach(DeoRadionicePregled dr  in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dr.ID.ToString(),
                    dr.Naziv,
                    dr.BrojVilenjaka.ToString(),
                    dr.TipIgracaka,
                    dr.Sef.ToString()
                });
                listViewDeloviRadionice.Items.Add(item);
            }
            listViewDeloviRadionice.Refresh();
        }
        private void btnDodajDeoRadionice_Click(object sender, EventArgs e)
        {
            DeoRadioniceDodajForm formaDodaj = new DeoRadioniceDodajForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniDeoRadionice_Click(object sender, EventArgs e)
        {
            if(listViewDeloviRadionice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite deo radionice koj zelite da izmenite!");
                return;
            }
            int idDelaRadionice = Int32.Parse(listViewDeloviRadionice.SelectedItems[0].SubItems[0].Text);
            DeoRadioniceBasic dr = DTOManager.vratiDeoRadionice(idDelaRadionice);

            DeoRadioniceAzurirajForm formaAzuriraj = new DeoRadioniceAzurirajForm(dr, dr.Sef);
            formaAzuriraj.ShowDialog();

            this.popuniPodacima();
        }
        private void btnObrisiDeoRadionice_Click(object sender, EventArgs e)
        {
            if (listViewDeloviRadionice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite deo radionice koj zelite da obrisete!");
                return;
            }

            int idDelaRadionice = Int32.Parse(listViewDeloviRadionice.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani deo radionice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiDeoRadionice(idDelaRadionice);
                MessageBox.Show("Brisanje dela radionice je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnSefovi_Click(object sender, EventArgs e)
        {
            
        }
        private void btnVilenjaci_Click(object sender, EventArgs e)
        {
            if(listViewDeloviRadionice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite deo radionice cije vilenjake zelite da vidite!");
                return;
            }
            int idDelaRadionice = Int32.Parse(listViewDeloviRadionice.SelectedItems[0].SubItems[0].Text);
            DeoRadioniceBasic dr = DTOManager.vratiDeoRadionice(idDelaRadionice);
            VilenjaciRadionicaForm vil = new VilenjaciRadionicaForm(dr);
            vil.ShowDialog();
        }
        private void btnMagicneVestine_Click(object sender, EventArgs e)
        {
            if(listViewDeloviRadionice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite deo radionice za koj zelite da vidite potrebne magicne vestine!");
                return;
            }
           
            int idDelaRadionice = Int32.Parse(listViewDeloviRadionice.SelectedItems[0].SubItems[0].Text);
            DeoRadioniceBasic dr = DTOManager.vratiDeoRadionice(idDelaRadionice);
            ISession s = DataLayer.GetSession();



            IList<MagicnaVestinaPregled> vestine = DTOManager.vratiSveMagicneVestineZaDeoRadionice(dr.ID);

            string ispisi = "Vestine: \n";
            foreach (MagicnaVestinaPregled m in vestine)
            {
                ispisi += $"{m.ID}\n";
                
            }
            MessageBox.Show(ispisi);
        }

        private void groupBoxVestine_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            if (listViewDeloviRadionice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite deo radionice cije timove zelite da vidite!");
                return;
            }
            int idDelaRadionice = Int32.Parse(listViewDeloviRadionice.SelectedItems[0].SubItems[0].Text);
            DeoRadioniceBasic dr = DTOManager.vratiDeoRadionice(idDelaRadionice);
            TimoviForm timoviForm = new TimoviForm(dr);
            timoviForm.ShowDialog();
        }

        private void listViewDeloviRadionice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

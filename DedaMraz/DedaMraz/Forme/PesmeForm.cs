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
    public partial class PesmeForm : Form
    {
        VilenjakIrvasiBasic vilenjak;
        public PesmeForm()
        {
            InitializeComponent();
        }
        public PesmeForm(VilenjakIrvasiBasic vil)
        {
            InitializeComponent();
            vilenjak = vil;
        }
        public void popuniPodacima()
        {
            listViewPesme.Items.Clear();
            this.Text = $"PESME";
            List<PesmaPregled> podaci = DTOManager.vratiSvePesmeZaVilenjaka(vilenjak);

            foreach (PesmaPregled pe in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pe.ID.ToString(),
                    pe.Naziv,
                    
                });
                listViewPesme.Items.Add(item);
            }
            listViewPesme.Refresh();
        }
        private void btnPesma_Click(object sender, EventArgs e)
        {
            DodajPesmuForm dodajPesmuForm = new DodajPesmuForm();
            dodajPesmuForm.ShowDialog();
            this.popuniPodacima();
        }

        private void PesmeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnPrikaziTekst_Click(object sender, EventArgs e)
        {
            if (listViewPesme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pesmu za koju zelite da vidite tekst!");
                return;
            }
            int idPesme = Int32.Parse(listViewPesme.SelectedItems[0].SubItems[0].Text);
            PesmaBasic pesma = DTOManager.vratiPesmu(idPesme);

            textBox1.Text = pesma.Tekst;
        }
    }
}

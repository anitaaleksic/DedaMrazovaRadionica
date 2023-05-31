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
    public partial class MagicneVestineForm : Form
    {
        DeoRadioniceBasic dr;
        public MagicneVestineForm()
        {
            InitializeComponent();
        }
        public MagicneVestineForm(DeoRadioniceBasic dr)
        {
            InitializeComponent();
            this.dr = dr;
        }

        private void MagicneVestineForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        //netje
        public void popuniPodacima()
        {
            listViewMagicneVestine.Items.Clear();
            this.Text = $"MAGICNE VESTINE";

            IList<MagicnaVestinaPregled> podaci = DTOManager.vratiSveMagicneVestineZaDeoRadionice(dr.ID);

            foreach(MagicnaVestinaPregled mv in podaci)
            {
                ListViewItem item = new ListViewItem(mv.ID);
                listViewMagicneVestine.Items.Add(item);
            }
            listViewMagicneVestine.Refresh();
        }

        private void groupBoxMagicneVestine_Enter(object sender, EventArgs e)
        {

        }

        private void listViewMagicneVestine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajMagicnuVestinu_Click(object sender, EventArgs e)
        {
            DodajMagicnuVestinuForm dodajMagicnuVestinuForm = new DodajMagicnuVestinuForm();
            dodajMagicnuVestinuForm.ShowDialog();
        }
    }
}

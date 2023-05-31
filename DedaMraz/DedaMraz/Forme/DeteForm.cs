using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DedaMraz.Forme;

namespace DedaMraz.Forme
{
    public partial class DeteForm : Form
    {
        DeteBasic dete;
        public DeteForm()
        {
            InitializeComponent();
        }
        public DeteForm(DeteBasic dete)
        {
            InitializeComponent();
            this.dete = dete;
        }
        private void DeteForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listViewDete.Items.Clear();
            List<DetePregled> deca = DTOManager.vratiSvuDecu();

            foreach(DetePregled d in deca)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    d.ID.ToString(),
                    d.Ime,
                    d.Prezime,
                    d.DatumRodjenja.ToString(),
                    d.Drzava,
                    d.Grad,
                    d.Adresa
                });
                listViewDete.Items.Add(item);
            }
            this.listViewDete.Refresh();

        }

        private void btnPisma_Click(object sender, EventArgs e)
        {
            if(listViewDete.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dete cija pisma zelite da prikazete!");
                return;
            }
            int idDeteta = Int32.Parse(listViewDete.SelectedItems[0].SubItems[0].Text);
            DeteBasic dete = DTOManager.vratiDete(idDeteta);
            PismoForm forma = new PismoForm(dete);  
            forma.ShowDialog();
        }

        private void btnPokloni_Click(object sender, EventArgs e)
        {
            if (listViewDete.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dete cija pisma zelite da prikazete!");
                return;
            }
            int idDeteta = Int32.Parse(listViewDete.SelectedItems[0].SubItems[0].Text);
            DeteBasic dete = DTOManager.vratiDete(idDeteta);
            List<PismoBasic> svaPismaDeteta = DTOManager.vratiSvaPismaDeteta(idDeteta);
        }

        private void listViewDete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

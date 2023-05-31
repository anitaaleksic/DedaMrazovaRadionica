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
    public partial class PokloniForm : Form
    {
        PoklonBasic poklon;
        public PokloniForm()
        {
            InitializeComponent();
        }
        public PokloniForm(PoklonBasic p)
        {
            InitializeComponent();
            poklon = p;
        }


        public void popuniPodacima()
        {
            pokloni.Items.Clear();
            List<PoklonPregled> podaci = DTOManager.vratiSvePoklone();

            foreach (PoklonPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {p.ID.ToString(), p.Boja, p.Posveta });
                pokloni.Items.Add(item);

            }

            pokloni.Refresh();
        }

        private void pokloni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PokloniForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        

        private void btnListaZelja_Click(object sender, EventArgs e)
        {
            if (pokloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite poklon za koj zelite da prikazete listu zelja!");
                return;
            }

            int idPoklona = Int32.Parse(pokloni.SelectedItems[0].SubItems[0].Text);
        }

        private void btnPismo_Click(object sender, EventArgs e)
        {
            
        }
    }
 }

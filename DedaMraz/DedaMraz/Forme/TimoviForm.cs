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

namespace DedaMraz.Forme
{
    public partial class TimoviForm : Form
    {
        DeoRadioniceBasic deoRadionice;
        public TimoviForm()
        {
            InitializeComponent();
        }

        public TimoviForm(DeoRadioniceBasic dr)
        {
            InitializeComponent();
            deoRadionice = dr;
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<VilenjakIgrackeBasic> podaci1 = DTOManager.vratiSveVilenjakeIgrackeZaDeoRadionice(deoRadionice.ID);

            
            foreach (VilenjakIgrackeBasic p in podaci1)
            {
                if (p.Koordinator == "Da")
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Tim.Koordinator.ToString() });
                    listView1.Items.Add(item);
                }              
            }

            this.listView1.Refresh();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimoviForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnRadionica_Click(object sender, EventArgs e)
        {
            DodajTimForm forma = new DodajTimForm(deoRadionice);
            forma.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

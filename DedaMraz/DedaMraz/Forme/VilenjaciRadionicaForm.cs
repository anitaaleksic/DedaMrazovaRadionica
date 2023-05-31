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
    public partial class VilenjaciRadionicaForm : Form
    {
        DeoRadioniceBasic deoradionice;
        public VilenjaciRadionicaForm()
        {
            InitializeComponent();
        }
        public VilenjaciRadionicaForm(DeoRadioniceBasic deo)
        {
            InitializeComponent();
            deoradionice = deo;
        }

        public void popuniPodacima()
        {

            listView1.Items.Clear();
            
            List<VilenjakIgrackeBasic> podaci1 = DTOManager.vratiSveVilenjakeIgrackeZaDeoRadionice(deoradionice.ID);



            foreach (VilenjakIgrackeBasic p in podaci1)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.ZemljaPorekla, p.RadniStaz });
                listView1.Items.Add(item);

            }

            this.listView1.Refresh();
        }
        private void VilenjaciRadionicaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

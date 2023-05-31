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
    public partial class DodajTimForm : Form
    {
        DeoRadioniceBasic deoRad;
        TimBasic tim;
        public DodajTimForm()
        {
            InitializeComponent();
            deoRad = new DeoRadioniceBasic();
            tim = new TimBasic();
        }
        public DodajTimForm(DeoRadioniceBasic dr)
        {
            InitializeComponent();
            deoRad = dr;
            tim = new TimBasic();
        }
        private void btnDodajKoordinatora_Click(object sender, EventArgs e)
        {
            DodajKoordinatoraForm forma = new DodajKoordinatoraForm(deoRad);
            forma.ShowDialog();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate tim?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                tim.Koordinator = (VilenjakIgrackeBasic)comboKoor.SelectedItem;
                DTOManager.dodajTim(this.tim);
                MessageBox.Show("Uspesno ste dodali novi tim!");
                this.Close();
            }            
        }
        private void DodajTimForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            List<VilenjakIgrackeBasic> lista = DTOManager.vratiSveVilenjakeIgracke();
            foreach (var item in lista)
            {
                if (item.Koordinator == "Da")
                {
                    comboKoor.Items.Add(item);
                }
            }
        }
        
    }
}

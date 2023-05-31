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
    public partial class DodajVilenjakaIrvasForm : Form
    {
        VilenjakIrvasiBasic vilenjakirvas;
        IrvasBasic irvass;
        public DodajVilenjakaIrvasForm()
        {
            InitializeComponent();
            vilenjakirvas = new VilenjakIrvasiBasic();
        }
        void popuniPodacima()
        {
            List<IrvasPregled> listaIrvasa = DTOManager.vratiSveIrvase();
            foreach (IrvasPregled s in listaIrvasa)
            {
                comboIrvas.Items.Add(s);
            }
        }
        private void DodajVilenjakaIrvasForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string poruka = "Da li zelite da dodate vilenjaka za irvase?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vilenjakirvas.Ime = textBoxIme.Text;
                this.vilenjakirvas.RadniStaz = textBoxRadniStaz.Text;
                this.vilenjakirvas.ZemljaPorekla = textBoxZemljaPorekla.Text;
                IrvasPregled t = (IrvasPregled)comboIrvas.SelectedItem;
                
                DTOManager.DodajVilenjakaIrvas(this.vilenjakirvas,t);
               

                MessageBox.Show("Uspesno ste dodali novog vilenjaka za irvase!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

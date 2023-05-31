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
    public partial class DodajPoklonForm : Form
    {
        PoklonBasic poklon;
        public DodajPoklonForm()
        {
            poklon = new PoklonBasic();
            InitializeComponent();
        }

        void popuniPodacima()
        {
            List<TovarPregled> listatovara = DTOManager.vratiSveTovare();
            foreach (TovarPregled s in listatovara)
            {
                comboTovar.Items.Add(s);
            }
            List<VilenjakPokloniPregled> listaVilenjaka = DTOManager.VratiSveVilenjakePoklonePregled();
            {
                foreach(VilenjakPokloniPregled v in listaVilenjaka)
                {
                    comboVilenjak.Items.Add(v);
                }
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpakujPoklonForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnSpakujPoklon_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da spakujete poklon?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.poklon.Boja = textboxBoja.Text;
                this.poklon.Posveta = textboxPosveta.Text;


               TovarPregled t = (TovarPregled)comboTovar.SelectedItem;
               VilenjakPokloniPregled v = (VilenjakPokloniPregled)comboVilenjak.SelectedItem;

                DTOManager.DodajPoklon(this.poklon, t, v);


                MessageBox.Show("Uspesno ste spakovali poklon!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

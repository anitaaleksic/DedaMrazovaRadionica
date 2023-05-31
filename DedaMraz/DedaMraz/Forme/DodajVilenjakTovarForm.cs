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
    public partial class DodajVilenjakTovarForm : Form
    {
        VilenjakTovarBasic vilenjaktovar;
        public DodajVilenjakTovarForm()
        {
            InitializeComponent();
            vilenjaktovar = new VilenjakTovarBasic();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void popuniPodacima()
        {
            List<TovarPregled> listatovara = DTOManager.vratiSveTovare();
            foreach (TovarPregled s in listatovara)
            {
                combotovar.Items.Add(s);
            }
        }
        private void DodajVilenjakTovarForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodajVilenjakaTovar_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate vilenjaka za tovar?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vilenjaktovar.Ime = textboxIme.Text;
                this.vilenjaktovar.RadniStaz = textboxRadnistaz.Text;
                this.vilenjaktovar.ZemljaPorekla = textboxZemljaPorekla.Text;
                TovarPregled t = (TovarPregled)combotovar.SelectedItem;

                DTOManager.DodajVilenjakaTovar(this.vilenjaktovar, t);
                MessageBox.Show("Uspesno ste dodali novog vilenjaka za tovar!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

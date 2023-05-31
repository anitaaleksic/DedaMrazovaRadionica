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
    public partial class DodajDeteForm : Form
    {
        DeteBasic dete;
        public DodajDeteForm()
        {
            InitializeComponent();
            dete = new DeteBasic();
        }

        private void DodajDeteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate dete?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.dete.Ime = textboxIme.Text;
                this.dete.Prezime = textboxPrezime.Text;
                this.dete.ImeMajke = textboxMajka.Text;
                this.dete.ImeOca = textboxOtac.Text;
                this.dete.Grad = textboxGrad.Text;
                this.dete.Drzava = textboxDrzava.Text;
                this.dete.Adresa = textboxAdresa.Text;
                this.dete.DatumRodjenja = datetime.Value;

                DTOManager.dodajDete(this.dete);
                this.Close();
            }
        }
    }
}

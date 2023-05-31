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
    public partial class DodajPesmuForm : Form
    {
        PesmaBasic pesma;
        public DodajPesmuForm()
        {
            InitializeComponent();
            pesma = new PesmaBasic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajPesmuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPesma_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu pesmu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.pesma.Naziv = textBoxNazivPesme.Text;
                this.pesma.Tekst = textBoxTekstPesme.Text;

                DTOManager.DodajPesmu(this.pesma);
                MessageBox.Show("Uspesno ste dodali novu pesmu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

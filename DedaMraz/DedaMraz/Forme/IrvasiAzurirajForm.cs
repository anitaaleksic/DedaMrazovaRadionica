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
    public partial class IrvasiAzurirajForm : Form
    {
        public IrvasBasic irvasi;
        public IrvasiAzurirajForm()
        {
            InitializeComponent();
           
        }
        public IrvasiAzurirajForm(IrvasBasic i)
        {
            InitializeComponent();
            this.irvasi = i;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void popuniPodacima()
        {
            textboxAzurirajImeIrvasa.Text = this.irvasi.Ime;
            textboxAzurirajNadimakIrvasa.Text = this.irvasi.Nadimak;
            datetimeAzurirajDatumRodjenja.Value = irvasi.DatumRodjenja;
            if (irvasi.Pol == 'M')
                chkBoxM.Checked = true;
            if (irvasi.Pol == 'Z')
                ChkBoxZ.Checked = true;
        }
        private void IrvasiAzurirajForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnAzurirajIrvasa_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene irvasa?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.irvasi.Ime = textboxAzurirajImeIrvasa.Text;
                this.irvasi.Nadimak = textboxAzurirajNadimakIrvasa.Text;

                this.irvasi.DatumRodjenja = datetimeAzurirajDatumRodjenja.Value;

                if (chkBoxM.Checked == true)
                {
                    irvasi.Pol = 'M';
                }
                if (ChkBoxZ.Checked == true)
                {
                    irvasi.Pol = 'Z';
                }
                DTOManager.azurirajIrvasa(this.irvasi);
                MessageBox.Show("Uspesno ste azurirali Irvasa!");
                this.Close();
            }
            else
            {

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

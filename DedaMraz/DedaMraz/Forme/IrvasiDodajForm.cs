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
    public partial class IrvasiDodajForm : Form
    {
        IrvasBasic irvasi;
        public IrvasiDodajForm()
        {
            InitializeComponent();
            irvasi = new IrvasBasic();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajIrvasa_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate irvasa?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.irvasi.Ime = textboxImeIrvasa.Text;
                this.irvasi.Nadimak = textboxNadimakIrvasa.Text;

                this.irvasi.DatumRodjenja = datetimeDatumRodjenjaIrvasa.Value;

                if(checkboxM.Checked==true)
                {
                    irvasi.Pol = 'M';
                }
                if (checkboxZ.Checked == true)
                {
                    irvasi.Pol = 'Z';
                }
                DTOManager.dodajIrvasa(this.irvasi);
                MessageBox.Show("Uspesno ste dodali novog Irvasa!");
                this.Close();
            }
            else
            {

            }
        }

        private void IrvasiDodajForm_Load(object sender, EventArgs e)
        {

        }
    }
}

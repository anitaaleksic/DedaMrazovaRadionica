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
    public partial class DodajVilenjakaPoklonForm : Form
    {
        VilenjakPokloniBasic vilenjakpoklon;
        public DodajVilenjakaPoklonForm()
        {
            InitializeComponent();
            vilenjakpoklon = new VilenjakPokloniBasic();
        }


        private void DodajVilenjakaPoklonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVilenjakaPoklon_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate vilenjaka za poklone?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vilenjakpoklon.Ime = textBoxIme.Text;
                this.vilenjakpoklon.RadniStaz = textBoxRadniStaz.Text;
                this.vilenjakpoklon.ZemljaPorekla = textBoxZemljaPorekla.Text;

                DTOManager.DodajVilenjakaPoklon(this.vilenjakpoklon);
                MessageBox.Show("Uspesno ste dodali novog vilenjaka za poklone!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

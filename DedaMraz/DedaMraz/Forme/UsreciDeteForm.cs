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
    public partial class UsreciDeteForm : Form
    {
        public UsreciDeteForm()
        {
            InitializeComponent();
        }

        
        private void btnSpakujPoklon_Click(object sender, EventArgs e)
        {
            DodajPoklonForm forma = new DodajPoklonForm();
            forma.ShowDialog();
        }

        private void btnNapraviIgracku_Click(object sender, EventArgs e)
        {
            DodajIgrackuForm forma = new DodajIgrackuForm();
            forma.ShowDialog();
        }

        private void btnPosaljiTovar_Click(object sender, EventArgs e)
        {
            DodajTovarForm posaljiTovarForm = new DodajTovarForm();
            posaljiTovarForm.ShowDialog();
        }

        private void UsreciDeteForm_Load(object sender, EventArgs e)
        {

        }
    }
}

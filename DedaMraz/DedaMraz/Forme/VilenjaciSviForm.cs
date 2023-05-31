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
    public partial class VilenjaciSviForm : Form
    {
        public VilenjaciSviForm()
        {
            InitializeComponent();
        }

        private void VilenjaciSviForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVilenjaciIgracke_Click(object sender, EventArgs e)
        {
            VilenjaciIgrackeForm forma = new VilenjaciIgrackeForm();
            forma.ShowDialog();
        }

        private void btnVilenjaciPokloni_Click(object sender, EventArgs e)
        {
            VilenjaciPokloniForm forma = new VilenjaciPokloniForm();
            forma.ShowDialog();
        }

        private void btnVilenjaciTovar_Click(object sender, EventArgs e)
        {
            VilenjaciTovarForm forma = new VilenjaciTovarForm();
            forma.ShowDialog();
        }

        private void btnVilenjaciIrvasi_Click(object sender, EventArgs e)
        {
            VilenjaciIrvasiForm forma = new VilenjaciIrvasiForm();
            forma.ShowDialog();
        }

        private void groupBoxVilenjaci_Enter(object sender, EventArgs e)
        {

        }
    }
}

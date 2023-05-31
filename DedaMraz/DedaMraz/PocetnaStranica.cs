using DedaMraz.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMraz
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnRadionica_Click(object sender, EventArgs e)
        {
            RadionicaForm forma = new RadionicaForm();
            forma.ShowDialog();
        }


        private void btnVilenjaci_Click(object sender, EventArgs e)
        {
            VilenjaciSviForm forma = new VilenjaciSviForm();
            forma.ShowDialog();
        }

        private void btnIrvasi_Click(object sender, EventArgs e)
        {
            IrvasiForm forma = new IrvasiForm();
            forma.ShowDialog();
        }

        private void btnTovar_Click(object sender, EventArgs e)
        {
            PokloniForm forma= new PokloniForm();
            forma.ShowDialog();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }

        private void btnDeca_Click(object sender, EventArgs e)
        {
            DeteForm forma = new DeteForm();
            forma.ShowDialog();
        }

        private void btnPosaljiPismo_Click(object sender, EventArgs e)
        {
            DodajPismoForm forma = new DodajPismoForm();
            forma.ShowDialog();
        }


        private void btnUsreciDete_Click(object sender, EventArgs e)
        {
            UsreciDeteForm forma= new UsreciDeteForm();
            forma.ShowDialog();
        }
    }
}

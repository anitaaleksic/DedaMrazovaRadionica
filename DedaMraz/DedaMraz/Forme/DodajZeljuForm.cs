using DedaMraz.Entiteti;
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
    public partial class DodajZeljuForm : Form
    {
        ZeljaBasic zelja;
        Pismo pismo;
        int idPisma;
        public DodajZeljuForm()
        {
            InitializeComponent();
            zelja = new ZeljaBasic();
        }
        public DodajZeljuForm(Pismo p)
        {
            InitializeComponent();
            zelja = new ZeljaBasic();
            pismo = p;
        }

        public DodajZeljuForm(int id)
        {
            InitializeComponent();
            zelja = new ZeljaBasic();
            idPisma = id;
        }
        private void btnDodajZelju_Click(object sender, EventArgs e)
        {

            this.zelja.Naziv = textboxZelja1.Text;

            DTOManager.dodajZelju(this.zelja, idPisma);

            this.Close();

        }

        private void btnPosaljiPismo_Click(object sender, EventArgs e)
        {
            
        }

        private void DodajZeljuForm_Load(object sender, EventArgs e)
        {

        }
    }
}

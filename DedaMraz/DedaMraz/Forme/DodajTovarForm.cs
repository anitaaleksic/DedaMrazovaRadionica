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
    public partial class DodajTovarForm : Form
    {
        TovarBasic tovar;
        public DodajTovarForm()
        {
            tovar = new TovarBasic();
            InitializeComponent();
        }


        private void PosaljiTovarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPosaljiTovar_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da posaljete tovar?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.tovar.Grad = textboxGrad.Text;


               

                DTOManager.DodajTovar(this.tovar);


                MessageBox.Show("Uspesno ste poslali tovar!");
                this.Close();
            }
            else
            {

            }
        }
    }
}

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
    public partial class DodajPismoForm : Form
    {
        PismoBasic pismo;
        public DodajPismoForm()
        {
            pismo = new PismoBasic();
            InitializeComponent();
        }

        void popuniPodacima()
        {
            List<DetePregled> listaDece = DTOManager.vratiSvuDecu();
            foreach (DetePregled s in listaDece)
            {
                comboDete.Items.Add(s);
            }
        }
        private void PosaljiPismoForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void richTextBoxTekstPisma_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//dodaj dete btn
        {
            DodajDeteForm forma = new DodajDeteForm();
            forma.ShowDialog();
        }

        private void btnDeca_Click(object sender, EventArgs e)//posalji pismo btn
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//napravi listu zelja btn
        {
            string poruka = "Da li zelite da posaljete pismo? Napravite listu zelja!";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.pismo.DatumPrijema = datetimeDatumPrijema.Value;
                this.pismo.DatumSlanja = dateTimeDatumSlanja.Value;
                this.pismo.Tekst = textBox1.Text;
                this.pismo.IndeksDobrote = (float)numIndeksDobrote.Value;
                DetePregled t = (DetePregled)comboDete.SelectedItem;
                
                DTOManager.PosaljiPismo(this.pismo, t);
                
                this.Close();
            }
            
        }
    }
}

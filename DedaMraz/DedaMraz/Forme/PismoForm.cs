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
    public partial class PismoForm : Form
    {       
        DeteBasic dete;
        PismoBasic pismo;
        public PismoForm()
        {
            InitializeComponent();
        }

        public PismoForm(DeteBasic d)
        {
            InitializeComponent();
            dete = d;
        }
        private void PismoForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewPisma.Items.Clear();
            List<PismoBasic> svaPisma = DTOManager.vratiSvaPismaDeteta(dete.ID);
            foreach(PismoBasic psm in svaPisma)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    psm.ID.ToString(),
                    psm.DatumSlanja.ToString(),
                    psm.DatumPrijema.ToString(),
                    psm.IndeksDobrote.ToString()
                });
                listViewPisma.Items.Add(item);
            }

            
            listViewPisma.Refresh();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListaZelja_Click(object sender, EventArgs e)
        {
            if(listViewPisma.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dete cija pisma zelite da vidite!");
                return;
            }
            int idPisma = Int32.Parse(listViewPisma.SelectedItems[0].SubItems[0].Text);
            PismoBasic pismo = DTOManager.vratiPismo(idPisma);
            ListaZeljaForm forma = new ListaZeljaForm(pismo);
            forma.ShowDialog();
        }

        

        private void btnPoklon_Click_1(object sender, EventArgs e)
        {
            if (listViewPisma.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dete cije poklone zelite da vidite!");
                return;
            }
            int idPisma = Int32.Parse(listViewPisma.SelectedItems[0].SubItems[0].Text);
            PismoBasic pismo = DTOManager.vratiPismo(idPisma);
            PokloniForm forma = new PokloniForm();
            forma.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btnPrikaziTekst_Click(object sender, EventArgs e)
        {
            if (listViewPisma.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pismo za koje zelite da vidite tekst!");
                return;
            }
            int idPisma = Int32.Parse(listViewPisma.SelectedItems[0].SubItems[0].Text);
            PismoBasic pismo = DTOManager.vratiPismo(idPisma);

            textBox1.Text = pismo.Tekst;
        }
    }
}

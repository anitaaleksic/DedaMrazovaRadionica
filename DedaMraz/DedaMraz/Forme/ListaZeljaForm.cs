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
    public partial class ListaZeljaForm : Form
    {
        ZeljaBasic zelja;
        PismoBasic pismo;
        public ListaZeljaForm()
        {
            InitializeComponent();
            zelja = new ZeljaBasic();
        }

        public ListaZeljaForm(PismoBasic p)
        {
            InitializeComponent();
            pismo = p;
            zelja = new ZeljaBasic();
        }

        void popunipodacima()
        {
            listazelja.Items.Clear();

            List<ZeljaPregled> zelje = DTOManager.vratiSveZeljeZaPismo(pismo.ID);

            foreach (ZeljaPregled z in zelje)
            {
                ListViewItem item = new ListViewItem(new string[] { z.ID.ToString(), z.Naziv });
                listazelja.Items.Add(item);               

            }

            listazelja.Refresh();
        }

        private void ListaZeljaForm_Load(object sender, EventArgs e)
        {
            popunipodacima();
        }

        private void listazelja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIgracka_Click(object sender, EventArgs e)
        {
            if (listazelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zelju za koju zelite da prikazete igracku!");
                return;
            }
            int id = Int32.Parse(listazelja.SelectedItems[0].SubItems[0].Text);
            zelja = DTOManager.vratiZelju(id);
            IgrackaBasic igracka = DTOManager.vratiIgracku(zelja.IDIgracke.ID);
            MessageBox.Show($"ID: {igracka.ID}\nRedni broj na listi zelja: {igracka.RedniBroj}\nTip: {igracka.Tip}\nOpis: {igracka.Opis}\n");
        }

        private void btnPoklon_Click(object sender, EventArgs e)
        {
            if (listazelja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zelju za koju zelite da prikazete igracku!");
                return;
            }
            int id = Int32.Parse(listazelja.SelectedItems[0].SubItems[0].Text);
            zelja = DTOManager.vratiZelju(id);
            PoklonBasic poklon = DTOManager.vratiPoklon(zelja.SeOdnosiNaPoklon.ID);
            MessageBox.Show($"ID: {poklon.ID}\nPosveta: {poklon.Posveta}\nBoja: {poklon.Boja}\n");
        }
    }
}

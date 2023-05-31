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
    public partial class VilenjaciTovarForm : Form
    {
        public VilenjaciTovarForm()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {

            vilenjacitovar.Items.Clear();
            List<VilenjakTovarBasic> podaci = DTOManager.vratiSveVilenjakeTovare();



            foreach (VilenjakTovarBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Ime, p.ZemljaPorekla, p.RadniStaz });
                vilenjacitovar.Items.Add(item);

            }

            this.vilenjacitovar.Refresh();
        }
        private void VilenjaciTovarForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajVilenjakTovarForm forma = new DodajVilenjakTovarForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiVilenjakaTovar_Click(object sender, EventArgs e)
        {
            if (vilenjacitovar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vilenjaka za tovar kojeg zelite da obrisete!");
                return;
            }

            int idvilenjaka = Int32.Parse(vilenjacitovar.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vilenjaka?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVilenjakaTovar(idvilenjaka);
                MessageBox.Show("Brisanje vilenjaka za tovar je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void vilenjacitovar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

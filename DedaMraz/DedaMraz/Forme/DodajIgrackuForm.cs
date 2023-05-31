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
    public partial class DodajIgrackuForm : Form
    {
        IgrackaBasic igracka;
        public DodajIgrackuForm()
        {
            InitializeComponent();
            igracka = new IgrackaBasic();
            //comboBoxIzradio.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void btnDodajPoklon_Click(object sender, EventArgs e)
        {
            DodajPoklonForm spakujPoklonForm = new DodajPoklonForm();
            spakujPoklonForm.ShowDialog();
        }

        private void DodajIgrackuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<ZeljaBasic> zelje = DTOManager.vratiSveZeljeSaNull();
            foreach(ZeljaBasic zelja in zelje)
            {
                if(zelja.IDIgracke == null)
                {
                    comboBoxZelja.Items.Add(zelja);
                }
            }
            List<DeoRadioniceBasic> deloviRadionica = DTOManager.vratiSveDeloveRadioniceBasic();
            foreach(DeoRadioniceBasic d in deloviRadionica)
            {
                comboBoxTip.Items.Add(d.TipIgracaka);
            }

            
            List<VilenjakIgrackeBasic> vilenjaci = DTOManager.vratiSveVilenjakeIgracke();
            foreach (VilenjakIgrackeBasic v in vilenjaci)
            {
                comboBoxIzradio.Items.Add(v);
            }

            List<PoklonBasic> pokloni = DTOManager.vratiSvePokloneBasic();
            foreach(PoklonBasic p in pokloni)
            {
                comboBoxSifraPoklona.Items.Add(p);
            }
            
        }

        private void btnNapraviIgracku_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate igracku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                igracka.RedniBroj = (int)numRedniBroj.Value;
                igracka.Tip = comboBoxTip.SelectedItem?.ToString();
                ZeljaBasic z = (ZeljaBasic)comboBoxZelja.SelectedItem;
                VilenjakIgrackeBasic v = (VilenjakIgrackeBasic)comboBoxIzradio.SelectedItem;
                PoklonBasic p = (PoklonBasic)comboBoxSifraPoklona.SelectedItem;
                igracka.Opis = textBoxOpis.Text;

                DTOManager.dodajIgracku(igracka, z, v, p);
                MessageBox.Show("Uspesno ste napravili igracku!");
                this.Close();
            }
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DeoRadioniceBasic> deloviRadionica = DTOManager.vratiSveDeloveRadioniceBasic();
            string tipIgracke = comboBoxTip.SelectedItem?.ToString();

            foreach (DeoRadioniceBasic d in deloviRadionica)
            {
                if (d.TipIgracaka == tipIgracke)
                {
                    comboBoxIzradio.Items.Clear();
                    List<VilenjakIgrackeBasic> vilenjaci = DTOManager.vratiSveVilenjakeIgrackeZaDeoRadionice(d.ID);
                    foreach (VilenjakIgrackeBasic v in vilenjaci)
                    {
                        comboBoxIzradio.Items.Add(v);
                    }
                }
            }
        }*/
    }
}

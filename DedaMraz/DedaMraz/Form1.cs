using DedaMraz.Entiteti;
using NHibernate;
using DedaMrazovaRadionica;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPrikaziDete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Dete d = s.Load<Dete>(1);

                MessageBox.Show(d.Ime);
                //MessageBox.Show(d.ImeOca);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Pismo o = s.Load<Pismo>(1);

                MessageBox.Show(o.Tekst);
                MessageBox.Show(o.PoslaloDete.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici sa zadatim brojem
                Dete d = s.Load<Dete>(1);

                foreach (Pismo p in d.SaljePisma)
                {
                    MessageBox.Show(p.Tekst + " "+ p.IndeksDobrote);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void btnManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIrvasi r1 = s.Load<VilenjakIrvasi>(11);

                foreach (Entiteti.Pesma p1 in r1.ZnaPesme)
                {
                    MessageBox.Show(p1.Tekst);
                }


                Entiteti.Pesma p2 = s.Load<Entiteti.Pesma>(1);

                foreach (VilenjakIrvasi r2 in p2.ZnajuVilenjaci)
                {
                    MessageBox.Show(r2.Ime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }*/

        private void btnDodajDeoRadionice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                DeoRadionice d = new DeoRadionice()
                {
                    Naziv = "Deo za knjige",
                    BrojVilenjaka = 15,
                    TipIgracaka="Knjige"

                };

                VilenjakIgracke v = new VilenjakIgracke()
                {
                    Ime = "Ren",
                    SpecijalizovanZa = "Knjige",
                    Sef = "Da",
                    TrajanjeObuke = "6 meseci",
                    Koordinator = "Ne",
                    Mentor = "Ne",
                    Ocena = 7

                };

                d.Sef = v;
                s.Save(v);

                s.Save(d);

                
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnablePerClass_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Vilenjak");

                //IList<Vilenjak> vilenjaci = s
                //IList<Vilenjak> vilenjaci = q.List<Vilenjak>().Where<Vilenjak>
                //IList<Vilenjak> vilenjaci = q.List<Vilenjak>().Where(p => p.Ime == "Petar");

                /*foreach (Vilenjak v in vilenjaci)
                {

                }*/


                /*ISession s = DataLayer.GetSession();


                IList<Vilenjak> vilenjaci = s.QueryOver<VilenjakIgracke>()
                                                .Where(p => p.Ime == "Petar")
                                                .List<Vilenjak>();

                VilenjakIgracke v = (VilenjakIgracke)vilenjaci[0];

                Console.WriteLine(vilenjaci[0].Ime+ vilenjaci[0].RadniStaz);
                s.Close();



            }*/
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVratiSefa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //VilenjakIgracke v = s.Load<VilenjakIgracke>
                DeoRadionice r = s.Load<DeoRadionice>(3);
                VilenjakIgracke sef = r.Sef;
                MessageBox.Show(sef.Ime);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

using DedaMraz.Entiteti;
using DedaMraz.Forme;
using DedaMrazovaRadionica;
using NHibernate;
using NHibernate.Proxy;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DedaMraz
{
    public class DTOManager
    {
        #region DeoRadionice

        public static List<DeoRadionicePregled> vratiSveDeloveRadionice()
        {
            List<DeoRadionicePregled> deloviRadionice = new List<DeoRadionicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DeoRadionice> sviDeloviRadionice = from o
                                                               in s.Query<DeoRadionice>()
                                                               select o;

                VilenjakIgrackeBasic sef = null;
                foreach (DeoRadionice dr in sviDeloviRadionice)
                {
                    if(dr.Sef != null)
                    {
                        sef = DTOManager.vratiVilenjakaIgracke(dr.Sef.ID);
                    }
                    
                    deloviRadionice.Add(new DeoRadionicePregled(dr.ID, dr.Naziv, dr.BrojVilenjaka, dr.TipIgracaka, sef));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih delova radionice: {ex.Message}");
            }
            return deloviRadionice;
        }

        public static List<DeoRadioniceBasic> vratiSveDeloveRadioniceBasic()
        {
            List<DeoRadioniceBasic> deloviRadionice = new List<DeoRadioniceBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DeoRadionice> sviDeloviRadionice = from o
                                                               in s.Query<DeoRadionice>()
                                                               select o;


                foreach (DeoRadionice dr in sviDeloviRadionice)
                {
                    VilenjakIgrackeBasic sef = null;
                    if (dr.Sef != null)
                    {
                        sef = DTOManager.vratiVilenjakaIgracke(dr.Sef.ID);
                    }
                    
                    deloviRadionice.Add(new DeoRadioniceBasic(dr.ID, dr.Naziv, dr.BrojVilenjaka, dr.TipIgracaka, dr.DatumPostavljanja, sef));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih delova radionice: {ex.Message}");
            }
            return deloviRadionice;
        }

        public static void dodajDeoRadionice(DeoRadioniceBasic dr, VilenjakIgrackeBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DeoRadionice o = new DeoRadionice();
                
                o.Naziv = dr.Naziv;
                o.BrojVilenjaka = dr.BrojVilenjaka;
                o.TipIgracaka = dr.TipIgracaka;
                
                VilenjakIgracke sef = s.Load<VilenjakIgracke>(v.ID);
                o.Sef = sef; 

                sef.JeSef = o;
                sef.RasporedjenURadionicu = o;
                o.DatumPostavljanja = dr.DatumPostavljanja;
                s.SaveOrUpdate(o);
                sef.JeSef = o;
                s.SaveOrUpdate(sef);
                s.Flush();

                s.Close();
                MessageBox.Show("Uspesno ste dodali novi Deo radionice!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja dela radionice: {ex.Message}");
            }
        }

        public static DeoRadioniceBasic azurirajDeoRadionice(DeoRadioniceBasic dr, VilenjakIgrackeBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DeoRadionice o = s.Load<DeoRadionice>(dr.ID);
                o.Naziv = dr.Naziv;
                o.BrojVilenjaka = dr.BrojVilenjaka;
                o.TipIgracaka = dr.TipIgracaka;
                VilenjakIgracke sef = s.Load<VilenjakIgracke>(v.ID);
                o.Sef = sef;
                sef.JeSef = o;
          

                s.SaveOrUpdate(o);
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja dela radionice: {ex.Message}");
            }

            return dr;
        }
        public static DeoRadioniceBasic vratiDeoRadionice(int id)
        {
            DeoRadioniceBasic dr = new DeoRadioniceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                DeoRadionice o = s.Load<DeoRadionice>(id);
                dr = new DeoRadioniceBasic(o.ID, o.Naziv, o.BrojVilenjaka, o.TipIgracaka, o.DatumPostavljanja);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja dela radionice: {ex.Message}");
            }
            return dr;
        }
        public static void obrisiDeoRadionice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DeoRadionice deoRadionice = s.Load<DeoRadionice>(id);
                
                

                
                IEnumerable<Zahteva> z = from o in s.Query<Zahteva>() 
                                         where o.DeoRadionice == deoRadionice
                                         select o;
                foreach(Zahteva p in z)
                {
                    s.Delete(p);
                }

                deoRadionice.Sef.RasporedjenURadionicu = null;
                deoRadionice.RasporedjeniVilenjaci.Clear();

                s.Delete(deoRadionice);
              
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja dela radionice: {ex.Message}");
            }
        }

        #endregion

        #region Dete

        public static DeteBasic vratiDete(int id)
        {
            DeteBasic de = new DeteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Dete d = s.Load<Dete>(id);
                de = new DeteBasic(d.ID, d.Ime, d.Prezime, d.DatumRodjenja, d.Drzava, d.Grad, d.Adresa, d.ImeMajke, d.ImeOca);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja deteta: {ec.Message}");
            }

            return de;
        }
        public static List<DetePregled> vratiSvuDecu()
        {
            List<DetePregled> deca = new List<DetePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Dete> svadeca = from o in s.Query<Dete>()
                                            select o;

                foreach (Dete d in svadeca)
                {
                    deca.Add(new DetePregled(d.ID, d.Ime, d.Prezime, d.DatumRodjenja, d.Drzava, d.Grad, d.Adresa));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja dece: {ec.Message}");
            }

            return deca;
        }
        public static void dodajDete(DeteBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dete o = new Dete();

                o.Ime = d.Ime;
                o.Prezime = d.Prezime;
                o.ImeMajke = d.ImeMajke;
                o.ImeOca = d.ImeOca;
                o.DatumRodjenja = d.DatumRodjenja;
                o.Adresa = d.Adresa;
                o.Drzava = d.Drzava;
                o.Grad = d.Grad;



                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();
                MessageBox.Show("Uspesno ste dodali novo Dete!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja deteta: {ex.Message}");
            }
        }
        #endregion

        #region Igracka
        public static List<IgrackaPregled> vratiSveIgracke()
        {
            List<IgrackaPregled> igracke = new List<IgrackaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Igracka> sveIgracke = from o in s.Query<Igracka>()
                                                  select o;

                foreach(Igracka i in sveIgracke)
                {
                    PoklonBasic poklon = DTOManager.vratiPoklon(i.SpakovanaUPoklon.ID);
                    VilenjakIgrackeBasic vilenjak = DTOManager.vratiVilenjakaIgracke(i.IzradioJeVilenjak.ID);
                    igracke.Add(new IgrackaPregled(i.ID, i.RedniBroj, i.Tip, i.Opis, poklon, vilenjak));
                }
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih igracaka: {ex.Message}");
            }
            return igracke;
        }

        public static IgrackaBasic vratiIgracku(int id)
        {
            IgrackaBasic igracka = new IgrackaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Igracka i = s.Load<Igracka>(id);

                PoklonBasic poklon = null;
                VilenjakIgrackeBasic vilenjak = null;
                if(i.SpakovanaUPoklon != null)
                {
                    poklon = DTOManager.vratiPoklon(i.SpakovanaUPoklon.ID);
                }
                if(i.IzradioJeVilenjak != null)
                {
                    vilenjak = DTOManager.vratiVilenjakaIgracke(i.IzradioJeVilenjak.ID);
                }
                igracka = new IgrackaBasic(i.ID, i.RedniBroj, i.Tip, i.Opis, poklon, vilenjak);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja igracke: {ex.Message}");
            }
            return igracka;
        }

        public static void dodajIgracku(IgrackaBasic i, ZeljaBasic z, VilenjakIgrackeBasic v, PoklonBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igracka igracka = new Igracka();

                igracka.RedniBroj = i.RedniBroj;
                igracka.Opis = i.Opis;
                igracka.Tip = i.Tip;
                VilenjakIgracke vil = s.Load<VilenjakIgracke>(v.ID);
                Poklon pok = s.Load<Poklon>(p.ID);
                igracka.SpakovanaUPoklon = pok;
                igracka.IzradioJeVilenjak = vil;

                s.SaveOrUpdate(igracka);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja igracke: {ex.Message}");
            }
        }

        #endregion

        #region Irvas
        public static void dodajIrvasa(IrvasBasic i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Irvas o = new Irvas();

                o.Ime = i.Ime;
                o.Nadimak = i.Nadimak;
                o.Pol = i.Pol;
                o.DatumRodjenja = i.DatumRodjenja;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja irvasa: {ec.Message}");
            }
        }
        public static List<IrvasPregled> vratiSveIrvase()
        {
            List<IrvasPregled> irvasi = new List<IrvasPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Irvas> sviirvasi = from o in s.Query<Irvas>()
                                               select o;

                foreach (Irvas i in sviirvasi)
                {
                    irvasi.Add(new IrvasPregled(i.ID, i.Ime, i.Nadimak, i.Pol, i.DatumRodjenja));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja irvasa : {ec.Message}");
            }

            return irvasi;
        }
        public static void obrisiIrvasa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Irvas i = s.Load<Irvas>(id);

                var vilenjaci = s.Query<VilenjakIrvasi>().Where(v => v.ZaduzenZaIrvasa == i).ToList();


                foreach (VilenjakIrvasi vil in vilenjaci)
                {
                    vil.ZaduzenZaIrvasa = null;
                }

                s.Flush();

                s.Delete(i);
                
                s.Flush();
                
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja irvasa: {ec.Message}");
            }
        }
        public static IrvasBasic vratiIrvasa(int id)
        {
            IrvasBasic ir = new IrvasBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Irvas o = s.Load<Irvas>(id);
                ir = new IrvasBasic(o.ID, o.Ime, o.Nadimak, o.Pol, o.DatumRodjenja);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja irvasa: {ec.Message}");
            }

            return ir;
        }
        public static IrvasBasic azurirajIrvasa(IrvasBasic i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Irvas o = s.Load<Irvas>(i.ID);
                o.Ime = i.Ime;
                o.Nadimak = i.Nadimak;
                o.Pol = i.Pol;
                o.DatumRodjenja = i.DatumRodjenja;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja irvasa: {ec.Message}");
            }

            return i;
        }

        #endregion

        #region MagicnaVestina

        public static List<MagicnaVestinaPregled> vratiSveMagicneVestineZaDeoRadionice(int id)
        {
            List<MagicnaVestinaPregled> magicneVestine = new List<MagicnaVestinaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zahteva> zahteva = from o in s.Query<Zahteva>()
                                               where o.DeoRadionice.ID == id
                                               select o;
                foreach(Zahteva z in zahteva)
                {
                    magicneVestine.Add(new MagicnaVestinaPregled(z.MagicnaVestina.ID));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih magicnih vestina: {ex.Message}");
            }
            return magicneVestine;
        }
        public static MagicnaVestinaBasic vratiMagicnuVestinu(int id)
        {
            MagicnaVestinaBasic magicnaVestina = new MagicnaVestinaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MagicnaVestina mv = s.Load<MagicnaVestina>(id);
                magicnaVestina = new MagicnaVestinaBasic(mv.ID);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja magicne vestine: {ex.Message}");
            }
            return magicnaVestina;
        }
        public static void dodajMagicnuVestinu(MagicnaVestinaBasic magicnaVestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagicnaVestina mv = new MagicnaVestina();

                mv.ID = magicnaVestina.ID;

                s.SaveOrUpdate(mv);

                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja magicne vestine: {ex.Message}");
            }
        }

        public static MagicnaVestinaBasic azurirajMagicnuVestinu(MagicnaVestinaBasic magicnaVestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagicnaVestina mv = s.Load<MagicnaVestina>(magicnaVestina.ID);

                mv.ID = magicnaVestina.ID;

                s.Update(mv);

                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja magicne vestine: {ex.Message}");
            }
            return magicnaVestina;
        }

        public static void obrisiMagicnuVestinu(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagicnaVestina mv = s.Load<MagicnaVestina>(id);

                s.Delete(mv);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja magicne vestine: {ex.Message}");
            }
        }
        #endregion

        #region Pesma
        public static PesmaBasic vratiPesmu(int id)
        {
            PesmaBasic pe = new PesmaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Pesma p = s.Load<Pesma>(id);
                pe = new PesmaBasic(p.ID, p.Naziv, p.Tekst);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesme: {ec.Message}");
            }

            return pe;
        }
        public static List<PesmaPregled> vratiSvePesme()
        {
            List<PesmaPregled> pesme = new List<PesmaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pesma> svepesme = from o in s.Query<Pesma>()
                                              select o;

                foreach (Pesma p in svepesme)
                {
                    pesme.Add(new PesmaPregled(p.ID, p.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesama: {ec.Message}");
            }

            return pesme;
        }
        public static List<PesmaPregled> vratiSvePesmeZaVilenjaka(VilenjakIrvasiBasic v)
        {
            List<PesmaPregled> pesme = new List<PesmaPregled>();
            List<VilenjakZnaPesmuPregled> zna = new List<VilenjakZnaPesmuPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIrvasi vil = s.Load<VilenjakIrvasi>(v.ID);

                IEnumerable<VilenjakZnaPesmu> znaPesme = from o in s.Query<VilenjakZnaPesmu>()
                                                         where o.VilenjakIrvasi == vil
                                                         select o;

                foreach(VilenjakZnaPesmu e in znaPesme)
                {
                    pesme.Add(new PesmaPregled(e.Pesma.ID, e.Pesma.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesama: {ec.Message}");
            }

            return pesme;
        }
        public static void DodajPesmu(PesmaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pesma o = new Pesma();
                o.Naziv = p.Naziv;
                o.Tekst = p.Tekst;
                


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja pesme {ec.Message}");
            }
        }

        #endregion

        #region Pismo
        public static List<PismoPregled> vratiSvaPisma()
        {
            List<PismoPregled> pisma = new List<PismoPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Pismo> svaPisma = from o in session.Query<Pismo>()
                                              select o;

                foreach(Pismo p in svaPisma)
                {
                    DeteBasic dete = DTOManager.vratiDete(p.PoslaloDete.ID);
                    pisma.Add(new PismoPregled(p.ID, p.DatumSlanja, p.DatumPrijema, p.IndeksDobrote, p.Tekst, dete));
                }
                session.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pisma;
        }

        public static List<PismoBasic> vratiSvaPismaDeteta(int idDeteta)
        {
            List<PismoBasic> pisma = new List<PismoBasic>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Pismo> svaPisma = from o in session.Query<Pismo>()
                                              where o.PoslaloDete.ID == idDeteta
                                              select o;

                foreach (Pismo p in svaPisma)
                {
                    DeteBasic dete = DTOManager.vratiDete(p.PoslaloDete.ID);
                    pisma.Add(new PismoBasic(p.ID, p.DatumSlanja, p.DatumPrijema, p.IndeksDobrote, p.Tekst, dete));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pisma;
        }

        public static PismoBasic vratiPismo(int id)
        {
            PismoBasic pismo = new PismoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Pismo p = s.Load<Pismo>(id);
                DeteBasic dete = DTOManager.vratiDete(p.PoslaloDete.ID);
                pismo = new PismoBasic(p.ID, p.DatumSlanja, p.DatumPrijema, p.IndeksDobrote, p.Tekst, dete);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pismo;
        }

        public static PismoBasic vratiPismoDeteta(int id)
        {
            PismoBasic pismo = new PismoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Pismo p = s.Load<Pismo>(id);
                DeteBasic dete = DTOManager.vratiDete(p.PoslaloDete.ID);
                pismo = new PismoBasic(p.ID, p.DatumSlanja, p.DatumPrijema, p.IndeksDobrote, p.Tekst, dete);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pismo;
        }
        public static void PosaljiPismo(PismoBasic p, DetePregled d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pismo o = new Pismo();
                Dete dete = s.Load<Dete>(d.ID);
                

                o.IndeksDobrote = p.IndeksDobrote;
                o.Tekst = p.Tekst;
                o.DatumPrijema = p.DatumPrijema;
                o.DatumSlanja = p.DatumSlanja;

                o.PoslaloDete = dete;
                        
                s.SaveOrUpdate(o);
                int idPisma = o.ID;
                s.Flush();
                s.Close();
                DodajZeljuForm forma = new DodajZeljuForm(idPisma);
                forma.ShowDialog();                
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja pisma: {ec.Message}");
            }
        }
        public static PismoBasic vratitekst(int id)
        {
            PismoBasic pismo = new PismoBasic();
            try
            {

                ISession s = DataLayer.GetSession();

                Pismo z = s.Load<Pismo>(id);

                pismo = new PismoBasic(z.ID, z.DatumSlanja, z.DatumPrijema, z.IndeksDobrote, z.Tekst);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja zelje: {ex.Message}");
            }
            return pismo;
        }

        #endregion

        #region Poklon
        public static List<PoklonPregled> vratiSvePoklone()
        {
            List<PoklonPregled> pokloni = new List<PoklonPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Poklon> sviPokloni = from o in session.Query<Poklon>()
                                                 select o;
                foreach(Poklon p in sviPokloni)
                {
                    TovarBasic tovar = DTOManager.vratiTovar(p.SeNalaziUTovaru.ID);
                    pokloni.Add(new PoklonPregled(p.ID, p.Boja, p.Posveta, tovar));
                }

                session.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih poklona: {ex.Message}");
            }
            return pokloni;
        }
        public static List<PoklonBasic> vratiSvePokloneBasic()
            {
                List<PoklonBasic> pokloni = new List<PoklonBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Poklon> sviPokloni = from o in session.Query<Poklon>()
                                                 select o;
                foreach (Poklon p in sviPokloni)
                {
                    TovarBasic tovar = DTOManager.vratiTovar(p.SeNalaziUTovaru.ID);
                    pokloni.Add(new PoklonBasic(p.ID, p.Boja, p.Posveta, tovar));
                }

                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih poklona: {ex.Message}");
            }
            return pokloni;
        }
        public static List<PoklonPregled> vratiSvePokloneZaDete()
        {
            List<PoklonPregled> pokloni = new List<PoklonPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Poklon> sviPokloni = from o in session.Query<Poklon>()
                                                 select o;
                foreach (Poklon p in sviPokloni)
                {
                    TovarBasic tovar = DTOManager.vratiTovar(p.SeNalaziUTovaru.ID);
                    pokloni.Add(new PoklonPregled(p.ID, p.Boja, p.Posveta, tovar));
                }

                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih poklona: {ex.Message}");
            }
            return pokloni;
        }
       
        public static PoklonBasic vratiPoklon(int id)
        {
            PoklonBasic poklon = new PoklonBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Poklon p = s.Load<Poklon>(id);

                TovarBasic tovar = DTOManager.vratiTovar(p.SeNalaziUTovaru.ID);
                poklon = new PoklonBasic(p.ID, p.Boja, p.Posveta, tovar);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja poklona: {ex.Message}");
            }
            return poklon;
        }
        public static void DodajPoklon(PoklonBasic p, TovarPregled t, VilenjakPokloniPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Poklon o = new Poklon();
                Tovar tov = s.Load<Tovar>(t.ID);
                VilenjakPokloni vil = s.Load<VilenjakPokloni>(v.ID);
                JePakovao jePakovao = new JePakovao();
                
                o.SeNalaziUTovaru = tov;
                o.Posveta = p.Posveta;
                o.Boja = p.Boja;
                jePakovao.VilenjakPokloni = vil;
                jePakovao.Poklon = o;



                s.SaveOrUpdate(o);
                s.SaveOrUpdate(jePakovao);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom pakovanja poklona {ec.Message}");
            }
        }
        #endregion

        #region Tim
        public static TimBasic vratiTim(int id)
        {
            TimBasic t = new TimBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Tim tim = s.Load<Tim>(id);
                VilenjakIgrackeBasic koordinator = DTOManager.vratiVilenjakaIgracke(tim.Koordinator.ID);
                t = new TimBasic(t.ID, koordinator);
                
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja tima: {ex.Message}");
            }
            return t;
        }

        public static List<TimPregled> vratiSveTimove()
        {
            List<TimPregled> tim = new List<TimPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tim> sviTimovi = from o in s.Query<Tim>()
                                             select o;
                VilenjakIgrackeBasic koor = null;
                foreach (Tim t in sviTimovi)
                {
                    if(t.Koordinator != null)
                    {
                        koor = DTOManager.vratiVilenjakaIgracke(t.Koordinator.ID);
                    }                    
                    tim.Add(new TimPregled(t.ID, koor));
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih timova: {ex.Message}");
            }
            return tim;
        }
        public static void dodajTim(TimBasic tim)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tim t = new Tim();
                VilenjakIgracke v = s.Load<VilenjakIgracke>(tim.Koordinator.ID);
                t.Koordinator = v;
                v.Tim = t;


                s.SaveOrUpdate(t);
                s.SaveOrUpdate(v);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
        }


        #endregion

        #region Tovar

        public static List<TovarPregled> vratiSveTovare()
        {
            List<TovarPregled> tovari = new List<TovarPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tovar> sviTovari = from o in s.Query<Tovar>()
                                               select o;

                foreach(Tovar t in sviTovari)
                {
                    tovari.Add(new TovarPregled(t.ID, t.Grad));
                }

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih tovara: {ex.Message}");
            }
            return tovari;
        }

        public static TovarBasic vratiTovar(int id)
        {
            TovarBasic t = new TovarBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Tovar o = s.Load<Tovar>(id);
                t = new TovarBasic(o.ID, o.Grad);

                s.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja tovara: {ex.Message}");
            }
            return t;
        }
        public static void DodajTovar(TovarBasic t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tovar o = new Tovar();

                o.Grad = t.Grad;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom slanja tovara {ec.Message}");
            }
        }
        #endregion

        #region Vilenjak

        #region VilenjakIgracke
        public static List<VilenjakIgrackeBasic> vratiSveVilenjakeIgracke()
        {
            List<VilenjakIgrackeBasic> vilenjaciIgracke = new List<VilenjakIgrackeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIgracke> sviVilenjaciIgracke = from o
                                                                   in s.Query<VilenjakIgracke>()
                                                                   select o;

                foreach (VilenjakIgracke r in sviVilenjaciIgracke)
                {
                    vilenjaciIgracke.Add(new VilenjakIgrackeBasic(r.ID,
                                                                  r.Ime,
                                                                  r.ZemljaPorekla,
                                                                  r.RadniStaz,
                                                                  r.Ocena,
                                                                  r.TrajanjeObuke,
                                                                  r.SpecijalizovanZa,
                                                                  r.Sef,
                                                                  r.Mentor,
                                                                  r.Koordinator));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za igracke: {ex.Message}");
            }

            return vilenjaciIgracke;
        }

        public static List<VilenjakIgrackeBasic> vratiSveVilenjakeIgrackeRadionicaa(int idRad)
        {
            List<VilenjakIgrackeBasic> vilenjaciIgracke = new List<VilenjakIgrackeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIgracke> sviVilenjaciIgracke = from o
                                                                   in s.Query<VilenjakIgracke>()
                                                                   select o;

                foreach (VilenjakIgracke r in sviVilenjaciIgracke)
                {
                    if (r.JeSef != null && r.JeSef.ID == idRad)
                    {
                        vilenjaciIgracke.Add(new VilenjakIgrackeBasic(r.ID,
                                                                      r.Ime,
                                                                      r.ZemljaPorekla,
                                                                      r.RadniStaz,
                                                                      r.Ocena,
                                                                      r.TrajanjeObuke,
                                                                      r.SpecijalizovanZa,
                                                                      r.Sef,
                                                                      r.Mentor,
                                                                      r.Koordinator));
                    }

                    if (r.JeSef == null)
                    {
                        vilenjaciIgracke.Add(new VilenjakIgrackeBasic(r.ID,
                                                                      r.Ime,
                                                                      r.ZemljaPorekla,
                                                                      r.RadniStaz,
                                                                      r.Ocena,
                                                                      r.TrajanjeObuke,
                                                                      r.SpecijalizovanZa,
                                                                      r.Sef,
                                                                      r.Mentor,
                                                                      r.Koordinator));
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za igracke: {ex.Message}");
            }

            return vilenjaciIgracke;
        }
        public static List<VilenjakIgrackeBasic> vratiSveVilenjakeIgrackeZaDeoRadionice(int id)
        {
            List<VilenjakIgrackeBasic> vilenjaciIgracke = new List<VilenjakIgrackeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIgracke> sviVilenjaciIgracke = from o
                                                                   in s.Query<VilenjakIgracke>()
                                                                   where o.RasporedjenURadionicu.ID == id
                                                                   select o;

                foreach (VilenjakIgracke r in sviVilenjaciIgracke)
                {
                    DeoRadioniceBasic rasporedjenURadionicu = null;
                    if (r.RasporedjenURadionicu != null)
                    {
                        rasporedjenURadionicu = DTOManager.vratiDeoRadionice(r.RasporedjenURadionicu.ID);
                    }                    
                    VilenjakIgrackeBasic mentor = null;
                    if(r.IDMentor != null)
                    {
                        mentor = DTOManager.vratiVilenjakaIgracke(r.IDMentor.ID);
                    }
                    TimBasic tim;
                    if (r.Tim!=null)
                    {
                        tim = DTOManager.vratiTim(r.Tim.ID);
                        vilenjaciIgracke.Add(new VilenjakIgrackeBasic(r.ID,
                                                                  r.Ime,
                                                                  r.ZemljaPorekla,
                                                                  r.RadniStaz,
                                                                  r.Ocena,
                                                                  r.TrajanjeObuke,
                                                                  r.SpecijalizovanZa,
                                                                  r.Sef,
                                                                  r.Mentor,
                                                                  r.Koordinator,
                                                                  rasporedjenURadionicu,
                                                                  mentor,
                                                                  tim));
                    }
                    
                    
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za igracke: {ex.Message}");
            }

            return vilenjaciIgracke;
        }
        public static VilenjakIgrackeBasic vratiVilenjakaIgracke(int id)
        {
            VilenjakIgrackeBasic vIgr = new VilenjakIgrackeBasic();
            try
            {
                ISession s = DataLayer.GetSession();


                VilenjakIgracke vi = s.Load<VilenjakIgracke>(id);
                vIgr = new VilenjakIgrackeBasic(vi.ID,
                                                vi.Ime,
                                                vi.ZemljaPorekla,
                                                vi.RadniStaz,
                                                vi.Ocena,
                                                vi.TrajanjeObuke,
                                                vi.SpecijalizovanZa,
                                                vi.Sef,
                                                vi.Mentor,
                                                vi.Koordinator);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za igracke: {ex.Message}");
            }
            return vIgr;
        }
        public static void obrisiVilenjakaIgracke(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIgracke v = s.Load<VilenjakIgracke>(id);

                var igracke = s.Query<Igracka>().Where(p => p.IzradioJeVilenjak == v).ToList();

                foreach(Igracka ig in igracke)
                {
                    ig.IzradioJeVilenjak = null;
                }

                if(v.JeSef != null)
                {
                    DeoRadionice d = s.Load<DeoRadionice>(v.JeSef.ID);

                    d.Sef = null;
                }
                
                if(v.JeKoordinator != null)
                {
                    Tim t = s.Load<Tim>(v.JeKoordinator.ID);

                    t.Koordinator = null;
                }
                

                foreach (VilenjakIgracke vilenjak in v.ObucavaniVilenjaci)
                {
                    vilenjak.Mentor = null;
                }

                IEnumerable<VilenjakPosedujeVestinu> poseduje = from o in s.Query<VilenjakPosedujeVestinu>()
                                                                where o.VilenjakIgracke == v
                                                                select o;
                foreach (VilenjakPosedujeVestinu vil in poseduje)
                {
                    s.Delete(vil);
                }


                s.Flush();
                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za igracke: {ex.Message}");
            }

        }
        public static VilenjakIgrackeBasic azurirajVilenjakaIgracke(VilenjakIgrackeBasic vilIgr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIgracke vIgr = s.Load<VilenjakIgracke>(vilIgr.ID);
                vIgr.Ime = vilIgr.Ime;
                vIgr.ZemljaPorekla = vilIgr.ZemljaPorekla;
                vIgr.RadniStaz = vilIgr.RadniStaz;
                vIgr.Ocena = vilIgr.Ocena;
                vIgr.TrajanjeObuke = vilIgr.TrajanjeObuke;
                vIgr.SpecijalizovanZa = vilIgr.SpecijalizovanZa;
                vIgr.Sef = vilIgr.Sef;
                vIgr.Mentor = vilIgr.Mentor;
                vIgr.Koordinator = vilIgr.Koordinator;

                s.Update(vIgr);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja vilenjaka za igracke: {ex.Message}");
            }
            return vilIgr;
        }
        public static void DodajVilenjakaIgracke(VilenjakIgrackeBasic v, VilenjakIgrackeBasic p,DeoRadionicePregled d,TimPregled t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakIgracke o = new DedaMraz.Entiteti.VilenjakIgracke();

                o.Ime = v.Ime;
                o.Koordinator = v.Koordinator;
                o.Sef = v.Sef;
                o.SpecijalizovanZa = v.SpecijalizovanZa;
                o.TrajanjeObuke = v.TrajanjeObuke;
                o.RadniStaz = v.RadniStaz;
                o.Ocena = v.Ocena;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.Mentor = v.Mentor;
                VilenjakIgracke vil = s.Load<VilenjakIgracke>(p.ID);
                DeoRadionice deo = s.Load<DeoRadionice>(d.ID);
                Tim tim = s.Load<Tim>(t.ID);
                o.RasporedjenURadionicu = deo;
                o.Tim = tim;
                o.IDMentor = vil;
                o.RasporedjenURadionicu.BrojVilenjaka++;
               
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
        }

        public static void DodajVilenjakaIgracke(VilenjakIgrackeBasic v, VilenjakIgrackeBasic p, DeoRadioniceBasic d, TimBasic t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakIgracke o = new DedaMraz.Entiteti.VilenjakIgracke();

                o.Ime = v.Ime;
                o.Koordinator = v.Koordinator;
                o.Sef = v.Sef;
                o.SpecijalizovanZa = v.SpecijalizovanZa;
                o.TrajanjeObuke = v.TrajanjeObuke;
                o.RadniStaz = v.RadniStaz;
                o.Ocena = v.Ocena;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.Mentor = v.Mentor;
                VilenjakIgracke vil = s.Load<VilenjakIgracke>(p.ID);
                DeoRadionice deo = s.Load<DeoRadionice>(d.ID);
                Tim tim = s.Load<Tim>(t.ID);
                o.RasporedjenURadionicu = deo;
                o.Tim = tim;
                o.IDMentor = vil;
                o.RasporedjenURadionicu.BrojVilenjaka++;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
        }

        public static void DodajVilenjakaIgrackeKoor(VilenjakIgrackeBasic v, VilenjakIgrackeBasic p, DeoRadioniceBasic d, TimBasic t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakIgracke o = new DedaMraz.Entiteti.VilenjakIgracke();

                o.Ime = v.Ime;
                o.Koordinator = v.Koordinator;
                o.Sef = v.Sef;
                o.SpecijalizovanZa = v.SpecijalizovanZa;
                o.TrajanjeObuke = v.TrajanjeObuke;
                o.RadniStaz = v.RadniStaz;
                o.Ocena = v.Ocena;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.Mentor = v.Mentor;
                VilenjakIgracke vil = s.Load<VilenjakIgracke>(p.ID);
                DeoRadionice deo = s.Load<DeoRadionice>(d.ID);
                Tim tim = null;
                o.RasporedjenURadionicu = deo;
                o.Tim = tim;
                o.IDMentor = vil;
                o.RasporedjenURadionicu.BrojVilenjaka++;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
        }
        #endregion

        #region VilenjakIrvasi
        public static List<VilenjakIrvasiBasic> VratiSveVilenjakeIrvase()
        {
            List<VilenjakIrvasiBasic> vilenjaciirvas = new List<VilenjakIrvasiBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIrvasi> sviVilenjaciIrvasi = from o in s.Query<VilenjakIrvasi>()
                                                                 select o;

                foreach (VilenjakIrvasi r in sviVilenjaciIrvasi)
                {
                    vilenjaciirvas.Add(new VilenjakIrvasiBasic(r.ID, r.Ime, r.ZemljaPorekla, r.RadniStaz));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za irvase: {ex.Message}");
            }

            return vilenjaciirvas;
        }
        public static List<VilenjakIrvasiBasic> VratiSveVilenjakeZaduzeneZaIrvasa(int id)
        {
            List<VilenjakIrvasiBasic> vilenjaciirvas = new List<VilenjakIrvasiBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIrvasi> sviVilenjaciIrvasi = from o in s.Query<VilenjakIrvasi>()
                                                                 where o.ZaduzenZaIrvasa.ID == id
                                                                 select o;

                foreach (VilenjakIrvasi r in sviVilenjaciIrvasi)
                {
                    IrvasBasic irvas = DTOManager.vratiIrvasa(r.ZaduzenZaIrvasa.ID);
                    vilenjaciirvas.Add(new VilenjakIrvasiBasic(r.ID, r.Ime, r.ZemljaPorekla, r.RadniStaz, irvas));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za irvase: {ex.Message}");
            }

            return vilenjaciirvas;
        }
        public static VilenjakIrvasiBasic vratiVilenjakaIrvasi(int id)
        {
            VilenjakIrvasiBasic vilenjak = new VilenjakIrvasiBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIrvasi v = s.Load<VilenjakIrvasi>(id);
                IrvasBasic irvas = DTOManager.vratiIrvasa(v.ZaduzenZaIrvasa.ID);
                vilenjak = new VilenjakIrvasiBasic(v.ID, v.Ime, v.ZemljaPorekla, v.RadniStaz, irvas);

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za irvase: {ex.Message}");
            }
            return vilenjak;
        }
        public static void obrisiVilenjakaIrvas(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIrvasi r = s.Load<VilenjakIrvasi>(id);

                IEnumerable<VilenjakZnaPesmu> zna = from o in s.Query<VilenjakZnaPesmu>()
                                                    where o.VilenjakIrvasi == r
                                                    select o;
                foreach(VilenjakZnaPesmu v in zna)
                {
                    s.Delete(v);
                }

                r.VilenjakZnaPesmu.Clear();
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za irvase: {ex.Message}");
            }

        }
        public static void DodajVilenjakaIrvas(VilenjakIrvasiBasic v,IrvasPregled i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakIrvasi o = new DedaMraz.Entiteti.VilenjakIrvasi();
                Irvas irv = s.Load<Irvas>(i.ID);
                o.ZaduzenZaIrvasa = irv;
                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za irvase {ec.Message}");
            }
        }
        #endregion

        #region VilenjakPokloni
        public static List<VilenjakPokloniBasic> VratiSveVilenjakePoklone()
        {
            List<VilenjakPokloniBasic> vilenjacipokloni = new List<VilenjakPokloniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakPokloni> sviVilenjaciPokloni = from o in s.Query<VilenjakPokloni>()
                                                                   select o;

                foreach (VilenjakPokloni r in sviVilenjaciPokloni)
                {
                    vilenjacipokloni.Add(new VilenjakPokloniBasic(r.ID, r.Ime, r.ZemljaPorekla, r.RadniStaz));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za poklone: {ex.Message}");
            }

            return vilenjacipokloni;
        }
        public static List<VilenjakPokloniPregled> VratiSveVilenjakePoklonePregled()
        {
            List<VilenjakPokloniPregled> vilenjacipokloni = new List<VilenjakPokloniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakPokloni> sviVilenjaciPokloni = from o in s.Query<VilenjakPokloni>()
                                                                   select o;

                foreach (VilenjakPokloni r in sviVilenjaciPokloni)
                {
                    vilenjacipokloni.Add(new VilenjakPokloniPregled(r.ID, r.Ime, r.ZemljaPorekla, r.RadniStaz));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za poklone: {ex.Message}");
            }

            return vilenjacipokloni;
        }
        public static VilenjakPokloniBasic vratiVilenjakaPokloni(int id)
        {
            VilenjakPokloniBasic vilenjak = new VilenjakPokloniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakPokloni v = s.Load<VilenjakPokloni>(id);

                vilenjak = new VilenjakPokloniBasic(v.ID, v.Ime, v.ZemljaPorekla, v.RadniStaz);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za poklone: {ex.Message}");
            }
            return vilenjak;
        }
        public static void obrisiVilenjakaPokloni(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakPokloni r = s.Load<DedaMraz.Entiteti.VilenjakPokloni>(id);
                 
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za poklone: {ex.Message}");
            }

        }
        public static void DodajVilenjakaPoklon(VilenjakPokloniBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakPokloni o = new DedaMraz.Entiteti.VilenjakPokloni();

                o.Ime = v.Ime;                                       
                o.RadniStaz = v.RadniStaz;              
                o.ZemljaPorekla = v.ZemljaPorekla;
                

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
        }

        #endregion

        #region VilenjakTovar
        public static List<VilenjakTovarBasic> vratiSveVilenjakeTovare()
        {
            List<VilenjakTovarBasic> vilenjacitovari = new List<VilenjakTovarBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakTovar> sviVilenjaciTovari = from o in s.Query<VilenjakTovar>()
                                                                select o;

                foreach (VilenjakTovar r in sviVilenjaciTovari)
                {
                    vilenjacitovari.Add(new VilenjakTovarBasic(r.ID, r.Ime, r.ZemljaPorekla, r.RadniStaz));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za tovar: {ex.Message}");
            }

            return vilenjacitovari;
        }

        public static VilenjakTovarBasic vratiVilenjakaTovar(int id)
        {
            VilenjakTovarBasic vilenjak = new VilenjakTovarBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakTovar v = s.Load<VilenjakTovar>(id);
                TovarBasic tovar = DTOManager.vratiTovar(v.PripremioTovar.ID);
                vilenjak = new VilenjakTovarBasic(v.ID, v.Ime, v.ZemljaPorekla, v.RadniStaz, tovar);

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za tovar: {ex.Message}");
            }
            return vilenjak;
        }


        public static void obrisiVilenjakaTovar(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakTovar r = s.Load<DedaMraz.Entiteti.VilenjakTovar>(id);
                 
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za tovar: {ex.Message}");
            }

        }
        public static void DodajVilenjakaTovar(VilenjakTovarBasic v, TovarPregled t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DedaMraz.Entiteti.VilenjakTovar o = new DedaMraz.Entiteti.VilenjakTovar();
                Tovar tov = s.Load<Tovar>(t.ID);
                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.PripremioTovar = tov;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za tovar: {ec.Message}");
            }
        }
        #endregion

        #endregion

        #region Zelja
        public static List<ZeljaBasic> vratiSveZelje()
        {
            List<ZeljaBasic> listazelja = new List<ZeljaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zelja> zelje = from o in s.Query<Zelja>()
                                           select o;

                foreach (Zelja z in zelje)
                {
                    PismoBasic pismo = DTOManager.vratiPismo(z.PripadaPismu.ID);
                    IgrackaBasic igracka = DTOManager.vratiIgracku(z.IDIgracke.ID);
                    PoklonBasic poklon = DTOManager.vratiPoklon(z.SeOdnosiNaPoklon.ID);
                    listazelja.Add(new ZeljaBasic(z.ID, z.Naziv, pismo, poklon, igracka));
                }
                s.Close();
            }            
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih zelja: {ex.Message}");
            }
            return listazelja;
        }
        public static List<ZeljaBasic> vratiSveZeljeSaNull()
        {
            List<ZeljaBasic> listazelja = new List<ZeljaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zelja> zelje = from o in s.Query<Zelja>()
                                           select o;

                foreach (Zelja z in zelje)
                {
                    IgrackaBasic igracka = null;
                    PoklonBasic poklon = null;
                    PismoBasic pismo = DTOManager.vratiPismo(z.PripadaPismu.ID);
                    if (z.IDIgracke != null)
                    {
                        igracka = DTOManager.vratiIgracku(z.IDIgracke.ID);
                    }
                    if(z.SeOdnosiNaPoklon != null)
                    {
                        poklon = DTOManager.vratiPoklon(z.SeOdnosiNaPoklon.ID);
                    }                    
                    listazelja.Add(new ZeljaBasic(z.ID, z.Naziv, pismo, poklon, igracka));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih zelja: {ex.Message}");
            }
            return listazelja;
        }
        public static List<ZeljaPregled> vratiSveZeljeZaPismo(int id)
        {
            List<ZeljaPregled> listazelja = new List<ZeljaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zelja> zelje = from o in s.Query<Zelja>()
                                           where o.PripadaPismu.ID == id
                                           select o;

                foreach (Zelja z in zelje)
                {
                    PismoBasic pismo = DTOManager.vratiPismo(z.PripadaPismu.ID);
                    IgrackaBasic igracka = DTOManager.vratiIgracku(z.IDIgracke.ID);
                    PoklonBasic poklon = DTOManager.vratiPoklon(z.SeOdnosiNaPoklon.ID);
                    listazelja.Add(new ZeljaPregled(z.ID, z.Naziv, pismo, poklon, igracka));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih zelja: {ex.Message}");
            }
            return listazelja;
        }

        public static ZeljaBasic vratiZelju(int id)
        {
            ZeljaBasic zelja = new ZeljaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zelja z = s.Load<Zelja>(id);

                PismoBasic pismo = DTOManager.vratiPismo(z.PripadaPismu.ID);
                IgrackaBasic igracka = DTOManager.vratiIgracku(z.IDIgracke.ID);
                PoklonBasic poklon = DTOManager.vratiPoklon(z.SeOdnosiNaPoklon.ID);
                zelja = new ZeljaBasic(z.ID, z.Naziv, pismo, poklon, igracka);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja zelje: {ex.Message}");
            }
            return zelja;
        }


        public static ZeljaBasic vratiZeljuString(string naziv)
        {
            ZeljaBasic zelja = new ZeljaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zelja z = s.Load<Zelja>(naziv);

                PismoBasic pismo = DTOManager.vratiPismo(z.PripadaPismu.ID);
                IgrackaBasic igracka = DTOManager.vratiIgracku(z.IDIgracke.ID);
                PoklonBasic poklon = DTOManager.vratiPoklon(z.SeOdnosiNaPoklon.ID);
                zelja = new ZeljaBasic(z.ID, z.Naziv, pismo, poklon, igracka);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja zelje: {ex.Message}");
            }
            return zelja;
        }

        public static void dodajZelju(ZeljaBasic zelja, int idPisma)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zelja z = new Zelja();
                Pismo pismo = s.Load<Pismo>(idPisma);
                z.Naziv = zelja.Naziv;
                z.PripadaPismu = pismo;
                z.SeOdnosiNaPoklon = null;
                z.IDIgracke = null;


                pismo.SadrziZelje.Add(z);
                s.SaveOrUpdate(pismo);
                s.Save(z);
                s.Flush();
                s.Close();

                string poruka = "Zelja je uspesno dodata! Da li zelite da dodate jos neku zelju?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.Yes)
                {
                    DodajZeljuForm forma = new DodajZeljuForm(idPisma);
                    forma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Pismo uspesno poslato!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja zelje: {ex.Message}");
            }
        }

        #endregion
        
        #region Zahteva

        public static List<ZahtevaBasic> vratiSveZahtevaPoRadionici(int idRadionice)
        {
            List<ZahtevaBasic> zahtevano = new List<ZahtevaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zahteva> zahteva = from o in s.Query<Zahteva>()
                                               where o.DeoRadionice.ID == idRadionice
                                               select o;
                foreach (Zahteva z in zahteva)
                {
                    zahtevano.Add(new ZahtevaBasic(z.ID));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do greske prilikom vracanja svih veza zahteva!");
            }
            return zahtevano;
        }
        #endregion
    }
}

using System;
using System.IO;

namespace Project_2011
{
    class Ipod:Khnitoi
    {
        //metavlites
        public int code4;
        string akoustika;
        bool epektashdiskou;
        

        //kataskeuastes

         public Ipod() { }
          public Ipod(string onomasia,string perigrafh,double price,double xroniaeggiisis,string leitourgikosysthma,double varos,double diastaseis,
              double sklirosdiskos, string kartagrafikwn, string kartahxou, int aytonomiabatarias, string eidosbatarias,int code4, string akoustika, bool epektashdiskou)
             : base(onomasia, perigrafh, price, xroniaeggiisis, leitourgikosysthma,
              varos, diastaseis, sklirosdiskos, kartagrafikwn, kartahxou, aytonomiabatarias, eidosbatarias)
            
             {
                 this.code4 = code4;
                 this.epektashdiskou = epektashdiskou;
                 this.akoustika = akoustika;
             }
        //idiothtes
          public int Code4
          {
              set { code4 = value; }
              get { return code4; }
          }
       
        public string Akoustika
        {
            set { akoustika = value; }
            get { return akoustika; }
        }
        public bool Epektashdiskou
        {
            set { epektashdiskou = value; }
            get { return epektashdiskou; }
        }
        //methods
     
        public override void Arxeio()
        {
            StreamWriter arxeio;
            string path = @"C:\Documents and Settings\giannis\Τα έγγραφά μου\Visual Studio 2010\apodixi\Desktop-Αποδηξη.txt";
            arxeio = File.CreateText(path);

            arxeio.WriteLine("------------ΚΑΤΑΣΤΗΜΑ-Α.Ε-----------------");
            
                arxeio.WriteLine("Ονομα πελατη:{0}", Ypologistes.Onomapelati);
            arxeio.WriteLine("Κωδικος Προϊοντος:{0}",Code4);
            arxeio.WriteLine("Oνομασια προιοντος:{0}",Onomasia);
            arxeio.WriteLine("Περιγραφη:{0}",Perigrafh);
            arxeio.WriteLine("Τιμη:{0}",Price);
            arxeio.WriteLine("Χρονια εγγυησης:{0}",Xroniaeggiisis);
            arxeio.WriteLine("........ΕΥΧΑΡΙΣΤΟΥΜΕ ΠΟΥ ΕΠΙΛΕΞΑΤΕ ΤΟ ΚΑΤΑΣΤΗΜΑ-Α.Ε ΓΙΑ ΤΗΝ ΕΞΥΠΗΡΕΤΗΣΗ ΣΑΣ........");

            arxeio.Close();
            
        }

        public override void Kataxwrhsh()
        {
            Console.Write("Κωδικος προιοντος {0}\n", Ypologistes.Code);
            Code4 = Ypologistes.Code;
            Console.Write("Oνομασια προιοντος:");
            Onomasia = Console.ReadLine();
            Console.Write("Περιγραφη:");
            Perigrafh = Console.ReadLine();
            Console.Write("Τιμη:");
            Price = Double.Parse(Console.ReadLine());
            Console.Write("Χρονια εγγυησης:");
            Xroniaeggiisis = Double.Parse(Console.ReadLine());
            Console.Write("Λειτουργικο Συστημα:");
            Leitourgikosysthma = Console.ReadLine();
            Console.Write("Βαρος:");
            Varos = Double.Parse(Console.ReadLine());
            Console.Write("Αυτονομια Μπαταριας:");
            Aytonomiabatarias = Int32.Parse(Console.ReadLine());
            Console.Write("Ειδος Μπαταριας:");
            Eidosbatarias = Console.ReadLine();
            Console.Write("Διαστασεις:");
            Diastaseis = Double.Parse(Console.ReadLine());
            Console.Write("Σκληρός Δίσκος");
            Sklirosdiskos = Double.Parse(Console.ReadLine());
            Console.Write("Καρτα Γραφικων:");
            Kartagrafikwn = Console.ReadLine();
            Console.Write("Καρτα Ηχου:");
            Kartahxou = Console.ReadLine();
            Console.Write("Ακουστικα:");
            Akoustika = Console.ReadLine();
            Console.Write("Επεκταση Δισκου(True/False):");
            Epektashdiskou = Boolean.Parse(Console.ReadLine());
        }
        public override void Ektypwsh()
        {
            Console.Write("\n\nΚωδικος προιοντος" + code4 + "\nOνομασια προιοντος:" + Onomasia
                                    + "\nΠεριγραφη:" + Perigrafh + "\nΤιμη:" + Price
                                    + "\nΧρονια εγγυησης:" + Xroniaeggiisis + "\nΛειτουργικο Συστημα:" + Leitourgikosysthma
                                    + "\nΒαρος:" + Varos + "\nΑυτονομια Μπαταριας:" + Aytonomiabatarias
                                    + "\nΕιδος Μπαταριας:" + Eidosbatarias + "\nΔιαστασεις:" + Diastaseis
                                    + "\nΣκληρός Δίσκος" + Sklirosdiskos + "\nΚαρτα Γραφικων:" + Kartagrafikwn
                                    + "\nΚαρτα Ηχου:" + Kartahxou + "\nAκουστικα:" + Akoustika
                                    + "\nΕπεκταση Δισκου(True/False):" + Epektashdiskou);
        }
    }
}

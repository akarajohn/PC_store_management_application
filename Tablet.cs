using System;
using System.IO;

namespace Project_2011
{
     class Tablet:Khnitoi
    {
        //metablhtes
        public int code2;
        string epeksergasths;
        double sizeothonis;
        double mnimi;
        bool wifi;
        double analisikameras;
        int aisthitires;
        int media;
        bool threeG;

        //kataskeyastes

        public Tablet() {  }
        public Tablet( string onomasia, string perigrafh, double price, double xroniaeggiisis,int code2, string epeksergasths,
            double sizeothonis, double mnimi, string leitourgikosysthma, double varos,
            double diastaseis, bool wifi, double analisikameras,double  sklirosdiskos,string kartagrafikwn,string kartahxou, int aytonomiabatarias, string eidosbatarias, int aisthitires, int media, bool threeG)
            : base( onomasia, perigrafh, price, xroniaeggiisis, leitourgikosysthma,
             varos, diastaseis, sklirosdiskos, kartagrafikwn, kartahxou, aytonomiabatarias, eidosbatarias)
        {
            this.code2 = code2;

            this.epeksergasths = epeksergasths;
            this.sizeothonis = sizeothonis;
            this.mnimi = mnimi;
            this.wifi = wifi;
            this.analisikameras = analisikameras;
            this.aisthitires = aisthitires;
            this.media = media;
            this.threeG = threeG;

        }
        //idiothtes
        public int Code2
        {
            set { code2 = value; }
            get { return code2; }
        }
        public string Epeksergasths
        {
            set { epeksergasths = value; }
            get { return epeksergasths; }
        }
        public double Sizeothonis
        {
            set { sizeothonis = value; }
            get { return sizeothonis; }
        }
        public double Mnimi
        {
            set { mnimi = value; }
            get { return mnimi; }
        }
        public bool Wifi
        {
            set { wifi = value; }
            get { return wifi; }
        }
        public double Analisikameras
        {
            set { analisikameras = value; }
            get { return analisikameras; }
        }
        
        public int Aisthitires
        {
            set { aisthitires = value; }
            get { return aisthitires; }
        }
        public int Media
        {
            set { media = value; }
            get { return media; }
        }
        public bool ThreeG
        {
            set { threeG = value; }
            get { return threeG; }
        }

        //methodoi
       
      
        public override void Arxeio()
        {
           
                StreamWriter arxeio;
                string path = @"C:\Documents and Settings\giannis\Τα έγγραφά μου\Visual Studio 2010\apodixi\Desktop-Αποδηξη.txt";
                arxeio = File.CreateText(path);

                arxeio.WriteLine("------------ΚΑΤΑΣΤΗΜΑ-Α.Ε-----------------");

                arxeio.WriteLine("Ονομα πελατη:{0}", Ypologistes.Onomapelati);
                arxeio.WriteLine("Κωδικος Προϊοντος:{0}", Code2);
                arxeio.WriteLine("Oνομασια προιοντος:{0}", Onomasia);
                arxeio.WriteLine("Περιγραφη:{0}", Perigrafh);
                arxeio.WriteLine("Τιμη:{0}", Price);
                arxeio.WriteLine("Χρονια εγγυησης:{0}", Xroniaeggiisis);
                arxeio.WriteLine("........ΕΥΧΑΡΙΣΤΟΥΜΕ ΠΟΥ ΕΠΙΛΕΞΑΤΕ ΤΟ ΚΑΤΑΣΤΗΜΑ-Α.Ε ΓΙΑ ΤΗΝ ΕΞΥΠΗΡΕΤΗΣΗ ΣΑΣ........");

                arxeio.Close();
            
            
         }
        public override void Kataxwrhsh()
        {
            Console.Write("Κωδικος προιοντος {0}\n", Ypologistes.Code);
            Code2 = Ypologistes.Code;
            Console.Write("Oνομασια προιοντος:");
            Onomasia = Console.ReadLine();
            Console.Write("Περιγραφη:");
            Perigrafh = Console.ReadLine();
            Console.Write("Τιμη:");
            Price = Double.Parse(Console.ReadLine());
            Console.Write("Χρονια εγγυησης:");
            Xroniaeggiisis = Double.Parse(Console.ReadLine());
            Console.Write("Επεξεργαστης:");
            Epeksergasths = Console.ReadLine();
            Console.Write("Μεγεθοσ Οθονης:");
            Sizeothonis = Double.Parse(Console.ReadLine());
            Console.Write("Μνημη:");
            Mnimi = Double.Parse(Console.ReadLine());
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
            Console.Write("Wi-Fi(True/False):");
            Wifi = Boolean.Parse(Console.ReadLine());
            Console.Write("Αναληση Καμερας:");
            Analisikameras = Double.Parse(Console.ReadLine());
            Console.Write("Αισθητηρες:");
            Aisthitires = Int32.Parse(Console.ReadLine());
            Console.Write("Media:");
            Media = Int32.Parse(Console.ReadLine());
            Console.Write("3G(true/false:");
            ThreeG = Boolean.Parse(Console.ReadLine());

        }
        public override void Ektypwsh()
        {
            Console.Write("\n\nΚωδικος προιοντος" + Code2 + "\nOνομασια προιοντος:" + Onomasia
                                        + "\nΠεριγραφη:" + Perigrafh + "\nΤιμη:" + Price
                                        + "\nΧρονια εγγυησης:" + Xroniaeggiisis + "\nΕπεξεργαστης:" + Epeksergasths
                                        + "Μεγεθος Οθονης:" + Sizeothonis + "\nΜνημη:" + Mnimi
                                        + "\nΛειτουργικο Συστημα:" + Leitourgikosysthma + "\nΒαρος:" + Varos
                                        + "\nΑυτονομια Μπαταριας:" + Aytonomiabatarias + "\nΕιδος Μπαταριας:" + Eidosbatarias
                                        + "\nΔιαστασεις:" + Diastaseis + "\nWi-Fi(True/False):" + Wifi
                                        + "\nΑναληση Καμερας:" + Analisikameras + "\nΣκληρός Δίσκος" + Sklirosdiskos
                                        + "\nΚαρτα Γραφικων:" + Kartagrafikwn + "\nΚαρτα Ηχου:" + Kartahxou
                                        + "\nΑισθητηρες:" + Aisthitires + "\nMedia:" + Media
                                        + "\n3G:" + ThreeG);
        }
        }
        

 }
    

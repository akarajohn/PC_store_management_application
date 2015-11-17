using System;

namespace Project_2011
{
      abstract class Ypologistes
    {
        //Metavlites
          static int code = 0;
          static string onomapelati;
          string onomasia;
          string perigrafh;
          double price;
          double xroniaeggiisis;
       
          string leitourgikosysthma;
          double varos;
          double diastaseis;
         
          double sklirosdiskos;
          string kartagrafikwn;
          string kartahxou;
        //Kataskeuastes

          public Ypologistes() { code++; }
          public Ypologistes(string onomasia, string perigrafh, double price, double xroniaeggiisis,string leitourgikosysthma, 
            double varos,double diastaseis, double sklirosdiskos,string kartagrafikwn, string kartahxou)
        {


            code++;
            this.onomasia = onomasia;
            this.perigrafh = perigrafh;
            this.price = price;
            this.xroniaeggiisis = xroniaeggiisis;
            this.leitourgikosysthma = leitourgikosysthma;
            this.varos = varos;
            this.diastaseis = diastaseis;
            this.sklirosdiskos = sklirosdiskos;
            this.kartagrafikwn = kartagrafikwn;
            this.kartahxou = kartahxou;
            
        }
        

        //Idiothtes
          public static int Code
          {
              set { code = value; }
              get { return code; }
          }

        public static string Onomapelati
        {
            set { onomapelati = value; }
            get { return onomapelati; }
        }
        public string Onomasia
        {
            set { onomasia = value; }
            get { return onomasia; }
        }
        public string Perigrafh
        {
            set { perigrafh = value; }
            get { return perigrafh; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public double Xroniaeggiisis
        {
            set { xroniaeggiisis = value; }
            get { return xroniaeggiisis; }
        }
        
        public string Leitourgikosysthma
        {
            set { leitourgikosysthma = value; }
            get { return leitourgikosysthma; }
        }
        public double Varos
        {
            set { varos = value; }
            get { return varos; }
        }
       
        public double Diastaseis
        {
            set { diastaseis = value; }
            get { return diastaseis; }
        }
       
        public double Sklirosdiskos
        {
            set { sklirosdiskos = value; }
            get { return sklirosdiskos; }
        }
        public string Kartagrafikwn
        {
            set { kartagrafikwn = value; }
            get { return kartagrafikwn; }
        }
        public string Kartahxou
        {
            set { kartahxou = value; }
            get { return kartahxou; }
        }
        //methodoi
       public abstract void Arxeio();
       public abstract void Kataxwrhsh();
       public abstract void Ektypwsh();
        
      }
}

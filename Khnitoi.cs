using System;

namespace Project_2011
{
      abstract class Khnitoi:Ypologistes
    {
         //metablhtes

        int aytonomiabatarias;
        string eidosbatarias;
        
      
        //kataskeyastes
        public Khnitoi() { }
        public Khnitoi( string onomasia, string perigrafh, double price, double xroniaeggiisis, string leitourgikosysthma, double varos,
             double diastaseis,double sklirosdiskos,string kartagrafikwn, string kartahxou, int aytonomiabatarias,string eidosbatarias)
            :base(onomasia, perigrafh, price, xroniaeggiisis,leitourgikosysthma,
             varos, diastaseis,sklirosdiskos,kartagrafikwn,kartahxou)
            
        {
            this.aytonomiabatarias = aytonomiabatarias;
            this.eidosbatarias = eidosbatarias;
           
        }
        

            //idiothtes
        
           
            
            public int Aytonomiabatarias
            {
                set { aytonomiabatarias = value; }
                get { return aytonomiabatarias; }
            }
            public string Eidosbatarias
            {
                set { eidosbatarias = value; }
                get { return eidosbatarias; }
            }
           
        //methodoi
            
            
            
           

       

    }
}

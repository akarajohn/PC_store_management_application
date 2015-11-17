using System;
using System.IO;


namespace Project_2011
{
    class KatasthmaAE
    {
        static void Main()
        {
            const int N = 10000;
            Desktop[] desktop = new Desktop[N];
            Laptop[] laptop = new Laptop[N];
            Tablet[] tablet = new Tablet[N];
            Ipod[] ipod = new Ipod[N];
            int i = -1, j = -1, w = -1, z = -1;
            int k = 0;


           
            int count = 0;
            string pmenou;
            string dmenou;
            do
            {
                Console.WriteLine("1.Καταχώρηση Προϊόντος");
                Console.WriteLine("2.Πώληση Προϊόντος σε Πελάτη");
                Console.WriteLine("3.Εκτύπωση Διαθέσιμων Προϊόντων Καταστήματος\n");
                Console.WriteLine("0.Έξοδος");
                pmenou = Console.ReadLine();
                switch (pmenou)
                {
                    case "1":
                        
                        Console.Write("1.Laptop\n");
                        Console.Write("2.Tablet\n");
                        Console.Write("3.Desktop\n");
                        Console.Write("4.Ipod\n");
                        dmenou = Console.ReadLine();
                        
                        switch (dmenou)
                        {
                            case "1":
                                    i++;
                                    laptop[i] = new Laptop();
                                    laptop[i].Kataxwrhsh();
                                   
                                     Console.Write("H εγγραφη ολοκληρωθηκε επιτυχως...");
                                break;

                            case "2":
                                    j++;
                                    tablet[j] = new Tablet();
                                    tablet[j].Kataxwrhsh();
                                             
                                Console.Write("H εγγραφη ολοκληρωθηκε επιτυχως..."); 
                                break;

                            case "3":
                                    w++;
                                    desktop[w] = new Desktop();
                                    desktop[w].Kataxwrhsh();
                                   
                                    Console.Write("H εγγραφη ολοκληρωθηκε επιτυχως...");
                                break;

                            case "4":
                                z++;
                                ipod[z] = new Ipod();
                                ipod[z].Kataxwrhsh();
                              
                                    Console.Write("H εγγραφη ολοκληρωθηκε επιτυχως...");
                                break;
                        }

                        break;
                    case "2":
           
                         int x = 0;

            Console.Write("Ονομα πελατη:");
            Ypologistes.Onomapelati = Console.ReadLine();
            Console.Write("Δώσε το Κωδικο του Προϊοντος:");
            x = Int32.Parse(Console.ReadLine());


            for (k = 0; k <= i; k++)

                if (x == laptop[k].Code1)
                {
                    laptop[k].Arxeio();
                    
                }


                else
                    for (k = 0; k <= j; k++)
                        if (x == tablet[k].Code2)
                        {
                            tablet[k].Arxeio();   
                        }
                        else
                            for (k = 0; k <= w; k++)
                                if (x == desktop[k].Code3)

                                {

                                    desktop[k].Arxeio();
                                }
                                else
                                    for (k = 0; k <= z; k++)
                                        if (x == ipod[k].Code4)
                                        {
                                            ipod[k].Arxeio();
                                        }
                                        else
                                            Console.Write("Ο κωδικός δε ταιριάζει ξαναπροσπαθήστε");
           
                
                        break;
                    case "3":
                            Console.Write("\n----------------Laptop---------------------\n");

                            for (k = 0; k <= i; k++)

                                laptop[k].Ektypwsh();

                            Console.Write("\n----------------Tablet---------------------\n");
                            for (k = 0; k <= j; k++)
                                tablet[k].Ektypwsh();

                            Console.Write("\n----------------Desktop---------------------\n");
                            for (k = 0; k <= w; k++)

                                desktop[k].Ektypwsh();

                            Console.Write("\n----------------Ipod---------------------\n");
                            for (k = 0; k <= z; k++)

                                ipod[k].Ektypwsh();
  
                        break;

                    case "0":
                        
                        break;
                    default:
                        Console.WriteLine("Ξαναπροσπάθησε(μόνο 1,2,3 και 0 για έξοδο");
                        break;
                }
                Console.Write("\nPress Any NUMBER! To Continue...");
                Console.Write("\nΓια εξοδο απο το προγραμμα επελεξε 0...");
                
                count = Int32.Parse(Console.ReadLine());
            }while(count!=0);
            

            Console.ReadKey();
        }
    }
}

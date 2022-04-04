using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace compilation_exo
{
    class Program
    {
        static void Main(string[] args)
        {

            // string fichier_txt = File.ReadAllText(@"C:\Users\ahmed\OneDrive\Bureau\automate\auto.txt");
            // Console.WriteLine(fichier_txt);


            Automate a1 = new Automate();

            a1.read("E:/info/mini_auto/auto.txt");
            //changer le chemain du dossier auto selon le votre est garder les /


            // Console.WriteLine(a1.F);

            /*for (int i=0;i<a1.A.Length;i++)
           {
               Console.WriteLine(a1.A[i]);
           }
            */

            a1.print();
            

            //a1.print();
            /*
                        for (int i = 0; i < a1.E.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.Write(" E:{" + a1.E[i]);
                            }
                            else if (i == a1.E.Length - 1)
                            {
                                Console.Write("," + a1.E[i] + "}");
                            }
                            else
                            {
                                Console.Write("," + a1.E[i]);
                            }


                        }
            */
           

            string[,] matrice = new string[10,10];


            string[] lignes = File.ReadAllLines("E:/info/mini_auto/auto.txt");
            //changer le chemain du dossier auto selon le votre est garder les /

            // Console.WriteLine(lignes[0]);
            List<string> ls = new List<string>();


           for (int i=5;i<lignes.Length;i++)
            {
                ls.AddRange((lignes[i].Split(' ')));
            }

            string[] tab = new string[ls.Count];

            tab = ls.ToArray();

            for (int i=0;i<tab.Length;i++)
            {
               // Console.WriteLine(tab[i]);
            }
            string[] tab1 = new string[50];
            tab1 = tab;
            string[] A = a1.A;


            for (int i = 0; i < tab1.Length; i++)
            {
                //Console.WriteLine(tab1[i]);
            }


            //****************pour changer les alphabet en position des colonne pour la matrice***

            Dictionary<string, int> alpa_to_posi = new Dictionary<string, int>();

            for (int i=0;i<A.Length;i++)
            {
                alpa_to_posi.Add(A[i], i);
            }


            for(int i = 0; i < tab1.Length; i++)
            {
                foreach (KeyValuePair<string, int> langage in alpa_to_posi)
                {
                    if(tab1[i]== langage.Key)
                    {
                        tab1[i] = langage.Value.ToString();
                    }
                }
            }



            Console.WriteLine("\n");
            for (int i = 0; i < tab1.Length; i++)
            {
               // Console.WriteLine(tab1[i]);
            }



           

            int c0 = 0, c1 = 1, c2 = 2;


            for (int i = 0; i < a1.E.Length; i++)
            {
                for (int j = 0; j < a1.A.Length; j++)
                {
                  
                        matrice[i, j] = "X";
                    
                }
            }
            

            do
            {
                matrice[Convert.ToInt32(tab1[c0]), Convert.ToInt32(tab1[c1])] = tab1[c2];

                c0 += 3;
                c1 += 3;
                c2 += 3;

            } while (c2 < tab1.Length);

            Console.WriteLine("La matrice :\n");

            for (int i = 0; i < a1.E.Length; i++)
            {
                for (int j = 0; j < a1.A.Length; j++)
                {
                    Console.Write(" "+matrice[i, j]+" ");
                }
                Console.WriteLine("\n");
            }

           // Console.WriteLine("\n"+tab1.Length);


            void mots(string m)
            {

                char[] tab2 = new char[50];
                tab2 = m.ToCharArray();

                //  for (int i=0;i<tab2.Length;i++)
                // {
                //Console.WriteLine("\n" + tab2[0]);
                //   }
                int ligne = 0;
                int cpt = 0;
                for (int i = 0; i < tab2.Length; i++)
                {

                    if (!alpa_to_posi.ContainsKey(tab2[i].ToString()) /*||  i == tab2.Length-1   &&   ligne != a1.F  || matrice[ligne,alpa_to_posi[tab2[i].ToString()]] ==  "X"*/)
                    {
                        Console.WriteLine("\nmot non accepter");

                        cpt++;
                        break;
                    }
                    else if (matrice[ligne, alpa_to_posi[tab2[i].ToString()]] == "X")

                    {
                        Console.WriteLine("\nmot non accepter");
                        cpt++;
                        break;
                    }
                   

                    else
                    {
                        ligne = Convert.ToInt32(matrice[ligne, alpa_to_posi[tab2[i].ToString()]]);
                        
                        if ( i == tab2.Length - 1 && ligne != a1.F)

                      {
                        Console.WriteLine("\nmot non accepter");
                        cpt++;
                        break;
                       }
                        

                        if (ligne == a1.F && i == (tab2.Length - 1))
                        {
                           // Console.WriteLine("\n la valeur de la ligne :" + ligne);
                            Console.WriteLine("\nmots accepté");
                            break;
                        }




                    }

                }

            }
           




            string q = "";


             do
             {

                 Console.WriteLine(" -------------------------------------");
                 Console.WriteLine("|  1/   afficher les information      |");
                 Console.WriteLine("|  2/   inserez un nouveau mot        |");
                 Console.WriteLine("|  3/            quitter              |");
                 Console.WriteLine(" -------------------------------------");
                 Console.WriteLine("choisissez 1 , 2 ou 3 :");
                do
                    q = Console.ReadLine();
                while (q != "1" && q != "2" && q != "3");
                 Console.Clear();
                 switch(q)
                 {
                     case "1":
                         a1.print();
                         break;
                     case "2":
                        a1.print();
                        Console.WriteLine("\nentrez un mot: ");
                        string s = Console.ReadLine();
                        mots(s);
                        break;
                     case "3":
                         q = "3";
                        break;
                     default:
                         Console.WriteLine("\nchoix impossible");
                         break;

                 }


             } while (q != "3");
            

        }
    }
}

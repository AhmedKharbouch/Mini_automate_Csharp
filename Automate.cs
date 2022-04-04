using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace compilation_exo
{
    public class Automate
    {
        public int[] E= new int[50];
        public string[] A = new string[50];
        public int q0;
        public int F;
        public int nbr_F;

       /* public Automate(int[] e, char[] a, int q0, int f)
        {
            E = e;
            A = a;
            this.q0 = q0;
            F = f;
        }*/

        public Automate()
        {
        }

        public void read (string s)
        {
            string[] lignes = File.ReadAllLines(s);
            Console.WriteLine(lignes[0]);
            
            int [] l = new int[ Convert.ToInt32(lignes[0])];
            
            for (int i = 0; i < Convert.ToInt32( lignes[0]); i++)
            {
                l[i] = i;

            }

            this.E = l;

            this.A = lignes[1].Split(',');

            this.q0 = Convert.ToInt32(lignes[2]);

            this.nbr_F = Convert.ToInt32(lignes[3]);

            this.F= Convert.ToInt32(lignes[4]);



            


        }

        public void print()
        {
            //int[] e = this.E;
            //string[] a = this.A;
            Console.Write("\n");
            Console.Write("\n");
            for (int i = 0; i < this.E.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("E:{" + E[i]);
                    }
                    else if (i == E.Length - 1)
                    {
                        Console.WriteLine("," + E[i] + "}");
                    }
                    else
                    {
                        Console.Write("," + E[i]);
                    }


                }

               Console.Write("\n");


                for (int i = 0; i < this.A.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("A:{" + A[i]);
                    }
                    else if (i == A.Length - 1)
                    {
                        Console.WriteLine("," + A[i] + "}");
                    }
                    else
                    {
                        Console.Write("," + A[i]);
                    }


                }
                Console.Write("\n");
                Console.WriteLine("I = " + q0);
                Console.Write("\n");
                Console.WriteLine("F = " + F);
                Console.Write("\n");
                Console.WriteLine("le nombre d'etat finaux: " + nbr_F);
                Console.Write("\n");


        }
    }
}

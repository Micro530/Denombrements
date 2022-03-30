/**
 * Calcules
 * 3 version de calcules mathématique
 * Le CNED
 * date derniere modification 29/10/2020
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        //déclaration des variables globales
        static int temp;
        static bool correct = false;       
        //saisie des valeurs
        static int Saisie(string message)
        {           
            while (!correct)
            {
                Console.Write(message+" = ");
                temp = Test();               
            }
            correct = false;
            return temp;
        }
        //le try de controle de saisie pour int
        static int Test()
        {
            try
            {
                temp = int.Parse(Console.ReadLine());
                correct = true;
            }
            catch
            {
                Console.WriteLine("Erreur de saisie : Vous devrez entrer un nombre entier.");
            }
            return temp;
        }
        static void Main(string[] args)
        {
            // déclaration des variables 
            int n = 0, t = 0, c = 1;                       
            double r = 1,r1 = 1;
                        
            while (true)
            {
                while (!correct)
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :\t\t\t\t   ");                    
                    c = Test();            
                }
                correct = false;
                switch (c)
                {
                    case 1:
                        {
                            n = Saisie("nombre total d'éléments à gérer");
                            // calcul de r
                            r = 1;
                            for (int k = 1; k <= n; k++)
                                r *= k;
                            Console.WriteLine(n + "! = " + r);
                            break;
                        }
                    case 2:
                        {
                            t = Saisie("nombre total d'éléments à gérer");
                            n = Saisie("nombre d'éléments dans le sous ensemble");
                            // calcul de r
                            r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r *= k;
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                            break;
                        }
                    case 3:
                        {
                            t = Saisie("nombre total d'éléments à gérer");
                            n = Saisie("nombre d'éléments dans le sous ensemble");
                            // calcul de r
                            r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r *= k;
                            // calcul de r1                            
                            for (int k = 1; k <= n; k++)
                                r1 *= k;                            
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r / r1));
                            break;
                        }
                    default:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }                                             
            }            
        }
    }
}

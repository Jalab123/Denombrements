using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static int suiteEntiers(int nbA, int nbB)
        {
            int resultat = nbA;
            int compteur = nbA;
            if (nbA <= nbB)
            {
                while (compteur != nbB)
                {
                    compteur = compteur + 1;
                    resultat = resultat * compteur;
                }

            }
            else
            {
                Console.WriteLine("Erreur, nbA > nbB.");
                resultat = -1;
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            bool correct = false;
            int c = 1;
            int n = 0;
            int t = 0;
            while (c != 0)
            {
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Suite ............................ 4");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        c = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie.");
                    }
                }


                if (c == 0)
                {
                    Environment.Exit(0);
                }

                else if (c == 1)
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            n = int.Parse(Console.ReadLine());
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie.");
                        }
                    }
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else if (c == 2)
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    t = int.Parse(Console.ReadLine());
                    Console.Write("nombre d'éléments dans le sous ensemble = ");
                    n = int.Parse(Console.ReadLine());
                    // calcul de r
                    long r = 1;
                    for (int k = (t - n + 1); k <= t; k++)
                        r *= k;
                    Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                }
                else if (c == 3)
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            t = int.Parse(Console.ReadLine());
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie.");
                        }

                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre d'éléments dans le sous ensemble = ");
                                n = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie.");
                            }
                        }


                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
                else if (c == 4)
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre numéro 1 = ");
                            t = int.Parse(Console.ReadLine());
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie.");
                        }
                    }

                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre numéro 2 = ");
                            n = int.Parse(Console.ReadLine());
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie.");
                        }
                    }

                    if (suiteEntiers(t, n) != -1)
                    {
                        Console.WriteLine("Résultat de la suite: " + suiteEntiers(t, n));
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

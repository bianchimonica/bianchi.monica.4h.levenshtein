using System;

namespace bianchi.monica._4h.levnshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LEVENSHTEIN  -  Bianchi Monica 4H \n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Inserisci prima stringa: ");
            Console.ResetColor();
            string str1 = Console.ReadLine();
            char[] s = str1.ToCharArray();
            int n = str1.Length;

            Console.WriteLine("----------------------");


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Inserisci seconda stringa: ");
            Console.ResetColor();
            string str2 = Console.ReadLine();
            char[] t = str2.ToCharArray();
            int m = str2.Length;

            Console.WriteLine("----------------------");

            int distanza = 0;

            int[,] L = new int[m + 1, n + 1];



            if (n == 0)
            {

                distanza = m;

            }
            else

            {

                if (m == 0)
                    distanza = m;


                else

                {



                    for (int i = 0; i <= n; i++)
                        L[0, i] = i;



                    for (int j = 0; j <= m; j++)
                        L[j, 0] = j;




                    for (int j = 0; j < m; j++)

                    {

                        for (int i = 0; i < n; i++)

                        {

                            int costo = 0;
                            if (t[j] != s[i])
                                costo = 1;


                            int a = L[j, i] + costo;
                            int b = L[j + 1, i] + 1;
                            int c = L[j, i + 1] + 1;


                            L[j + 1, i + 1] = Math.Min(c, Math.Min(a, b));

                        }
                    }

                    distanza = L[m, n];

                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Distanza di Levenshtein: {distanza}");
            Console.ResetColor();
            Console.ReadLine();

        }
    }
}

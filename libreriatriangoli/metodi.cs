using System;

namespace libreriatriangoli
{
    public class metodi
    {
        public static double Lato()
        {
            Console.WriteLine("inserire la lunghezza del lato ");
            double l = double.Parse(Console.ReadLine());
            return l;
        }
        public static string ClassificaTriangolo(double l1, double l2, double l3)
        {
            string risultato = "";
            if (l1 > 0 && l2 > 0 && l3 > 0)
            {
                if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("SCALENO");
                }
                else if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("EQUILATERO");
                }
                else
                Console.WriteLine("ISOSCELE");
            }
            else
                Console.WriteLine("VALORI ERRATI");
            return risultato;
        }

        public static double CalcolaPerimetro(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }
    }
}


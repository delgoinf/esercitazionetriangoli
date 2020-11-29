using System;
using libreriatriangoli;

namespace metoditriangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1 = metodi.Lato();
            double l2 = metodi.Lato();
            double l3 = metodi.Lato();
            double perimetro = metodi.CalcolaPerimetro(l1, l2, l3);
            string risultato = metodi.ClassificaTriangolo(l1, l2, l3);
            if (l1 < 0 || l2 < 0 || l3 < 0)
            {
                Console.WriteLine("ERRORE");
            }
            else
            {
                Console.WriteLine($"PERIMETRO={perimetro}");
            }

        }
    }
}

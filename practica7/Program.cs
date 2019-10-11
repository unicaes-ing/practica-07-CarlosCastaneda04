using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, edades, menores = 0, mayores = 0;
            Console.WriteLine("Ingrese la cantidad de personas: ");
            num = int.Parse(Console.ReadLine());
            int[] cantidad = new int[num];
            for (int i = 0; i < cantidad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona");
                edades = int.Parse(Console.ReadLine());
                if (edades >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
            }
            Console.Clear();
            Console.WriteLine("Cantidad de mayores: {0}", mayores);
            Console.WriteLine("Cantidad de menores: {0}", menores);
            Console.ReadKey();
        }
    }
}

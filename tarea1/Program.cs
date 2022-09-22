using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int promedio = 0;
            int mayor = 0;
            int menor = 0;
            int notaMayor = 0;
            int[] nota = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el nombre del estudiante #" + (i+1));
                Console.ReadLine();
                
                Console.WriteLine("Digite la nota del estudiante #" + (i+1));
                nota[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    notaMayor = nota[i];
                        }
               
                else if (nota[i] > notaMayor)
                {
                    notaMayor = nota[i];
                }

            }

            promedio = (nota[0] + nota[1] + nota[2] + nota[3] + nota[4]) / 5;
            
            for (int i = 0; i < 5; i++)
            {
                if (nota[i] > promedio)
                {
                    mayor = mayor + 1;
                }
                else
                {
                    menor = menor +1;
                }
            }

            Console.WriteLine("El promedio de notas es: " + promedio);
            Console.WriteLine("La nota mas alta es: "+notaMayor);
            Console.WriteLine(mayor+" Estudiantes tienen una nota mayor al promedio");
            Console.WriteLine(menor+" Estudiantes tienen una nota menor al promedio");
            Console.ReadLine();
        }
    }
}

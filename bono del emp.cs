using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bono_del_empleado_por_hijo
{
    class Program
    {
        static void Main(string[] args)
        {
            double SUELDO, ARECIBIR;
            int NHIJO, BONO;
            string NOM, linea;
            Console.WriteLine("Nombre Empleado :");
            NOM = Console.ReadLine();
            Console.WriteLine("Sueldo Empleado :");
            linea = Console.ReadLine();
            SUELDO = Double.Parse(linea);
            Console.WriteLine("Numero de Hijos :");
            linea = Console.ReadLine();
            NHIJO = int.Parse(linea);
            if (NHIJO >= 3) 
            { BONO = NHIJO * 10;  
            
            } 
            else
            {
                BONO = NHIJO * 20;
            }
            
            ARECIBIR = SUELDO + BONO;

            Console.WriteLine ("Recibe :" + string.Format ("{0:c}", ARECIBIR));
            Console.WriteLine("Pulse una tecla");
            Console.ReadLine();





        }
    }
}

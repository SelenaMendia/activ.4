using System;

namespace activ._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            int [] diames = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string [] mes = {" ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            Console.WriteLine("Ingrese del 1 al 12 del mes para saber cuantos dias tiene");
            n=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < diames.Length; i++)
            {
                for (int j = 0; j < mes.Length; j++)
                {
                    if((n==i)&&(n==j))
            {
                Console.WriteLine("Mes {0} = {1} tiene {2} Dias", n,mes[j], diames[i]);
            }
                }
                

            }

        }
    }
}

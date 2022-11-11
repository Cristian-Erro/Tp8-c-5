using System;

namespace Tp8_c_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaro/inicializo array y variables

            int[] mes={31,28,31,30,31,30,31,31,30,31,30,31};
            int dia,meS,diaCumulador=0;
            //Ingreso de datos
            Console.WriteLine("Por favor,ingrese el numero de mes del 1 al 12");
            meS=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine(
                "ahora ingrese el numero del dia de su mes(considere el total de dias que tiene el mes elegido)");
            dia=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Ciclo for para recorrer y cargar el sumador

            for(int i=meS-1;i<mes.Length;i++){
                diaCumulador+=mes[i];
            }
            //Mensaje de salida con respuesta y calculo de dia
            System.Console.WriteLine("Quedan "+(diaCumulador-dia)+" dias hasta fin de año");
            System.Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }
    }
}

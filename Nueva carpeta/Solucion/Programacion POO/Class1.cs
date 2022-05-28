using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_POO
{
    class Class1
    {
        //atributos
        int num1;
        int num2;
        int suma;
        int resta;
        int division;
        int multiplicacion;


        public void leerNumeros()
        {
            Console.Write("Ingrese Numero 1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Numero 2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void sumar()
        {
            suma = num1 + num2;
        }

        public void restar()
        {
            resta = num1 - num2;
        }
        public void multiplicar()
        {
            multiplicacion = num1 * num2;
        }
        public void dividir()
        {
            division = num1 / num2;
        }

        public void resultados()
        {
            Console.Clear();
            Console.Write("\n Numero 1= " + num1);
            Console.Write("\n  ");
            Console.Write("\n Numero 2= " + num2);
            Console.Write("\n  ");
            Console.Write("\n El resultado de la Suma es= " + suma);
            Console.Write("\n  ");
            Console.Write("\n El resultado de la Resta es= " + resta);
            Console.Write("\n  ");
            Console.Write("\n El resultado de la Multiplicacion es= " + multiplicacion);
            Console.Write("\n  ");
            Console.Write("\n El resultado de la Division es= " + division);
            Console.Write("\n  ");
        }

    }
}

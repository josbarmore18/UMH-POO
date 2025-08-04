using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el costo por hora
            Console.Write("Ingrese el precio por hora trabajada: "); 
            double costoPorHora = Convert.ToDouble(Console.ReadLine());

            // Solicitar al usuario la cantidad de horas trabajadas
            Console.Write("Ingrese la cantidad de horas trabajadas en la semana: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            // Calcular el salario total d
            double total = costoPorHora * horasTrabajadas;

            // Mostrar el resultado
            Console.WriteLine("El salario semanal es: L. " + total);
        }
    }
}

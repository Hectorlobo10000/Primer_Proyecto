﻿using System;
using System.Runtime.InteropServices;
using Primera.Libreria;


namespace Primera_Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Suma de numeros";

            Console.WriteLine("Ingrese el primer numero: ");
            var pnumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Operador");
            var operador = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo numero: ");
            var snumero = Convert.ToInt32(Console.ReadLine());

            var fabrica = ConfiguracionOperacion.ObtenerFabrica();
            var operacion = fabrica.CrearOperacion(operador);

            Console.WriteLine("El resultado es: " + operacion.Operar(pnumero, snumero));
            Console.ReadKey();
        }
    }
}
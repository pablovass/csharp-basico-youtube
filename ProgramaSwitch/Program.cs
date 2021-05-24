using System;
using static System.Console;
namespace ProgramaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            // programa que solo este permitido escribir a mayores de 18 años hasta 30 años
            //inicio
            //declaramos variables
            string saludo;
            string edad;//nosotro la vamos a cargar
            string pregunta;
            int edadEnNumero;

            //proceso
            saludo = "bienvenido";
            pregunta = "decime tu edad";
            //mostrar en pantalla el saludo y la pregunta
            WriteLine(saludo);
            WriteLine(pregunta);
            edad = ReadLine();
            // casteo
            edadEnNumero = Int32.Parse(edad);

            //salida
            switch (edadEnNumero)
            {
                case >=18: 
                   WriteLine("acceso permitido"); 
                break;

                case <=30:
                WriteLine("acceso prohibido");
                break;

            }

        }
    }
}

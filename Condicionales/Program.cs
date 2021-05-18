using System;
using static System.Console;
namespace Condicionales
{
    //script = programa = algoritmo (problemas simple)
    // condicionales simples y anidados = filtros
    class Program
    {
        static void Main(string[] args)
        {
         // programa que solo este permitido escribir a mayores de 18 años hasta 30 años  

         //inicio
         //declaramos variables  
         string saludo;
         string edad;//nosotro la vamos a cargar
         string pregunta;
         int edadEnNumero;
        
         //proseso
        saludo="bienvenido";
        pregunta="decime tu edad";
        //mostrar en pantalla el saludo y la pregunta
        WriteLine(saludo);
        WriteLine(pregunta);
        edad=ReadLine();
        // casteo 
        edadEnNumero=Int32.Parse(edad);
        // && and  || or 
        if (edadEnNumero >= 18 && edadEnNumero <= 30 )
        {
            //salida
            WriteLine("acceso permitido");
        }else{
            //salida
            WriteLine("acceso denegado");
        }
            

         //salida


        }
    }
}

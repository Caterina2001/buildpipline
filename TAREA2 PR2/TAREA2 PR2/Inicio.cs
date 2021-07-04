using System;
using System.Collections.Generic;

namespace TAREA2_PR2
{
    class Inicio
    {

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;  //Fondo de color
            Console.ForegroundColor = ConsoleColor.White;  //Letras de color
            Console.Clear();  //Expandir el color de fondo

            Menu obj = new Menu();
            obj.menues();              
        }        
    }
}

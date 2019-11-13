﻿using System;

namespace Metricas_de_software
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            SumasPositivas FuncionSumasPositivas = new SumasPositivas();
            SumasNegativas FuncionSumasNegativas = new SumasNegativas();

            Console.WriteLine("Elija : \n" + "1) Entero \n" + "2) Entero(64 bits) \n" + "3) Float \n" + "4) Double");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la cantidad de números para la operación?");
            int limite = Convert.ToInt32(Console.ReadLine());
            // ¿Qué tipo de variable quiero enviar a la función?
            switch (input)
            {
                // Int
                case 1:
                    //FuncionSumasPositivas.getSumaPositivos(1,0,0f,0,limite);
                    FuncionSumasNegativas.getSumaNegativos(1,0,0f,0,limite);
                    break;
                // Int (64 bits)    
                case 2:
                    //FuncionSumasPositivas.getSumaPositivos(0,1,0f,0,limite);
                    FuncionSumasNegativas.getSumaNegativos(0,1,0f,0,limite);
                    break;
                // Float    
                case 3:
                    //FuncionSumasPositivas.getSumaPositivos(0,0,1f,0,limite);
                    FuncionSumasNegativas.getSumaNegativos(0,0,1f,0,limite);
                    break;
                // Double    
                case 4:
                    //FuncionSumasPositivas.getSumaPositivos(0,0,0f,1,limite);
                    FuncionSumasNegativas.getSumaNegativos(0,0,0f,1,limite);
                    break;        
                default:
                    Console.WriteLine("¡Haz ingresado una opción incorrecta!, vuelve a intentar.");
                    break;
            }

        }

    }

    // Contiene las funciones para medir el tiempo de ejecución
    class Tiempo
    {
        private DateTime inicio;
        private DateTime fin;
        private TimeSpan total;

        public void iniciaContador(){
            inicio = DateTime.Now;
        }

        public void terminaContador(){
            fin = DateTime.Now;
            total = new TimeSpan(fin.Ticks - inicio.Ticks);
        }

        public TimeSpan getTiempoTotal(){
            return total;
        }
    }
}




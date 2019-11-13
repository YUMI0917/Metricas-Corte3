using System;

namespace Metricas_de_software
{
    class DivisionesPositivas
    {
        // Contiene las 10 funciones para cada tipo de variable
        public String getDivisionPositivos(int Nint, Int64 Nint64, float Nfloat, double Ndouble, int limite){
            
            if(Nint == 1){
                Tiempo contador = new Tiempo();
                contador.iniciaContador(); // Comienza

                int numero = 1;
                int resultado = 0;
                int auxiliar = 1;
                int auxiliar2 = 1;
                
                while(numero <= limite){
                    resultado = auxiliar / auxiliar2;
                    auxiliar = numero * 5;
                    auxiliar2 = numero;
                    numero+=1;
                }
                contador.terminaContador(); // Finaliza
                Console.WriteLine(numero.GetType());
                Console.WriteLine("Tiempo : " + contador.getTiempoTotal().TotalMilliseconds + " ms ");
            }
            else if(Nint64 == 1){
                Tiempo contador = new Tiempo();
                contador.iniciaContador(); // Comienza
                
                Int64 numero = 1;
                Int64 resultado = 0;
                Int64 auxiliar = 1;
                Int64 auxiliar2 = 1;
                
                while(numero <= limite){
                    resultado = auxiliar / auxiliar2;
                    auxiliar = numero * 5;
                    auxiliar2 = numero;
                    numero+=1;
                }
                contador.terminaContador(); // Finaliza
                Console.WriteLine(numero.GetType());
                Console.WriteLine("Tiempo : " + contador.getTiempoTotal().TotalMilliseconds + " ms ");
            }
            else if(Nfloat == 1){
                Tiempo contador = new Tiempo();
                contador.iniciaContador(); // Comienza
                
                float numero = 1;
                float resultado = 0;
                float auxiliar = 1;
                float auxiliar2 = 1;
                
                while(numero <= limite){
                    resultado = auxiliar / auxiliar2;
                    auxiliar = numero * 5;
                    auxiliar2 = numero;
                    numero+=1;
                }
                contador.terminaContador(); // Finaliza
                Console.WriteLine(numero.GetType());
                Console.WriteLine("Tiempo : " + contador.getTiempoTotal().TotalMilliseconds + " ms ");
            }
            else if(Ndouble == 1){
                Tiempo contador = new Tiempo();
                contador.iniciaContador(); // Comienza
                
                double numero = 1;
                double resultado = 0;
                double auxiliar = 1;
                double auxiliar2 = 1;
                
                while(numero <= limite){
                    resultado = auxiliar / auxiliar2;
                    auxiliar = numero * 5;
                    auxiliar2 = numero;
                    numero+=1;
                }
                contador.terminaContador(); // Finaliza
                Console.WriteLine(numero.GetType());
                Console.WriteLine("Tiempo : " + contador.getTiempoTotal().TotalMilliseconds + " ms ");
            }
            

            return "true";
        }
    }

}    
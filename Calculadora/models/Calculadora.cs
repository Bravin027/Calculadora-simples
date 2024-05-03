using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora1
    {
        /* Criar um parametro onde a classe somar recebe
        o valor X e Y */
        public void Somar(int x , int y) {
            Console.WriteLine("Resultado = " + (x + y));
        }
        public void Subtrair(int x, int y) {
            Console.WriteLine("Resultado = " + (x - y));
        }
         public void Multiplicação(int x, int y) {
            Console.WriteLine("Resultado = " + (x * y));
         }
        public void Divisão(int x, int y) {
            Console.WriteLine("Resultado = " + (x / y));
        }
    }
}
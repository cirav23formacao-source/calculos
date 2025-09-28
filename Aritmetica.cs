using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações  aritméticas.
    /// </summary>
    internal static class Aritmetica
    {
       
       
        public static int Somar(int x, int y) {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de doi números.</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

          
    }
}

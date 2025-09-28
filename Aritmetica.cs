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
    internal class Aritmetica
    {
        /// <summary>
        /// Operação de soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public int Somar(int x, int y) {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}

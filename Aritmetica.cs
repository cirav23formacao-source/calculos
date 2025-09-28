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
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
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
        /// <returns>Retorna o resultado da subtração de doi números.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de converter temperatura.
        /// </summary>
        /// <returns>Retorna o resultado da conversão de Celsius/Fahrenheit.</returns>
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }
}

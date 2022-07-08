using System.Collections.Generic;

namespace TradeMoeda.Models
{
    public class Moedas
    {
        private static List<Moeda> moedas = new List<Moeda>()
        {
            new Moeda
            {
                name = "USD",
                valor =  0.19
            },
            new Moeda
            {
                name = "EUR",
                valor = 0.19
            },
            new Moeda
            {
                name = "ARG",
                valor = 23.9
            }
        };

        public List<Moeda> RetornaLista()
        {
            return moedas;
        }
      
    }
}

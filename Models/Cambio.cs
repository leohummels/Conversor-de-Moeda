using System;

namespace TradeMoeda.Models
{
    public class Cambio
    {
     
        private Moeda valorEstrangeiro;
        private Moedas moedas = new Moedas();
        private  Moeda Resultado = new Moeda();

        public Moeda CambioExecute(Moeda moedaInformada)
        {          
            this.valorEstrangeiro = VerificarMoeda(moedaInformada);
            Resultado.name = moedaInformada.name;
            Resultado.valor = Math.Round(moedaInformada.valor * this.valorEstrangeiro.valor, 2);

            return Resultado;
        }

        public Moeda VerificarMoeda(Moeda moeda)
        {
            Moeda select = moedas.RetornaLista().Find(item => item.name == moeda.name);
            return select;
        }
    }
}

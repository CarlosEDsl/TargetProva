using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetTeste.model;

namespace TargetTeste
{
    internal class Distributor
    {

        public static void GetInformation(dadosModel[] dados)
        {
            double menorValor = double.MaxValue;
            double maiorValor = double.MinValue;
            double soma = 0;
            double media = 0;
            double dias = 0;

            foreach (var dado in dados)
            {
                dias++;

                soma += dado.valor;

                if (dado.valor < menorValor)
                {
                    menorValor = dado.valor;
                }
                if (dado.valor > maiorValor)
                {
                    maiorValor = dado.valor;
                }

                media = soma / dias;
            }

            int acimaMedia = 0;
            foreach (var dado in dados)
            {
                if(dado.valor > media)
                {
                    acimaMedia++;
                }
            }

            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Valore acima da média {acimaMedia}");
        }

    }

}

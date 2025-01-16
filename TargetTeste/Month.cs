using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTeste
{
    internal class Month
    {
        public static decimal CalcularPercentual(decimal valor, decimal total)
        {
            return (valor / total) * 100;
        }

    }
}

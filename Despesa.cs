using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa04
{
    internal class Despesa
    {

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }

        //Polimorfismo
        //Override
        //Método no pai que é sobrescrito pelo filho

        public override string ToString ()=>
             $"{Descricao,-20}-{Vencimento:dd/MM/yyyy)}";
        }
    }
}

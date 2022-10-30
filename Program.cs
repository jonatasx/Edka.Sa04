    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Edka.Sa04
    {
        internal class Program
        {
            public static List<Despesa> despesas = new List<Despesa>
            {
                //Lista Genérica < >
                new Despesa{Descricao="Internet",Valor=89,Vencimento= new DateTime(2022,11,15)},
                new Despesa{Descricao="Luz",Valor=110,Vencimento= new DateTime(2022,11,07)},
                new Despesa{Descricao="Água",Valor=70,Vencimento= new DateTime(2022,11,02)}

            };
            static void Main(string[] args)
            {
                //Filtro LINQ
                //from
                //in
                //select

                var despesasAbaixodeCem = from d in despesas select d;

                foreach(var item in despesasAbaixodeCem)
                {
                Console.WriteLine(item);
    
                }

                Console.ReadKey();
            }
        }
    }

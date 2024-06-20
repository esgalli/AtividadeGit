using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TecnicasRefatoracao.R01.ExtractMethod.antes;

namespace refatoracao.Aula01.R01.ExtractMethod.antes
{
    class Relatorio
    {
        void Imprimir()
        {
            decimal total = 0.0m;
            var pedido = new Pedido("José da Silva");
            pedido.AddItem("Dentozap", 2, 10m, 0m, 3m);
            pedido.AddItem("Voldax", 3, 10m, 0m, 3m);
            pedido.AddItem("Magnopyrol", 7, 19m, 0m, 3m);
            pedido.AddItem("Tranlab", 7, 10m, 0m, 3m);
            pedido.AddItem("Omeprazol", 8, 98m, 0m, 3m);

            // imprimir itens
            Console.WriteLine("***************************************");
            Console.WriteLine("********** Itens do Pedido ************");
            Console.WriteLine("***************************************");
            foreach (var item in pedido.Itens)
            {
                decimal valorItem = item.Quantidade * item.PrecoBase;
                Console.WriteLine($"{item.Desconto}: {item.Quantidade} Unidades, R$ {valorItem}");
                total = total + valorItem;
            }

            // imprimir detalhes
            Console.WriteLine("****************************************");
            Console.WriteLine("********** Resumo do Pedido ************");
            Console.WriteLine("****************************************");
            Console.WriteLine("nome: " + pedido.Cliente);
            Console.WriteLine("valor: " + total);
        }
    }

    class Item
    {
        private readonly string descricao;
        private readonly int quantidade;
        private readonly decimal precoBase;
        private readonly decimal acrescimo;
        private readonly decimal desconto;

        public string Descricao { get => descricao; }
        public int Quantidade { get => quantidade; }
        public decimal PrecoBase { get => precoBase; }
        public decimal Acrescimo { get => acrescimo; }
        public decimal Desconto { get => desconto; }

        public Item(string descricao, int quantidade, decimal precoBase, decimal acrescimo, decimal desconto)
        {
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.precoBase = precoBase;
            this.acrescimo = acrescimo;
            this.desconto = desconto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using refatoracao.Aula01.R01.ExtractMethod.antes;

namespace TecnicasRefatoracao.R01.ExtractMethod
{
    publi class Pedido
    {
        private readonly IList<Item> itens = new List<Item>();
        private readonly string cliente;

        public Pedido(string cliente)
        {
            this.cliente = cliente;
        }

        public string Cliente { get => cliente; }

        public IReadOnlyCollection<Item> Itens
        {
            get { return new ReadOnlyCollection<Item>(itens); }
        }
 
        public void AddItem(string descricao, int quantidade, decimal precoBase, decimal acrescimo, decimal desconto)
        {
            itens.Add(new Item(descricao, quantidade, precoBase, acrescimo, desconto));
        }

    }
}
using System.Collections.ObjectModel;
using refatoracao.Aula01.R01.ExtractMethod.antes;

namespace TecnicasRefatoracao.R01.ExtractMethod.antes
{
    public class Pedido
    {
        class Pedido
        {
            private readonly IList<Item> itens = new List<Item>();
            public IReadOnlyCollection<Item> Itens
            {
                get { return new ReadOnlyCollection<Item>(itens); }
            }

            private readonly string cliente;
            public string Cliente { get => cliente; }

            public Pedido(string cliente)
            {
                this.cliente = cliente;
            }

            public void AddItem(string descricao, int quantidade, decimal precoBase, decimal acrescimo, decimal desconto)
            {
                itens.Add(new Item(descricao, quantidade, precoBase, acrescimo, desconto));
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Configurador.Repositorio.Model;

namespace Configurador.WebClient.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Componente componente, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Componente.Id == componente.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Componente = componente,
                    Quantity = quantity
                  
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }


        public void RemoveLine(Componente componente)
        {
            lineCollection.RemoveAll(l => l.Componente.Id == componente.Id);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Componente.Precio * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Componente Componente { get; set; }
        public int Quantity { get; set; }
    }
}
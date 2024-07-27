using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinSell
{
    public class SubcategoriaItem
    {
        public int SubcategoriaId { get; set; }
        public string Nome { get; set; }

        public SubcategoriaItem(int subcategoriaId, string nome)
        {
            SubcategoriaId = subcategoriaId;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}

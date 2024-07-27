using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinSell
{
    public class CategoriaItem
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public CategoriaItem(int categoriaId, string nome)
        {
            CategoriaId = categoriaId;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}

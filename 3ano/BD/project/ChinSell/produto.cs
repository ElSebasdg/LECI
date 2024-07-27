using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinSell
{
    public partial class produto : Form
    {
        public produto(int ID, string nome, string preço, string Cat)
        {
            InitializeComponent();
            pNome = nome;
            preço = Preco;
            Cat = Categoria;
        }

        public String ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String pNome
        {
            get { return pNome; }
            set { pNome = value; }
        }

        public String Preco
        {
            get { return Preco; }
            set { Preco = value; }
        }

        public String Categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }

       


    }
}

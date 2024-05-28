using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacShop.DAL.DTO
{
    public class ProdutoDto
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int estoque { get; set; }
        public int idCategoria { get; set; }
    }
}

using SenacShop.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacShop.DAL
{
    public class ProdutoDal : Conexao
    {
        public List<ProdutoDto> Listar()
        {
            Conectar();
            Cmd = new SqlCommand("SELECT * FROM Produto", Conn);
            Dr = Cmd.ExecuteReader();

            List<ProdutoDto> lista = new List<ProdutoDto>();

            while (Dr.Read())
            {
                ProdutoDto produto = new ProdutoDto();
                produto.idProduto = Convert.ToInt32(Dr["idProduto"]);
                produto.nome = Convert.ToString(Dr["nome"]);
                produto.descricao = Convert.ToString(Dr["descricao"]);
                produto.preco = Convert.ToDecimal(Dr["preco"]);
                produto.estoque = Convert.ToInt32(Dr["estoque"]);
                produto.idCategoria = Convert.ToInt32(Dr["idCategoria"]);
                lista.Add(produto);
            }
            Desconectar();

            return lista;
        }

        public void Cadastrar(ProdutoDto input)
        {
            Conectar();
            Cmd = new SqlCommand($"INSERT INTO Produto (nome, descricao, preco, estoque, idCategoria) VALUES ('{input.nome}', '{input.descricao}', {input.preco}, {input.estoque}, {input.idCategoria})", Conn);
            Cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}

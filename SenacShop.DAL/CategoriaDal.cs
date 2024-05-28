using SenacShop.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacShop.DAL
{
    public class CategoriaDal : Conexao
    {
        public List<CategoriaDto> Listar()
        {
            Conectar();
            Cmd = new SqlCommand("SELECT * FROM Categoria", Conn);
            Dr = Cmd.ExecuteReader();
            //preencher uma lista com o resultado
            //criando a lista vazia
            List<CategoriaDto> lista = new List<CategoriaDto>();

            //para cada linha retornado da tabela..
            while (Dr.Read())
            {
                CategoriaDto categoria = new CategoriaDto();
                categoria.id = Convert.ToInt32(Dr["idCategoria"]);
                categoria.nome = Convert.ToString(Dr["nome"]);
                lista.Add(categoria);
            }

            Desconectar();


            return lista;
        }
    }
}

using System;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SenacShop.DAL
{
    public class Conexao
    {
        //conexão
        protected SqlConnection Conn;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        public void Conectar()
        {
            Conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SenacShop; Integrated Security = True; Connect Timeout = 30; Encrypt = False;");
            Conn.Open();
        }

        public void Desconectar()
        {
            Conn.Close();
        }
    }
}

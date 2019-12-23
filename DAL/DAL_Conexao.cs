using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DAL_Conexao
    {
        //  string connString = 
        MySqlConnection con = new MySqlConnection();
        public String mensagem = "";

        public DAL_Conexao()
        {
            con.ConnectionString = "Server=localhost;Database=sistema_pro;Uid=root;Pwd=";

        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    this.mensagem = "Conexão feita com Sucesso";
                }
                catch
                {
                    this.mensagem = "Erro na Conexão";
                }
                
            }

            return con;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                
            }
        }
    }
}

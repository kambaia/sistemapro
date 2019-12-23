using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELO;

namespace DAL
{
   public class DAL_Usuarios
    {
        DAL_Conexao con = new DAL_Conexao();
        public DAL_Usuarios()
        {
            
        }

        public void InserirUsuario( modelo_Usuario user)
        {
            DAL_Conexao conexao = new DAL_Conexao();
            MySqlCommand comandos = new MySqlCommand();
    
            comandos.CommandText = "INSERT INTO User (nome, email, idade) values (@nome, @email, @idade)";

            comandos.Parameters.AddWithValue("@nome", user.Username);

            try
            {
                comandos.Connection = conexao.conectar();
                comandos.ExecuteNonQuery();
                conexao.Desconectar();
                con.mensagem = "Cadastro feito com sucesso!";
            }
            catch (MySqlException e)
            {
                con.mensagem = "Erro Ao tentar se conextar!" + e;
            }
       }
    }
}

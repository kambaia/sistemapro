using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Conexao
    {
        //  string connString = 
        MySqlConnection  con = new MySqlConnection();
          
        public Conexao()
        {
                con.ConnectionString = "Server=localhost;Database=banco_rh;Uid=root;Pwd=";
            
        }

        public MySqlConnection conextar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

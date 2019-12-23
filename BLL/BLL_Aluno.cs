using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Aluno
    {
        public BLL_Aluno()
        {
            DAL_Conexao con = new DAL_Conexao();
            con.conectar();
        }
        
        
        
    }

    
}

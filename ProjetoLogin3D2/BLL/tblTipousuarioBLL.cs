using ProjetoLogin3D2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.BLL
{
    public class tblTipousuarioBLL
    {
        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarTipoUsuario()
        {
            string sql = string.Format($@"select * from tbl_tipousuario");
            return daoBanco.executarConsulta(sql);
        }
    }
}
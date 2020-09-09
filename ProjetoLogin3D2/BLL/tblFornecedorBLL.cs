using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoLogin3D2.DAL;
using ProjetoLogin3D2.DTO;
using System.Data;

namespace ProjetoLogin3D2.BLL
{
    public class tblFornecedorBLL
    {
        //instanciando classe DAL
        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarFornecedor()
        {
            //criando string de conexão
            string consulta = string.Format($@"select * from tbl_fornecedor;");
            //executando consulta
            DataTable dt = daoBanco.executarConsulta(consulta);
            //retornando dados do banco
            return dt;
                        
        }
        public DataTable ListarFornecedor(string nome)
        {
            string consulta = string.Format($@"select * from tbl_fornecedor where nome like '%{nome}%';");
            DataTable dt = daoBanco.executarConsulta(consulta);
            return dt;
            //tbl_fornecedor só tem id, nome, email e telefone
            
        }


            }

    
}


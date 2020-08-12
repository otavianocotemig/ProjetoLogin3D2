﻿using ProjetoLogin3D2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.BLL
{
    public class tblClienteBLL
    {
        private DALMysql daoBanco = new DALMysql();

        public Boolean Autenticar(string email,string senha)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}' and senha_cliente = '{senha}';");
            DataTable dt = daoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Criação do metodo para recuperar a senha do usuário
        public string RecuperarSenha(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = daoBanco.executarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha_cliente"].ToString();
            }
            else
            {
                return "Senha nâo localizada";    
            }
        }

        public string RecuperarTipoUsuario(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = daoBanco.executarConsulta(consulta);
           
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["tp_usuario"].ToString();
            }
            else
            {
                return "Tipo não Localizado";
            }
        }

        // Metodo para Consultar os dados do Cliente
        public DataTable ListarClientes(string email)
        {
            string sql = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            return daoBanco.executarConsulta(sql);
        }

        public DataTable ListarClientes()
        {
            string sql = string.Format($@"select * from tbl_cliente");
            return daoBanco.executarConsulta(sql);
        }


    }
}
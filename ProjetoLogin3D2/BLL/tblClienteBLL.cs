using ProjetoLogin3D2.DAL;
using ProjetoLogin3D2.DTO;
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
        // Metodo utilizado para Update na tabela Cliente
        public void AlterarCliente(tblClienteDTO dtoCliente)
        {
            string sql = string.Format($@"UPDATE tbl_cliente set nome_cliente = '{dtoCliente.Nome_cliente}',
                                                                 sobrenome_cliente = '{dtoCliente.Sobrenome_cliente}',
                                                                 cpf_cliente = '{dtoCliente.Cpf_cliente}',
                                                                 senha_cliente = '{dtoCliente.Senha_cliente}'
                                                where email_cliente = '{dtoCliente.Email_cliente}';");
            daoBanco.executarComando(sql);

        }
        // Metodo para Pesquisar Clientes no banco de dados de acordo com a condicao
        
        public DataTable PesquisarClientes(string clausula)
        {
            string sql = string.Format($@"select id_cliente as Codigo, nome_cliente as Nome, sobrenome_cliente as Sobrenome, email_cliente as Email, cpf_cliente as CPF from tbl_cliente where "+clausula);
            return daoBanco.executarConsulta(sql);
        }
        // Metodo para Inserir Clientes
        public void InserirCliente(tblClienteDTO dtoCliente)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL,'{dtoCliente.Nome_cliente}',
                                                                               '{dtoCliente.Sobrenome_cliente}',   
                                                                               '{dtoCliente.Email_cliente}',
                                                                               '{dtoCliente.Senha_cliente}',
                                                                               '{dtoCliente.Cpf_cliente}',
                                                                               '{dtoCliente.Tp_usuario}');");
            daoBanco.executarComando(sql);

        }
    }
}
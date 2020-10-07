using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.DTO
{
    public class tblClienteDTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente, sobrenome_cliente, cpf_cliente, senha_cliente, email_cliente;
        private string cep, endereco, bairro, cidade;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }


        public int Tp_usuario { 
            set
            {
                if (value != 0)
                {
                    this.tp_usuario = value;
                }
                else
                {
                    this.tp_usuario = 2;
                }
            }

            get { return this.tp_usuario; }
        }
       

        public string Nome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório");
                }

            }
            get { return this.nome_cliente; }

        }

        public string Sobrenome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.sobrenome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo SobreNome é obrigatório");
                }
                
            }                           
            get { return this.sobrenome_cliente; }

        }

        public string Email_cliente
        { 
            set
            {
                if (value != string.Empty)
                {
                    this.email_cliente = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório");
                }

            }
            get { return this.email_cliente; }
        
        }

        public string Senha_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.senha_cliente = value;
                }
                else
                {
                    throw new Exception("O campo Senha é obrigatório");
                }

            }
            get { return this.senha_cliente; }

        }
        public string Cpf_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo CPF é obrigatório");
                }

            }
            get { return this.cpf_cliente; }

        }

       
    }
}
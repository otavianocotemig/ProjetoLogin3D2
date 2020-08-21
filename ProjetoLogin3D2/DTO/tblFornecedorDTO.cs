using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.DTO
{
    // dados para criar as variaveis
    //    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    //    nome VARCHAR(50) NOT NULL ok,
    //    email       VARCHAR(50) NOT NULL ok,
    //    telefone    VARCHAR(50) NOT NULL ok
    public class tblFornecedorDTO
    {
        //atributos
        private int id;
        private string nome;
        private string email;
        private string telefone;

        //metodos de encapsulamento
        public int Id { get => id; set => id = value; }

        public string Nome
        {

            set
            {
                if (value != string.Empty)
                {
                    if (value.Length <= 50)
                    {
                        this.nome = value;
                    }
                    else
                    {
                        throw new Exception("O número máximo de caracteres é 50!");
                    }
                }
                else
                {
                    throw new Exception("O campo nome é inválido!");
                }
            }
            get
            {
                return this.nome;
            }
        }

        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    if (value.Length <= 50)
                    {
                        this.email = value;
                    }
                    else
                    {
                        throw new Exception("O número máximo de caracteres é 50!");
                    }
                }
                else
                {
                    throw new Exception("O campo email é inválido!");
                }
            }
            get
            {
                return this.email;
            }
        }

        public string Telefone
        {
            set
            {
                if (value != string.Empty)
                {
                    if (value.Length <= 50)
                    {
                        this.telefone = value;
                    }
                    else
                    {
                        throw new Exception("O número máximo de caracteres é 50!");
                    }
                }
                else
                {
                    throw new Exception("O campo telefone é inválido!");
                }
            }
            get
            {
                return this.telefone;
            }
        }
    }

}

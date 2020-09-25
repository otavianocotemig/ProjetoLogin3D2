using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.DTO
{
    public class tblProdutoDTO
    {
        // Atributos
        private int id, quantidade, tbl_categoria_id, tbl_fornecedor_id;
        private String nomeProduto, descricao;
        private String foto;
        private Double preco, peso;
        // Metodos
        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int Tbl_fornecedor_id { get => tbl_fornecedor_id; set => tbl_fornecedor_id = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Foto { get => foto; set => foto = value; }

        public string NomeProduto
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeProduto = value;
                }
                else
                {
                    throw new Exception("O campo Nome do produto é obrigatório");
                }

            }
            get { return this.nomeProduto; }

        }
        public string Descricao
        {
            set
            {
                if (value != string.Empty)
                {
                    this.descricao = value;
                }
                else
                {
                    throw new Exception("O campo Descrição do produto é obrigatório");
                }

            }
            get { return this.descricao; }

        }

        public int Tbl_categoria_id
        {
            set
            {
                if (value != 0)
                {
                    this.tbl_categoria_id = value;
                }
                else
                {
                    throw new Exception("O campo Categoria do produto é obrigatório");
                }

            }
            get { return this.tbl_categoria_id; }

        }

       
    }
}
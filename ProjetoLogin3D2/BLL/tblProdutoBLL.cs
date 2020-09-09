using ProjetoLogin3D2.DAL;
using ProjetoLogin3D2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.BLL
{
    public class tblProdutoBLL
    {
        DALMysql daoBanco = new DALMysql();
        // Metodo Utilizado para Pesquisar Produtos
        public DataTable PesquisarProdutos(string condicao)
        {
            string consulta = string.Format($@"SELECT p.Id,p.nomeProduto ,p.descricao,p.preco,p.quantidade,c.descricao as Categoria,f.nome as Fornecedor from tbl_produto as p, tbl_categoria as c,tbl_fornecedor as f where p.tbl_categoria_id = c.id and p.tbl_fornecedor_id = f.id and "+ condicao+";");
            return daoBanco.executarConsulta(consulta);
        }
        // Metodo para Excluir Produtos
        public void ExcluirProdutos(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"DELETE FROM tbl_produto where id = {dtoProduto.Id};");
            daoBanco.executarComando(sql);
        }
        //Metodo Utilizado para Incluir
        public void InserirProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"INSERT INTO tbl_produto VALUES (NULL,'{dtoProduto.NomeProduto}',
                                                                               '{dtoProduto.Descricao}',   
                                                                               '{dtoProduto.Preco}',
                                                                               '{dtoProduto.Quantidade}',
                                                                               '{dtoProduto.Peso}',
                                                                               '{dtoProduto.Tbl_categoria_id}',
                                                                               '{dtoProduto.Tbl_fornecedor_id}');");

            daoBanco.executarComando(sql);

        }

    }
}
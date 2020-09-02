using ProjetoLogin3D2.DAL;
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

        public DataTable PesquisarProdutos(string condicao)
        {
            string consulta = string.Format($@"SELECT p.Id,p.nomeProduto ,p.descricao,p.preco,p.quantidade,c.descricao as Categoria,f.nome as Fornecedor from tbl_produto as p, tbl_categoria as C,tbl_fornecedor as F where p.tbl_categoria_id = c.id and p.tbl_fornecedor_id = f.id and "+ condicao+";");
            return daoBanco.executarConsulta(consulta);
        }
    }
}
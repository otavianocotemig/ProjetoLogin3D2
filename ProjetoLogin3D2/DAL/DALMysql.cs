﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.DAL
{
    public class DALMysql
    {
        private MySqlConnection conexao;
     // private string string_conexao = "Persist security info = false;" +
     //                                   "server=localhost;" +
     //                                   "database=dbmvc;" +
     //                                   "user=root ; pwd=;";
      private string string_conexao = "Persist security info = false;" +
                                                  "server=108.179.253.169;" +
                                                  "database=silin091_cotemig20201;" +
                                                  "user=silin091_cotemig ; pwd=cotemig2020;";
//

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas de conexão com banco de dados. \nErro: " + e.Message);
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco de Dados.. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível selecionar os registros no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
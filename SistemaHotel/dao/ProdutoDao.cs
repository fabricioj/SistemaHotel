using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaHotel.dao
{
    public class ProdutoDao
    {
        private MySqlConnection conexao = util.BancoDados.conectar();
        private string sqlInsert = "INSERT INTO produto(descricao,controla_estoque,quantidade)VALUES(@descricao,@controla_estoque,@quantidade)";
        private string sqlUpdate = "UPDATE produto SET descricao = @descricao, controla_estoque = @controla_estoque, quantidade = @quantidade WHERE id = @id";
        private string sqlDelete = "DELETE from produto WHERE id = @id";
        private string sqlSelectPorId = "SELECT * FROM produto where id = @id";
        private string sqlSelect = "SELECT * FROM produto";
        private string sqlSelectDescricao = "SELECT * FROM produto where descricao like @descricao";

        public void incluir(ref Produto_old produto)
        {            
            MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("descricao", produto.descricao);
            cmd.Parameters.AddWithValue("controla_estoque", ((int)produto.controla_estoque).ToString().Trim());
            cmd.Parameters.AddWithValue("quantidade", produto.quantidade);
            cmd.ExecuteNonQuery();
            
            produto.id = unchecked((int)cmd.LastInsertedId);
            cmd.Connection.Close();
            

        }
        public void alterar(Produto_old produto)
        {
            MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("descricao", produto.descricao);
            cmd.Parameters.AddWithValue("controla_estoque", ((int)produto.controla_estoque).ToString().Trim());
            cmd.Parameters.AddWithValue("quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("id", produto.id);
            cmd.ExecuteNonQuery();            
            cmd.Connection.Close();
        }
        public void excluir(Produto_old produto)
        {
            MySqlCommand cmd = new MySqlCommand(sqlDelete, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", produto.id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Produto_old getProdutoporID(int id) {
            MySqlCommand cmd = new MySqlCommand(sqlSelectPorId, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader dtreader = cmd.ExecuteReader();
            Produto_old produto = null;
            while (dtreader.Read()) {
                produto = new Produto_old
                {
                    id = dtreader.GetInt32("id"),
                    descricao = dtreader.GetString("descricao"),
                    controla_estoque = (util.SimNao)(int.Parse(dtreader.GetString("controla_estoque"))),
                    quantidade = dtreader.GetDouble("quantidade")

                };
                break;
            }
            return produto;
        }

        public List<Produto_old> getProdutos() {
            List<Produto_old> produtos = new List<Produto_old>();
            MySqlCommand cmd = new MySqlCommand(sqlSelect, conexao);
            cmd.Connection.Open();
            MySqlDataReader dtreader = cmd.ExecuteReader();
            while (dtreader.Read())
            {
                produtos.Add(new Produto_old
                {
                    id = dtreader.GetInt32("id"),
                    descricao = dtreader.GetString("descricao"),
                    controla_estoque = (util.SimNao)(int.Parse(dtreader.GetString("controla_estoque"))),
                    quantidade = dtreader.GetDouble("quantidade")

                });
            }
            cmd.Connection.Close();
            return produtos;
        }

        public List<Produto_old> getProdutos(string descricao)
        {
            List<Produto_old> produtos = new List<Produto_old>();
            MySqlCommand cmd = new MySqlCommand(sqlSelectDescricao, conexao);
            cmd.Parameters.AddWithValue("descricao", descricao + "%");
            cmd.Connection.Open();
            MySqlDataReader dtreader = cmd.ExecuteReader();
            while (dtreader.Read())
            {
                produtos.Add(new Produto_old
                {
                    id = dtreader.GetInt32("id"),
                    descricao = dtreader.GetString("descricao"),
                    controla_estoque = (util.SimNao)(int.Parse(dtreader.GetString("controla_estoque"))),
                    quantidade = dtreader.GetDouble("quantidade")

                });
            }
            cmd.Connection.Close();
            return produtos;
        }
    }
}

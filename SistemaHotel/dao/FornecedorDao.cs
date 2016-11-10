using MySql.Data.MySqlClient;
using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.dao
{
    public class FornecedorDao
    {
        private MySqlConnection conexao = util.BancoDados.conectar();
        private string sqlInsert = "INSERT INTO fornecedor (nome, razao_social, cnpj, telefone, endereco, bairro, cidade, cep, estado, numero) VALUES (@nome, @razao_social, @cnpj, @telefone, @endereco, @bairro, @cidade, @cep, @estado, @numero)";
        private string sqlUpdate = "UPDATE fornecedor SET nome = @nome, razao_social = @razao_social, cnpj = @cnpj, telefone = @telefone, endereco = @endereco, bairro = @bairro, cidade = @cidade, cep = @cep, estado = @estado, numero = @numero WHERE id = @id";
        private string sqlDelete = "DELETE from fornecedor WHERE id = @id";
        private string sqlSelectPorId = "SELECT * FROM fornecedor where id = @id";
        private string sqlSelect = "SELECT * FROM fornecedor";
        private string sqlSelectNome = "SELECT * FROM fornecedor where nome like @nome";

        public void incluir(Fornecedor_old fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("razao_social", fornecedor.razao_social);
            cmd.Parameters.AddWithValue("cnpj", fornecedor.cnpj);
            cmd.Parameters.AddWithValue("telefone", fornecedor.telefone);
            cmd.Parameters.AddWithValue("endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("bairro", fornecedor.bairro);
            cmd.Parameters.AddWithValue("cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("cep", fornecedor.cep);
            cmd.Parameters.AddWithValue("estado", fornecedor.estado);
            cmd.Parameters.AddWithValue("numero", fornecedor.numero);
            cmd.ExecuteNonQuery();

            fornecedor.id = unchecked((int)cmd.LastInsertedId);
            cmd.Connection.Close();
        }
        public void alterar(Fornecedor_old fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("razao_social", fornecedor.razao_social);
            cmd.Parameters.AddWithValue("cnpj", fornecedor.cnpj);
            cmd.Parameters.AddWithValue("telefone", fornecedor.telefone);
            cmd.Parameters.AddWithValue("endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("bairro", fornecedor.bairro);
            cmd.Parameters.AddWithValue("cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("cep", fornecedor.cep);
            cmd.Parameters.AddWithValue("estado", fornecedor.estado);
            cmd.Parameters.AddWithValue("numero", fornecedor.numero);
            cmd.Parameters.AddWithValue("id", fornecedor.id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void excluir(Fornecedor_old fornecedor)
        {
            MySqlCommand cmd = new MySqlCommand(sqlDelete, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", fornecedor.id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Fornecedor_old getFornecedorporID(int id) {
            MySqlCommand cmd = new MySqlCommand(sqlSelectPorId, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("id", id);
            MySqlDataReader dtreader = cmd.ExecuteReader();
            Fornecedor_old fornecedor = null;
            while (dtreader.Read())
            {
                fornecedor = new Fornecedor_old
                {
                    id           = dtreader.GetInt32("id"           ),
                    nome         = dtreader.GetString("descricao"   ),
                    razao_social = dtreader.GetString("razao_social"),
                    cnpj         = dtreader.GetString("cnpj"        ),
                    telefone     = dtreader.GetString("telefone"    ),
                    endereco     = dtreader.GetString("endereco"    ),
                    bairro       = dtreader.GetString("bairro"      ),
                    cidade       = dtreader.GetString("cidade"      ),
                    cep          = dtreader.GetString("cep"         ),
                    estado       = dtreader.GetString("estado"      ),
                    numero       = dtreader.GetString("numero"      )

                };
                break;
            }
            return fornecedor;
        }

        public List<Fornecedor_old> getFornecedores() {
            List<Fornecedor_old> fornecedores = new List<Fornecedor_old>();
            MySqlCommand cmd = new MySqlCommand(sqlSelect, conexao);
            cmd.Connection.Open();
            MySqlDataReader dtreader = cmd.ExecuteReader();
            while (dtreader.Read())
            {
                fornecedores.Add(new Fornecedor_old
                {
                    id = dtreader.GetInt32("id"),
                    nome = dtreader.GetString("nome"),
                    razao_social = dtreader.GetString("razao_social"),
                    cnpj = dtreader.GetString("cnpj"),
                    telefone = dtreader.GetString("telefone"),
                    endereco = dtreader.GetString("endereco"),
                    bairro = dtreader.GetString("bairro"),
                    cidade = dtreader.GetString("cidade"),
                    cep = dtreader.GetString("cep"),
                    estado = dtreader.GetString("estado"),
                    numero = dtreader.GetString("numero")

                });
            }
            cmd.Connection.Close();
            return fornecedores;
        }

        public List<Fornecedor_old> getFornecedores(string nome)
        {
            List<Fornecedor_old> fornecedores = new List<Fornecedor_old>();
            MySqlCommand cmd = new MySqlCommand(sqlSelectNome, conexao);
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("nome", nome + "%");
            MySqlDataReader dtreader = cmd.ExecuteReader();
            while (dtreader.Read())
            {
                fornecedores.Add(new Fornecedor_old
                {
                    id = dtreader.GetInt32("id"),
                    nome = dtreader.GetString("nome"),
                    razao_social = dtreader.GetString("razao_social"),
                    cnpj = dtreader.GetString("cnpj"),
                    telefone = dtreader.GetString("telefone"),
                    endereco = dtreader.GetString("endereco"),
                    bairro = dtreader.GetString("bairro"),
                    cidade = dtreader.GetString("cidade"),
                    cep = dtreader.GetString("cep"),
                    estado = dtreader.GetString("estado"),
                    numero = dtreader.GetString("numero")

                });
            }
            cmd.Connection.Close();
            return fornecedores;
        }
    }
}

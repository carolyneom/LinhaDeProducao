using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Produtos : Conexao
    {   
        public int id;

        public string nome;

        public int id_empresa;

        public DateTime data_cadastro;

        public List<Produtos> GetListaProdutos()
        {
            List<Produtos> produtos = new List<Produtos>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM produtos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Produtos novoProdutos = new Produtos();

                            novoProdutos.id = Convert.ToInt32(reader.GetString("id"));
                            novoProdutos.nome = reader.GetString("nome");
                            novoProdutos.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoProdutos.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            produtos.Add(novoProdutos);
                        }

                    }


                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return produtos;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `produtos` (`nome`, `id_empresa`) VALUES (@nome, @id_empresa);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@telefone", this.id_empresa),
                };

                this.ExecuteQueryWithParameters(query, param);

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
    }
}

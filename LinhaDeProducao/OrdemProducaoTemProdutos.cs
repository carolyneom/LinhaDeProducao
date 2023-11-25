using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class OrdemProducaoTemProdutos : Conexao 
    {
        public int id;

        public int id_ordem;

        public int id_produto;

        public int quantidade;

        public DateTime data_cadastro;

        public List<OrdemProducaoTemProdutos> GetListaOrdemProducaoTemProdutos()
        {
            List<OrdemProducaoTemProdutos> ordemProducaoTemProdutos = new List<OrdemProducaoTemProdutos>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM ordem_producao_tem_produtos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            OrdemProducaoTemProdutos novaOrdemProducaoTemProdutos = new OrdemProducaoTemProdutos();

                            novaOrdemProducaoTemProdutos.id = Convert.ToInt32(reader.GetString("id"));
                            novaOrdemProducaoTemProdutos.id_ordem = Convert.ToInt32(reader.GetString("id_ordem"));
                            novaOrdemProducaoTemProdutos.id_produto = Convert.ToInt32(reader.GetString("id_produto"));
                            novaOrdemProducaoTemProdutos.quantidade = Convert.ToInt32(reader.GetString("quantidade"));
                            novaOrdemProducaoTemProdutos.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            ordemProducaoTemProdutos.Add(novaOrdemProducaoTemProdutos);
                        }

                    }


                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ordemProducaoTemProdutos;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producao_tem_produtos` (`id_ordem`, `id_produto`, `quantidade`) VALUES (@id_ordem, @id_produto, @quantidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_ordem", this.id_ordem),
                new MySqlParameter("@id_produto", this.id_produto),
                new MySqlParameter("@quantidade", this.quantidade),
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


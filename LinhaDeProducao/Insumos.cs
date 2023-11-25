using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Insumos : Conexao
    {
        public int id;

        public int id_produto;

        public string nome;

        public double quantidade;

        public string unidade;

        public DateTime data_cadastro;

        public List<Insumos> GetListaInsumos()
        {
            List<Insumos> insumos = new List<Insumos>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM insumos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Insumos novoInsumo = new Insumos();

                            novoInsumo.id = Convert.ToInt32(reader.GetString("id"));
                            novoInsumo.id_produto= Convert.ToInt32(reader.GetString("id_produto"));
                            novoInsumo.nome = reader.GetString("nome");
                            novoInsumo.quantidade = Convert.ToDouble(reader.GetString("quantidade"));
                            novoInsumo.unidade = reader.GetString("unidade");
                            novoInsumo.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            insumos.Add(novoInsumo);
                        }

                    }

                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return insumos;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `insumos` (`id_produto`, `nome`, `quantidade`, `unidade`) VALUES (@id_produto, @nome, @quantidade, @unidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_produto),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@quantidade", this.quantidade),
                new MySqlParameter("@unidade", this.unidade),
               
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

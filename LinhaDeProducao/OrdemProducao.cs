using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class OrdemProducao : Conexao
    {
        public int id;

        public int id_empresa;

        public int id_setor;

        public int id_cliente;

        public DateTime data_cadastro;

        public List<OrdemProducao> GetListaOrdemProducao()
        {
            List<OrdemProducao> ordemProducao = new List<OrdemProducao>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM ordemProducao";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            OrdemProducao novaOrdemProducao = new OrdemProducao();

                            novaOrdemProducao.id = Convert.ToInt32(reader.GetString("id"));
                            novaOrdemProducao.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novaOrdemProducao.id_setor = Convert.ToInt32(reader.GetString("id_setor"));
                            novaOrdemProducao.id_cliente = Convert.ToInt32(reader.GetString("id_cliente"));
                            novaOrdemProducao.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            ordemProducao.Add(novaOrdemProducao);
                        }

                    }


                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ordemProducao;
        }

        public bool Insert()
        {

            try
            {

                 string query = "INSERT INTO `ordem_producao` (`id_empresa`, `id_setor`, `id_cliente`) VALUES (@id_empresa, @id_setor, @id_cliente);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
                new MySqlParameter("@id_cliente", this.id_cliente),
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


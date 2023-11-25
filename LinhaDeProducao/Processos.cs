using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Processos : Conexao
    {
        public int id;

        public string nome;

        public int id_setor;

        public DateTime data_cadastro;

        public List<Processos> GetListaProcessos()
        {
            List<Processos> processos = new List<Processos>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM processos";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Processos novoProcessos = new Processos();

                            novoProcessos.id = Convert.ToInt32(reader.GetString("id"));
                            novoProcessos.nome = reader.GetString("nome");
                            novoProcessos.id_setor = Convert.ToInt32(reader.GetString("id_setor"));
                            novoProcessos.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            processos.Add(novoProcessos);
                        }

                    }


                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return processos;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `processos` ( `nome`, `id_setor`) VALUES (@nome, @id_setor);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_setor", this.id_setor),
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
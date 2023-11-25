using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Setores : Conexao
    {
        public int id;

        public string nome;

        public int id_empresa;

        public int id_responsavel;

        public DateTime data_cadastro;

        public List<Setores> GetListaSetores()
        {
            List<Setores> setores = new List<Setores>();

            try
            {

                OpenConnection();




                string query = "SELECT * FROM setores";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Setores novoSetores = new Setores();

                            novoSetores.id = Convert.ToInt32(reader.GetString("id"));
                            novoSetores.nome = reader.GetString("nome");
                            novoSetores.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoSetores.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novoSetores.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            setores.Add(novoSetores);
                        }

                    }


                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return setores;
        }
            public bool Insert()
            {

                try
                {



                    string query = "INSERT INTO `setores` (`nome`, `id_empresa`, `id_responsavel`) VALUES (@nome, @id_empresa, @id_responsavel);";

                    MySqlParameter[] param = new MySqlParameter[]
                    {
                     new MySqlParameter("@nome", this.nome),
                     new MySqlParameter("@id_empresa", this.id_empresa),
                     new MySqlParameter("@id_responsavel", this.id_responsavel),
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
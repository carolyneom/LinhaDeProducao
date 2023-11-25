using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Empresas : Conexao
    {
        public int id;

        public string nome;

        public string cnpj;

        public string email;

        public DateTime data_cadastro;

        public List<Empresas> GetListaEmpresas()
        {
            List<Empresas> empresas = new List<Empresas>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM empresas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empresas novaEmpresa = new Empresas();

                            novaEmpresa.id = Convert.ToInt32(reader.GetString("id"));
                            novaEmpresa.nome = reader.GetString("nome");
                            novaEmpresa.cnpj = reader.GetString("cnpj");
                            novaEmpresa.email = reader.GetString("email");
                            novaEmpresa.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            empresas.Add(novaEmpresa);
                        }

                    }

                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);

            }

            return empresas;
        }
            public bool Insert()
            {

                try
                {

                    string query = "INSERT INTO `empresas` (`nome`, `cnpj`, `email`) VALUES (@nome, @cnpj, @email);";

                    MySqlParameter[] param = new MySqlParameter[]
                    {
                     new MySqlParameter("@nome", this.nome),
                     new MySqlParameter("@cnpj", this.cnpj),
                     new MySqlParameter("@email", this.email),
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
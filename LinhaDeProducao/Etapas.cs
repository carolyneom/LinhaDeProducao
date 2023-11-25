﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Etapas : Conexao
    {
        public int id;

        public string nome;

        public int ordem;

        public int id_processo;

        public DateTime data_cadastro;

        public List<Etapas> GetListaEtapas()
        {
            List<Etapas> etapas = new List<Etapas>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM etapas";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etapas novaEtapa = new Etapas();

                            novaEtapa.id = Convert.ToInt32(reader.GetString("id"));
                            novaEtapa.nome = reader.GetString("nome");
                            novaEtapa.ordem = Convert.ToInt32(reader.GetString("ordem"));
                            novaEtapa.id_processo = Convert.ToInt32(reader.GetString("id_processo"));
                            novaEtapa.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            etapas.Add(novaEtapa);
                        }

                    }

                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return etapas;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `etapas` (`nome`, `ordem`, `id_processo`) VALUES (@nome, @ordem, @id_processo);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@ordem", this.ordem),
                new MySqlParameter("@id_processo", this.id_processo),
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

﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhaDeProducao
{
    internal class Funcionarios : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        private int nivel;

        public DateTime data_cadastro;

        public void SetSenha(string senha)
        {
            this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int GetNivel()
        {
            return this.nivel;
        }

        public List<Funcionarios> GetListaFuncionarios()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM funcionarios";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Funcionarios novoFuncionario = new Funcionarios();

                            novoFuncionario.id = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome = reader.GetString("nome");
                            novoFuncionario.email = reader.GetString("email");
                            novoFuncionario.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoFuncionario.SetSenha(reader.GetString("senha"));
                            novoFuncionario.SetNivel(Convert.ToInt32(reader.GetString("nivel")));

                            funcionarios.Add(novoFuncionario);
                        }

                    }

                }

                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return funcionarios;
        }

        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `funcionarios` (`id_empresa`, `nome`, `email`, `senha` , `nivel `) VALUES (@id_empresa, @nome, @email, @senha, @nivel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@email", this.email),
                new MySqlParameter("@senha", this.senha),
                new MySqlParameter("@nivel", this.nivel),
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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaDeProducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                Etapas etapas = new Etapas();

                etapas.nome = "Etapa 7";
                etapas.ordem = 6;
                etapas.id_processo = 2;

                etapas.Insert();

                MessageBox.Show("Etapa adicionada com sucesso");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

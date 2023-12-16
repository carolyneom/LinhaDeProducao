using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaDeProducao.view
{
    public partial class PaginaFuncionarios : Form
    {
        public PaginaFuncionarios()
        {
            InitializeComponent();


            try
            {

                List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

                Funcionarios funcionarios = new Funcionarios();

                listaFuncionarios = funcionarios.GetListaFuncionarios();



                listViewFuncionarios.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewFuncionarios.View = View.Details;
                listViewFuncionarios.LabelEdit = true;
                listViewFuncionarios.AllowColumnReorder = true;
                listViewFuncionarios.CheckBoxes = true;
                listViewFuncionarios.FullRowSelect = true;
                listViewFuncionarios.GridLines = true;
                listViewFuncionarios.Sorting = SortOrder.Ascending;

                listViewFuncionarios.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewFuncionarios.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("EMAIL", -2, HorizontalAlignment.Center);

                foreach (Clientes cliente in clientes.GetListaClientes())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(cliente.id.ToString());
                    item.SubItems.Add(cliente.nome);
                    item.SubItems.Add(cliente.email);
                    listViewClientes.Items.Add(item);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PaginaFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

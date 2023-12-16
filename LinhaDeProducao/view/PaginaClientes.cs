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
    public partial class PaginaClientes : Form
    {
        private object comboBoxCliente;

        public PaginaClientes()
        {
            InitializeComponent();

            labelName.Text = nome();


            try {
             
                List<Clientes> listaClientes = new List<Clientes>();

                Clientes clientes = new Clientes();

                listaClientes = clientes.GetListaClientes();

                comboBoxCliente.DataSource = listaClientes;
                comboBoxCliente.DisplayMember = "nome";
                comboBoxCliente.ValueMember = "id";

                listViewClientes.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewClientes.View = View.Details;
                listViewClientes.LabelEdit = true;
                listViewClientes.AllowColumnReorder = true;
                listViewClientes.CheckBoxes = true;
                listViewClientes.FullRowSelect = true;
                listViewClientes.GridLines = true;
                listViewClientes.Sorting = SortOrder.Ascending;
                
                listViewClientes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
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
             
            } catch (Exception ex) {
             
                MessageBox.Show(ex.Message);
             
            }

        }

        private void PaginaClientes_Load(object sender, EventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

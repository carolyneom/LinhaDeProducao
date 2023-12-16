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
    public partial class PaginaEtapas : Form
    {
        private object listViewEtapas;

        public PaginaEtapas()
        {
            InitializeComponent();


            try
            {

                List<Etapas> etapas= new List<Etapas>();

                Etapas etapa = new Etapas();

                listaEtapas = etapa.GetListaEtapas();


                listViewEtapas.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewEtapas.View = View.Details;
                listViewEtapas.LabelEdit = true;
                listViewEtapas.AllowColumnReorder = true;
                listViewEtapas.CheckBoxes = true;
                listViewEtapas.FullRowSelect = true;
                listViewEtapas.GridLines = true;
                listViewEtapas.Sorting = SortOrder.Ascending;

                listViewEtapas.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ORDEM ", -2, HorizontalAlignment.Center);
                listViewEtapas.Columns.Add("ID_PROCESSO ", -2, HorizontalAlignment.Center);
               

                foreach (Etapas etapas in etapa.GetListaEtapas())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(etapa.id.ToString());
                    item.SubItems.Add(etapa.nome);
                    item.SubItems.Add(etapa.ordem);
                    item.SubItems.Add(etapa.id_processo);
                    listViewEtapas.Items.Add(item);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }









        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

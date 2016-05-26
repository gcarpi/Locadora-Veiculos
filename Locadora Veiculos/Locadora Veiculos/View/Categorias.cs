using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_Veiculos
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente sair?",
              "Sair",
             MessageBoxButtons.OKCancel);
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirCategoria nova = new ExibirCategoria();
            nova.Show();
        }

        private void toolStripButton_Nova_Click(object sender, EventArgs e)
        {
            NovaCategoria nova = new NovaCategoria();
            nova.Show();
        }

        private void Categorias_Activated(object sender, EventArgs e)
        {
            dataGridView_Categoria.Rows.Clear();

            foreach (Categoria categoria in new CategoriaDAO().Listar())
            {
                int index = dataGridView_Categoria.Rows.Add();
                DataGridViewRow dado = dataGridView_Categoria.Rows[index];
                dado.Cells["ID"].Value = categoria.CodigoCategoria;
                dado.Cells["Nome"].Value = categoria.Nome;
                dado.Cells["Valor"].Value = categoria.Valor;
            }
        }

        private void dataGridView_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirCategoria nova = new ExibirCategoria(long.Parse(dataGridView_Categoria.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
            nova.ShowDialog();
        }
    }
}

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
    }
}

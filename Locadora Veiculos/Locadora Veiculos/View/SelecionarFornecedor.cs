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
    public partial class SelecionarFornecedor : Form
    {
        public SelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroFornecedor novo = new CadastroFornecedor();
            novo.Show();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja selecionar o fornecedor?",
             "Seleção Fornecedor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }
    }
}

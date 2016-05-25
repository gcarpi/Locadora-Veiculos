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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }
        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroFornecedor novo = new CadastroFornecedor();
            novo.Show();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirFornecedor novo = new ExibirFornecedor();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

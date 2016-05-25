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
    public partial class ExibirFornecedor : Form
    {
        public ExibirFornecedor()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {

            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Fornecedor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja efetuar a impressão do cadastro?",
            "Impressão",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void ExibirFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox_RazaoSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_CNPJ_Click(object sender, EventArgs e)
        {

        }

        private void label_InscEstadual_Click(object sender, EventArgs e)
        {

        }

        private void label_RazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void textBox_InscEstadual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_CEP_Click(object sender, EventArgs e)
        {

        }
    }
}

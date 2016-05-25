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
    public partial class CadastroVeiculos : Form
    {
        public CadastroVeiculos()
        {
            InitializeComponent();
        }
        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente cancelar?",
             "Cancelamento de cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Pesquisar_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor novo = new SelecionarFornecedor();
            novo.Show();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
             "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void label_KM_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KM_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Tanque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

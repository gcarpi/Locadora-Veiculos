using Persistencia.DAO;
using Persistencia.Modelo;
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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
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

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            if ((textBox_Nome.Text != "") && (textBox_RazaoSocial.Text != "") && (maskedTextBox_CNPJ.Text != ""))
            {
                DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?","Salvar novo cadastro",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result2 == DialogResult.OK)
                {
                    Endereco endereco = new Endereco();
                    TelefoneFornecedor telefone = new TelefoneFornecedor();
                    Fornecedor fornecedor = new Fornecedor();

                    endereco.CEP = maskedTextBox_CEP.Text;
                    endereco.Bairro = textBox_Bairro.Text;
                    endereco.Numero = maskedTextBox_N.Text;
                    endereco.Cidade = textBox_Cidade.Text;
                    endereco.Estado = comboBox_Estado.Text;

                    telefone.Telefone = maskedTextBox_Telefone.Text + ":" + maskedTextBox_Celular.Text;

                    fornecedor.NomeFantasia = textBox_Nome.Text;
                    fornecedor.RazaoSocial = textBox_RazaoSocial.Text;
                    fornecedor.CNPJ = maskedTextBox_CNPJ.Text;
                    fornecedor.InscricaoEstadual = textBox_InscEstadual.Text;
                    fornecedor.Email = textBox_Email.Text;

                    long id_e = new EnderecoDAO().Inserir(endereco);
                    fornecedor.CodigoEndereco = id_e;
                    long id_f = new FornecedorDAO().Inserir(fornecedor);
                    telefone.CodigoFornecedor = id_f;
                    new TelefoneFornecedorDAO().Inserir(telefone);
                }
            }
            else
                MessageBox.Show("Preencha corretamente as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

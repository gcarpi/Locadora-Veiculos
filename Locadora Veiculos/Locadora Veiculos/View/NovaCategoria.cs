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
    public partial class NovaCategoria : Form
    {
        public NovaCategoria()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox_Nome.Text != "") && (maskedTextBox_Valor.Text != ""))
            {
                DialogResult result1 = MessageBox.Show("Deseja salvar o novo cadastro?", "Salvar novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result1 == DialogResult.OK)
                {
                    CategoriaDAO categoria = new CategoriaDAO();
                    Categoria c = new Categoria();

                    c.Nome = maskedTextBox_Nome.Text;
                    c.Valor = Decimal.Parse(maskedTextBox_Valor.Text);

                    if (categoria.Inserir(c) != -1)
                        MessageBox.Show("Nova categoria inserida","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Preencha corretamente as informações","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);

            maskedTextBox_Nome.Text = "";
            maskedTextBox_Valor.Text = "";
        }

        private void NovaCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((maskedTextBox_Nome.Text != "") && (maskedTextBox_Valor.Text != ""))
            {
                DialogResult result1 = MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result1 == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
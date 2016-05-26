﻿using Persistencia.DAO;
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
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if ((textBox_Nome.Text != "") && (textBox_Valor != null))
                {
                    CategoriaDAO categoria = new CategoriaDAO();
                    Categoria c = new Categoria();

                    c.Nome = textBox_Nome.Text;
                    c.Valor = decimal.Parse(textBox_Valor.Text);
                    c.Status = 1;
                    categoria.Inserir(c);
                    MessageBox.Show("Categoria Inserida com Sucesso");

                }
                else
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void textBox_Valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

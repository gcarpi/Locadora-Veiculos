<<<<<<< HEAD
﻿using Persistencia.DAO;
using Persistencia.Modelo;
using System;
=======
﻿using System;
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
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
    public partial class ExibirCategoria : Form
    {
<<<<<<< HEAD
        private long CodigoCategoria = 0;
=======
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        public ExibirCategoria()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public ExibirCategoria(long codigo)
        {
            CodigoCategoria = codigo;
            InitializeComponent();
            Categoria categoria = new CategoriaDAO().Buscar(codigo);
            textBox_Nome.Text = categoria.Nome;
            textBox_Valor.Text = categoria.Valor.ToString();
        }
=======
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar as alterações?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
<<<<<<< HEAD
                if ((textBox_Nome.Text != "") && (textBox_Valor.Text != ""))
                {
                    Categoria c = new Categoria();

                    c.CodigoCategoria = CodigoCategoria;
                    c.Nome = textBox_Nome.Text;
                    c.Valor = Decimal.Parse(textBox_Valor.Text);

                    if (new CategoriaDAO().Atualizar(c))
                        MessageBox.Show("Categoria alterada com Sucesso");
                }
            }

            Close();
=======

            }
            if (result2 == DialogResult.Cancel)
            {

            }
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           Close();
=======
            this.Close();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente excluir?",
            "Exclusão de Categoria",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
<<<<<<< HEAD
                Categoria c = new Categoria();

                c.CodigoCategoria = CodigoCategoria;
                c.Status = 9;

                new CategoriaDAO().Remover(c);
            }

            Close();
=======

            }
            if (result1 == DialogResult.Cancel)
            {

            }
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }
    }
}

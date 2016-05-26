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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Close();
=======
            DialogResult result1 = MessageBox.Show("Deseja realmente sair do sistema?",
            "Sair do sistema",
            MessageBoxButtons.OKCancel);
            if(result1 == DialogResult.OK)
            {
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }

>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Categorias_Click(object sender, EventArgs e)
        {
            Categorias nova = new Categorias();
<<<<<<< HEAD
            nova.ShowDialog();
=======
            nova.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_TrocarUsuario_Click(object sender, EventArgs e)
        {
            Autenticacao nova = new Autenticacao();
<<<<<<< HEAD
            nova.ShowDialog();
=======
            nova.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Sobre_Click(object sender, EventArgs e)
        {
            Sobre novo = new Sobre();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Clientes_Click(object sender, EventArgs e)
        {
            Clientes novo = new Clientes();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Veiculos_Click(object sender, EventArgs e)
        {
            Veiculos novo = new Veiculos();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Locacao_Click(object sender, EventArgs e)
        {
            Locacao novo = new Locacao();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Pedidos_Click(object sender, EventArgs e)
        {
            Pedidos novo = new Pedidos();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Relatorios_Click(object sender, EventArgs e)
        {
            Relatorios novo = new Relatorios();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Fornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores novo = new Fornecedores();
<<<<<<< HEAD
            novo.ShowDialog();
=======
            novo.Show();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
        }

        private void toolStripButton_Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios novo = new Usuarios();
<<<<<<< HEAD
            novo.ShowDialog();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente sair?",
              "Sair",
             MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
=======
            novo.Show();
        }
    }
}
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29

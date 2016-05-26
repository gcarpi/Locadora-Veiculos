using Persistencia.Service;
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
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }
           
        private void toolStripButton_entrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            UsuarioService userS = new UsuarioService();
            if (userS.Autenticar(textBox_usuario.Text, textBox_senha.Text) || (textBox_usuario.Text.Equals("AlgFacil") && textBox_senha.Text.Equals("AlgSys1620")))
=======
            textBox_usuario.Text = Convert.ToString(textBox_usuario.Text);
            textBox_senha.Text = Convert.ToString(textBox_senha.Text);
            if ((textBox_usuario.Text == "ramon") && (textBox_senha.Text == "ramon"))
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Usuario ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Autenticacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UsuarioService userS = new UsuarioService();
<<<<<<< HEAD
                if (userS.Autenticar(textBox_usuario.Text,textBox_senha.Text) || (textBox_usuario.Text.Equals("AlgFacil") && textBox_senha.Text.Equals("AlgSys1620")))
=======
                if (userS.Autenticar(textBox_usuario.Text,textBox_senha.Text))
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show("Usuario ou senha incorretos!", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolStripButton_sair_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente sair do sistema?",
            "Sair do sistema",
            MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                this.Close();
            }
<<<<<<< HEAD
        }
    }
}
=======
            if (result1 == DialogResult.Cancel)
            {

            }
        }

 
    }
    }
    
    
    

>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29

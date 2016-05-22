namespace Locadora_Veiculos
{
    partial class CadastroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarios));
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.label_Senha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.textBox_RG = new System.Windows.Forms.TextBox();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_TipoUsuario = new System.Windows.Forms.Label();
            this.comboBox_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(306, 202);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(166, 20);
            this.textBox_Senha.TabIndex = 6;
            this.textBox_Senha.TextChanged += new System.EventHandler(this.textBox_Senha_TextChanged);
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Senha.Location = new System.Drawing.Point(249, 202);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(51, 20);
            this.label_Senha.TabIndex = 100;
            this.label_Senha.Text = "Senha:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Salvar,
            this.toolStripSeparator2,
            this.toolStripButton_Cancelar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(494, 73);
            this.toolStrip1.TabIndex = 94;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Salvar
            // 
            this.toolStripButton_Salvar.AutoSize = false;
            this.toolStripButton_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Salvar.Image")));
            this.toolStripButton_Salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salvar.Name = "toolStripButton_Salvar";
            this.toolStripButton_Salvar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Salvar.Text = "Salvar";
            this.toolStripButton_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Salvar.Click += new System.EventHandler(this.toolStripButton_Salvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Cancelar
            // 
            this.toolStripButton_Cancelar.AutoSize = false;
            this.toolStripButton_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Cancelar.Image")));
            this.toolStripButton_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cancelar.Name = "toolStripButton_Cancelar";
            this.toolStripButton_Cancelar.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Cancelar.Text = "Cancelar";
            this.toolStripButton_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Cancelar.Click += new System.EventHandler(this.toolStripButton_Cancelar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(76, 126);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(396, 20);
            this.textBox_Nome.TabIndex = 2;
            this.textBox_Nome.TextChanged += new System.EventHandler(this.textBox_Nome_TextChanged);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(76, 204);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(171, 20);
            this.textBox_Usuario.TabIndex = 5;
            this.textBox_Usuario.WordWrap = false;
            this.textBox_Usuario.TextChanged += new System.EventHandler(this.textBox_Usuario_TextChanged);
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Usuario.Location = new System.Drawing.Point(12, 202);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(58, 20);
            this.label_Usuario.TabIndex = 117;
            this.label_Usuario.Text = "Usuário:";
            // 
            // textBox_RG
            // 
            this.textBox_RG.Location = new System.Drawing.Point(306, 164);
            this.textBox_RG.Name = "textBox_RG";
            this.textBox_RG.Size = new System.Drawing.Size(166, 20);
            this.textBox_RG.TabIndex = 4;
            // 
            // label_RG
            // 
            this.label_RG.AutoSize = true;
            this.label_RG.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_RG.Location = new System.Drawing.Point(253, 164);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(32, 20);
            this.label_RG.TabIndex = 115;
            this.label_RG.Text = "RG:";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Nome.Location = new System.Drawing.Point(12, 126);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(49, 20);
            this.label_Nome.TabIndex = 114;
            this.label_Nome.Text = "Nome:";
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(76, 164);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(171, 20);
            this.textBox_CPF.TabIndex = 3;
            this.textBox_CPF.TextChanged += new System.EventHandler(this.textBox_CPF_TextChanged);
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_CPF.Location = new System.Drawing.Point(12, 164);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(39, 20);
            this.label_CPF.TabIndex = 112;
            this.label_CPF.Text = "CPF:";
            // 
            // label_TipoUsuario
            // 
            this.label_TipoUsuario.AutoSize = true;
            this.label_TipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_TipoUsuario.Location = new System.Drawing.Point(12, 93);
            this.label_TipoUsuario.Name = "label_TipoUsuario";
            this.label_TipoUsuario.Size = new System.Drawing.Size(108, 20);
            this.label_TipoUsuario.TabIndex = 119;
            this.label_TipoUsuario.Text = "Tipo de Usuario:";
            // 
            // comboBox_TipoUsuario
            // 
            this.comboBox_TipoUsuario.FormattingEnabled = true;
            this.comboBox_TipoUsuario.Items.AddRange(new object[] {
            "Comum",
            "Administrador"});
            this.comboBox_TipoUsuario.Location = new System.Drawing.Point(126, 93);
            this.comboBox_TipoUsuario.Name = "comboBox_TipoUsuario";
            this.comboBox_TipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoUsuario.TabIndex = 1;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(494, 249);
            this.Controls.Add(this.comboBox_TipoUsuario);
            this.Controls.Add(this.label_TipoUsuario);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.textBox_RG);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.textBox_CPF);
            this.Controls.Add(this.label_CPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.TextBox textBox_RG;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_TipoUsuario;
        private System.Windows.Forms.ComboBox comboBox_TipoUsuario;
    }
}
namespace Locadora_Veiculos
{
    partial class Autenticacao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacao));
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Entrar = new System.Windows.Forms.ToolStripButton();
            this.picture_autenticacao = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_autenticacao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(211, 47);
            this.textBox_usuario.MaxLength = 15;
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(176, 31);
            this.textBox_usuario.TabIndex = 1;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(211, 94);
            this.textBox_senha.MaxLength = 15;
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(176, 31);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(134, 50);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(70, 23);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Usuário";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(147, 98);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(57, 23);
            this.label_senha.TabIndex = 0;
            this.label_senha.Text = "Senha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_sair,
            this.toolStripSeparator1,
            this.toolStripButton_Entrar});
            this.toolStrip1.Location = new System.Drawing.Point(267, 144);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(113, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_sair
            // 
            this.toolStripButton_sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sair.Image")));
            this.toolStripButton_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sair.Name = "toolStripButton_sair";
            this.toolStripButton_sair.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton_sair.Text = "Sair";
            this.toolStripButton_sair.Click += new System.EventHandler(this.toolStripButton_sair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Entrar
            // 
            this.toolStripButton_Entrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Entrar.Image")));
            this.toolStripButton_Entrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Entrar.Name = "toolStripButton_Entrar";
            this.toolStripButton_Entrar.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton_Entrar.Text = "Entrar";
            this.toolStripButton_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_Entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_Entrar.Click += new System.EventHandler(this.toolStripButton_entrar_Click);
            // 
            // picture_autenticacao
            // 
            this.picture_autenticacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_autenticacao.BackgroundImage")));
            this.picture_autenticacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_autenticacao.Location = new System.Drawing.Point(12, 21);
            this.picture_autenticacao.Name = "picture_autenticacao";
            this.picture_autenticacao.Size = new System.Drawing.Size(116, 134);
            this.picture_autenticacao.TabIndex = 7;
            this.picture_autenticacao.TabStop = false;
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 178);
            this.Controls.Add(this.picture_autenticacao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Autenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação Sistema";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Autenticacao_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_autenticacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Entrar;
        private System.Windows.Forms.PictureBox picture_autenticacao;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
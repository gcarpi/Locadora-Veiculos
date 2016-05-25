namespace Locadora_Veiculos
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.label_Direitos = new System.Windows.Forms.Label();
            this.pictureBox_Logotipo = new System.Windows.Forms.PictureBox();
            this.label_Versao = new System.Windows.Forms.Label();
            this.label_Sistema = new System.Windows.Forms.Label();
            this.label_Desenvolvimento = new System.Windows.Forms.Label();
            this.button_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Direitos
            // 
            this.label_Direitos.AutoSize = true;
            this.label_Direitos.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Direitos.Location = new System.Drawing.Point(25, 207);
            this.label_Direitos.Name = "label_Direitos";
            this.label_Direitos.Size = new System.Drawing.Size(236, 20);
            this.label_Direitos.TabIndex = 67;
            this.label_Direitos.Text = "©2016 - Todos os direitos reservados";
            // 
            // pictureBox_Logotipo
            // 
            this.pictureBox_Logotipo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logotipo.Image")));
            this.pictureBox_Logotipo.Location = new System.Drawing.Point(52, 1);
            this.pictureBox_Logotipo.Name = "pictureBox_Logotipo";
            this.pictureBox_Logotipo.Size = new System.Drawing.Size(176, 108);
            this.pictureBox_Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logotipo.TabIndex = 68;
            this.pictureBox_Logotipo.TabStop = false;
            // 
            // label_Versao
            // 
            this.label_Versao.AutoSize = true;
            this.label_Versao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Versao.Location = new System.Drawing.Point(25, 144);
            this.label_Versao.Name = "label_Versao";
            this.label_Versao.Size = new System.Drawing.Size(56, 20);
            this.label_Versao.TabIndex = 69;
            this.label_Versao.Text = "Versão:";
            // 
            // label_Sistema
            // 
            this.label_Sistema.AutoSize = true;
            this.label_Sistema.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Sistema.Location = new System.Drawing.Point(25, 112);
            this.label_Sistema.Name = "label_Sistema";
            this.label_Sistema.Size = new System.Drawing.Size(193, 20);
            this.label_Sistema.TabIndex = 70;
            this.label_Sistema.Text = "Sistema Locadora de Veículos";
            // 
            // label_Desenvolvimento
            // 
            this.label_Desenvolvimento.AutoSize = true;
            this.label_Desenvolvimento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Desenvolvimento.Location = new System.Drawing.Point(25, 178);
            this.label_Desenvolvimento.Name = "label_Desenvolvimento";
            this.label_Desenvolvimento.Size = new System.Drawing.Size(117, 20);
            this.label_Desenvolvimento.TabIndex = 71;
            this.label_Desenvolvimento.Text = "Desenvolvimento:";
            // 
            // button_Fechar
            // 
            this.button_Fechar.Location = new System.Drawing.Point(113, 230);
            this.button_Fechar.Name = "button_Fechar";
            this.button_Fechar.Size = new System.Drawing.Size(65, 23);
            this.button_Fechar.TabIndex = 72;
            this.button_Fechar.Text = "Fechar";
            this.button_Fechar.UseVisualStyleBackColor = true;
            this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Fechar);
            this.Controls.Add(this.label_Desenvolvimento);
            this.Controls.Add(this.label_Sistema);
            this.Controls.Add(this.label_Versao);
            this.Controls.Add(this.pictureBox_Logotipo);
            this.Controls.Add(this.label_Direitos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Direitos;
        private System.Windows.Forms.PictureBox pictureBox_Logotipo;
        private System.Windows.Forms.Label label_Versao;
        private System.Windows.Forms.Label label_Sistema;
        private System.Windows.Forms.Label label_Desenvolvimento;
        private System.Windows.Forms.Button button_Fechar;
    }
}
namespace Locadora_Veiculos
{
    partial class NovaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaCategoria));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
<<<<<<< HEAD
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Valor = new System.Windows.Forms.Label();
            this.maskedTextBox_Nome = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Valor = new System.Windows.Forms.MaskedTextBox();
=======
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Valor = new System.Windows.Forms.Label();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Salvar,
            this.toolStripSeparator2,
            this.toolStripButton_Sair,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(404, 73);
            this.toolStrip1.TabIndex = 95;
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
            // toolStripButton_Sair
            // 
            this.toolStripButton_Sair.AutoSize = false;
            this.toolStripButton_Sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sair.Image")));
            this.toolStripButton_Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sair.Name = "toolStripButton_Sair";
            this.toolStripButton_Sair.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Sair.Text = "Sair";
            this.toolStripButton_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sair.Click += new System.EventHandler(this.toolStripButton_Sair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
<<<<<<< HEAD
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome.Location = new System.Drawing.Point(26, 99);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(56, 23);
            this.label_Nome.TabIndex = 116;
            this.label_Nome.Text = "Nome";
=======
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(66, 93);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(311, 20);
            this.textBox_Nome.TabIndex = 115;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Nome.Location = new System.Drawing.Point(11, 93);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(49, 20);
            this.label_Nome.TabIndex = 116;
            this.label_Nome.Text = "Nome:";
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
<<<<<<< HEAD
            this.label_Valor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valor.Location = new System.Drawing.Point(26, 147);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(50, 23);
            this.label_Valor.TabIndex = 117;
            this.label_Valor.Text = "Valor";
            // 
            // maskedTextBox_Nome
            // 
            this.maskedTextBox_Nome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Nome.Location = new System.Drawing.Point(99, 96);
            this.maskedTextBox_Nome.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBox_Nome.Name = "maskedTextBox_Nome";
            this.maskedTextBox_Nome.Size = new System.Drawing.Size(262, 31);
            this.maskedTextBox_Nome.TabIndex = 1;
            // 
            // maskedTextBox_Valor
            // 
            this.maskedTextBox_Valor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Valor.Location = new System.Drawing.Point(99, 144);
            this.maskedTextBox_Valor.Mask = "000.00";
            this.maskedTextBox_Valor.Name = "maskedTextBox_Valor";
            this.maskedTextBox_Valor.Size = new System.Drawing.Size(79, 31);
            this.maskedTextBox_Valor.TabIndex = 119;
=======
            this.label_Valor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Valor.Location = new System.Drawing.Point(16, 125);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(44, 20);
            this.label_Valor.TabIndex = 117;
            this.label_Valor.Text = "Valor:";
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.Location = new System.Drawing.Point(66, 127);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(79, 20);
            this.textBox_Valor.TabIndex = 118;
            this.textBox_Valor.TextChanged += new System.EventHandler(this.textBox_Valor_TextChanged);
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            // 
            // NovaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(404, 199);
            this.Controls.Add(this.maskedTextBox_Valor);
            this.Controls.Add(this.maskedTextBox_Nome);
            this.Controls.Add(this.label_Valor);
=======
            this.ClientSize = new System.Drawing.Size(404, 172);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.textBox_Nome);
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Categoria";
<<<<<<< HEAD
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NovaCategoria_FormClosing);
=======
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
<<<<<<< HEAD
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Nome;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Valor;
=======
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.TextBox textBox_Valor;
>>>>>>> 1dc3da737ceddfc622961448dae04e4b2029aa29
    }
}
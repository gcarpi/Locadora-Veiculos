namespace Locadora_Veiculos
{
    partial class ExibirPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirPedido));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Contrato = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Entrega = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_NPedido = new System.Windows.Forms.Label();
            this.textBox_NPedido = new System.Windows.Forms.TextBox();
            this.label_DataAbertura = new System.Windows.Forms.Label();
            this.textBox_DataAbertura = new System.Windows.Forms.TextBox();
            this.textBox_Cliente = new System.Windows.Forms.TextBox();
            this.label_Valor = new System.Windows.Forms.Label();
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.dataGridView_Pedido = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Imprimir,
            this.toolStripSeparator1,
            this.toolStripButton_Contrato,
            this.toolStripSeparator3,
            this.toolStripButton_Entrega,
            this.toolStripSeparator8,
            this.toolStripButton_Sair,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Imprimir
            // 
            this.toolStripButton_Imprimir.AutoSize = false;
            this.toolStripButton_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Imprimir.Image")));
            this.toolStripButton_Imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Imprimir.Name = "toolStripButton_Imprimir";
            this.toolStripButton_Imprimir.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Imprimir.Text = "Imprimir";
            this.toolStripButton_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Imprimir.Click += new System.EventHandler(this.toolStripButton_Imprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Contrato
            // 
            this.toolStripButton_Contrato.AutoSize = false;
            this.toolStripButton_Contrato.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Contrato.Image")));
            this.toolStripButton_Contrato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Contrato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Contrato.Name = "toolStripButton_Contrato";
            this.toolStripButton_Contrato.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Contrato.Text = "Contrato";
            this.toolStripButton_Contrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Contrato.Click += new System.EventHandler(this.toolStripButton_Contrato_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Entrega
            // 
            this.toolStripButton_Entrega.AutoSize = false;
            this.toolStripButton_Entrega.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Entrega.Image")));
            this.toolStripButton_Entrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Entrega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Entrega.Name = "toolStripButton_Entrega";
            this.toolStripButton_Entrega.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Entrega.Text = "Entrega";
            this.toolStripButton_Entrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Entrega.Click += new System.EventHandler(this.toolStripButton_Entrega_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(3, 70);
            // 
            // toolStripButton_Sair
            // 
            this.toolStripButton_Sair.AutoSize = false;
            this.toolStripButton_Sair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sair.Image")));
            this.toolStripButton_Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sair.Name = "toolStripButton_Sair";
            this.toolStripButton_Sair.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Sair.Text = "&Sair";
            this.toolStripButton_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sair.Click += new System.EventHandler(this.toolStripButton_Sair_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.AutoSize = false;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(3, 70);
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Cliente.Location = new System.Drawing.Point(8, 99);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(54, 20);
            this.label_Cliente.TabIndex = 65;
            this.label_Cliente.Text = "Cliente:";
            // 
            // label_NPedido
            // 
            this.label_NPedido.AutoSize = true;
            this.label_NPedido.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_NPedido.Location = new System.Drawing.Point(8, 144);
            this.label_NPedido.Name = "label_NPedido";
            this.label_NPedido.Size = new System.Drawing.Size(75, 20);
            this.label_NPedido.TabIndex = 77;
            this.label_NPedido.Text = "Nº Pedido:";
            // 
            // textBox_NPedido
            // 
            this.textBox_NPedido.Location = new System.Drawing.Point(89, 144);
            this.textBox_NPedido.Name = "textBox_NPedido";
            this.textBox_NPedido.Size = new System.Drawing.Size(170, 20);
            this.textBox_NPedido.TabIndex = 78;
            // 
            // label_DataAbertura
            // 
            this.label_DataAbertura.AutoSize = true;
            this.label_DataAbertura.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_DataAbertura.Location = new System.Drawing.Point(284, 142);
            this.label_DataAbertura.Name = "label_DataAbertura";
            this.label_DataAbertura.Size = new System.Drawing.Size(93, 20);
            this.label_DataAbertura.TabIndex = 79;
            this.label_DataAbertura.Text = "Data Abertura:";
            // 
            // textBox_DataAbertura
            // 
            this.textBox_DataAbertura.Location = new System.Drawing.Point(383, 142);
            this.textBox_DataAbertura.Name = "textBox_DataAbertura";
            this.textBox_DataAbertura.Size = new System.Drawing.Size(116, 20);
            this.textBox_DataAbertura.TabIndex = 80;
            // 
            // textBox_Cliente
            // 
            this.textBox_Cliente.Location = new System.Drawing.Point(89, 101);
            this.textBox_Cliente.Name = "textBox_Cliente";
            this.textBox_Cliente.Size = new System.Drawing.Size(410, 20);
            this.textBox_Cliente.TabIndex = 81;
            // 
            // label_Valor
            // 
            this.label_Valor.AutoSize = true;
            this.label_Valor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Valor.Location = new System.Drawing.Point(549, 144);
            this.label_Valor.Name = "label_Valor";
            this.label_Valor.Size = new System.Drawing.Size(44, 20);
            this.label_Valor.TabIndex = 82;
            this.label_Valor.Text = "Valor:";
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.Location = new System.Drawing.Point(608, 144);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(100, 20);
            this.textBox_Valor.TabIndex = 83;
            // 
            // dataGridView_Pedido
            // 
            this.dataGridView_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedido.Location = new System.Drawing.Point(12, 184);
            this.dataGridView_Pedido.Name = "dataGridView_Pedido";
            this.dataGridView_Pedido.Size = new System.Drawing.Size(696, 287);
            this.dataGridView_Pedido.TabIndex = 84;
            // 
            // ExibirPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.dataGridView_Pedido);
            this.Controls.Add(this.textBox_Valor);
            this.Controls.Add(this.label_Valor);
            this.Controls.Add(this.textBox_Cliente);
            this.Controls.Add(this.textBox_DataAbertura);
            this.Controls.Add(this.label_DataAbertura);
            this.Controls.Add(this.textBox_NPedido);
            this.Controls.Add(this.label_NPedido);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExibirPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Entrega;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_NPedido;
        private System.Windows.Forms.TextBox textBox_NPedido;
        private System.Windows.Forms.Label label_DataAbertura;
        private System.Windows.Forms.TextBox textBox_DataAbertura;
        private System.Windows.Forms.ToolStripButton toolStripButton_Contrato;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox textBox_Cliente;
        private System.Windows.Forms.Label label_Valor;
        private System.Windows.Forms.TextBox textBox_Valor;
        private System.Windows.Forms.DataGridView dataGridView_Pedido;
    }
}
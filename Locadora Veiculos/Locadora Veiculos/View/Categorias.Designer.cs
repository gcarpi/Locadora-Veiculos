namespace Locadora_Veiculos
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Nova = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label_ValorBusca = new System.Windows.Forms.Label();
            this.textBox_ValorBusca = new System.Windows.Forms.TextBox();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.dataGridView_Categoria = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Nova,
            this.toolStripSeparator1,
            this.toolStripButton_Sair,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(720, 73);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Nova
            // 
            this.toolStripButton_Nova.AutoSize = false;
            this.toolStripButton_Nova.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Nova.Image")));
            this.toolStripButton_Nova.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Nova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Nova.Name = "toolStripButton_Nova";
            this.toolStripButton_Nova.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton_Nova.Text = "Nova";
            this.toolStripButton_Nova.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_Nova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Nova.Click += new System.EventHandler(this.toolStripButton_Nova_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(3, 70);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(3, 70);
            // 
            // label_ValorBusca
            // 
            this.label_ValorBusca.AutoSize = true;
            this.label_ValorBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorBusca.Location = new System.Drawing.Point(223, 112);
            this.label_ValorBusca.Name = "label_ValorBusca";
            this.label_ValorBusca.Size = new System.Drawing.Size(83, 15);
            this.label_ValorBusca.TabIndex = 14;
            this.label_ValorBusca.Text = "Valor de Busca";
            // 
            // textBox_ValorBusca
            // 
            this.textBox_ValorBusca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorBusca.Location = new System.Drawing.Point(125, 130);
            this.textBox_ValorBusca.Multiline = true;
            this.textBox_ValorBusca.Name = "textBox_ValorBusca";
            this.textBox_ValorBusca.Size = new System.Drawing.Size(360, 30);
            this.textBox_ValorBusca.TabIndex = 15;
            this.textBox_ValorBusca.Text = "Digite Nome,Valor.";
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.AutoSize = true;
            this.button_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("button_Pesquisar.Image")));
            this.button_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Pesquisar.Location = new System.Drawing.Point(491, 126);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(101, 34);
            this.button_Pesquisar.TabIndex = 16;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Categoria
            // 
            this.dataGridView_Categoria.AllowUserToAddRows = false;
            this.dataGridView_Categoria.AllowUserToDeleteRows = false;
            this.dataGridView_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Categoria.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Valor});
            this.dataGridView_Categoria.Location = new System.Drawing.Point(125, 189);
            this.dataGridView_Categoria.MultiSelect = false;
            this.dataGridView_Categoria.Name = "dataGridView_Categoria";
            this.dataGridView_Categoria.ReadOnly = true;
            this.dataGridView_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Categoria.Size = new System.Drawing.Size(467, 251);
            this.dataGridView_Categoria.TabIndex = 2;
            this.dataGridView_Categoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Categoria_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome da categoria";
            this.Nome.MaxInputLength = 50;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor R$";
            this.Valor.MaxInputLength = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.dataGridView_Categoria);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.textBox_ValorBusca);
            this.Controls.Add(this.label_ValorBusca);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Activated += new System.EventHandler(this.Categorias_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Nova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label_ValorBusca;
        private System.Windows.Forms.TextBox textBox_ValorBusca;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.DataGridView dataGridView_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}
namespace Locadora_Veiculos
{
    partial class CadastroVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Marca = new System.Windows.Forms.Label();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.label_Modelo = new System.Windows.Forms.Label();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.label_AnoFabricacao = new System.Windows.Forms.Label();
            this.numeric_AnoFabricacao = new System.Windows.Forms.NumericUpDown();
            this.label_Cor = new System.Windows.Forms.Label();
            this.textBox_Cor = new System.Windows.Forms.TextBox();
            this.label_Placa = new System.Windows.Forms.Label();
            this.textBox_Chassi = new System.Windows.Forms.TextBox();
            this.label_Chassi = new System.Windows.Forms.Label();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.label_RENAVAM = new System.Windows.Forms.Label();
            this.textBox_RENAVAM = new System.Windows.Forms.TextBox();
            this.label_DataLicenciamento = new System.Windows.Forms.Label();
            this.comboBox_MesLicenciamento = new System.Windows.Forms.ComboBox();
            this.numeric_AnoLicenciamento = new System.Windows.Forms.NumericUpDown();
            this.label_Categoria = new System.Windows.Forms.Label();
            this.comboBox_Categorias = new System.Windows.Forms.ComboBox();
            this.label_Fornecedor = new System.Windows.Forms.Label();
            this.comboBox_Fornecedores = new System.Windows.Forms.ComboBox();
            this.groupBox_Caracteristicas = new System.Windows.Forms.GroupBox();
            this.groupBox_Direcao = new System.Windows.Forms.GroupBox();
            this.checkBox_Hidraulica = new System.Windows.Forms.RadioButton();
            this.checkBox_Eletrica = new System.Windows.Forms.RadioButton();
            this.checkBox_Alarme = new System.Windows.Forms.CheckBox();
            this.checkBox_Trava = new System.Windows.Forms.CheckBox();
            this.checkBox_Vidro = new System.Windows.Forms.CheckBox();
            this.checkBox_ArCondicionado = new System.Windows.Forms.CheckBox();
            this.groupBox_Cambio = new System.Windows.Forms.GroupBox();
            this.checkBox_Manual = new System.Windows.Forms.RadioButton();
            this.checkBox_Automatico = new System.Windows.Forms.RadioButton();
            this.groupBox_Portas = new System.Windows.Forms.GroupBox();
            this.checkBox_4portas = new System.Windows.Forms.RadioButton();
            this.checkBox_2portas = new System.Windows.Forms.RadioButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Pesquisar = new System.Windows.Forms.ToolStripButton();
            this.label_Combustivel = new System.Windows.Forms.Label();
            this.comboBox_Combustivel = new System.Windows.Forms.ComboBox();
            this.label_Tanque = new System.Windows.Forms.Label();
            this.label_KM = new System.Windows.Forms.Label();
            this.comboBox_Tanque = new System.Windows.Forms.ComboBox();
            this.textBox_KM = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AnoFabricacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AnoLicenciamento)).BeginInit();
            this.groupBox_Caracteristicas.SuspendLayout();
            this.groupBox_Direcao.SuspendLayout();
            this.groupBox_Cambio.SuspendLayout();
            this.groupBox_Portas.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(784, 73);
            this.toolStrip1.TabIndex = 2;
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
            // label_Marca
            // 
            this.label_Marca.AutoSize = true;
            this.label_Marca.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Marca.Location = new System.Drawing.Point(53, 130);
            this.label_Marca.Name = "label_Marca";
            this.label_Marca.Size = new System.Drawing.Size(49, 20);
            this.label_Marca.TabIndex = 43;
            this.label_Marca.Text = "Marca:";
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(166, 130);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(225, 20);
            this.textBox_Marca.TabIndex = 3;
            // 
            // label_Modelo
            // 
            this.label_Modelo.AutoSize = true;
            this.label_Modelo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Modelo.Location = new System.Drawing.Point(53, 166);
            this.label_Modelo.Name = "label_Modelo";
            this.label_Modelo.Size = new System.Drawing.Size(59, 20);
            this.label_Modelo.TabIndex = 45;
            this.label_Modelo.Text = "Modelo:";
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(166, 166);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(225, 20);
            this.textBox_Modelo.TabIndex = 5;
            // 
            // label_AnoFabricacao
            // 
            this.label_AnoFabricacao.AutoSize = true;
            this.label_AnoFabricacao.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_AnoFabricacao.Location = new System.Drawing.Point(53, 237);
            this.label_AnoFabricacao.Name = "label_AnoFabricacao";
            this.label_AnoFabricacao.Size = new System.Drawing.Size(107, 20);
            this.label_AnoFabricacao.TabIndex = 47;
            this.label_AnoFabricacao.Text = "Ano Fabricação:";
            // 
            // numeric_AnoFabricacao
            // 
            this.numeric_AnoFabricacao.Location = new System.Drawing.Point(166, 237);
            this.numeric_AnoFabricacao.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numeric_AnoFabricacao.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numeric_AnoFabricacao.Name = "numeric_AnoFabricacao";
            this.numeric_AnoFabricacao.Size = new System.Drawing.Size(51, 20);
            this.numeric_AnoFabricacao.TabIndex = 10;
            this.numeric_AnoFabricacao.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label_Cor
            // 
            this.label_Cor.AutoSize = true;
            this.label_Cor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Cor.Location = new System.Drawing.Point(53, 199);
            this.label_Cor.Name = "label_Cor";
            this.label_Cor.Size = new System.Drawing.Size(34, 20);
            this.label_Cor.TabIndex = 49;
            this.label_Cor.Text = "Cor:";
            // 
            // textBox_Cor
            // 
            this.textBox_Cor.Location = new System.Drawing.Point(166, 201);
            this.textBox_Cor.Name = "textBox_Cor";
            this.textBox_Cor.Size = new System.Drawing.Size(225, 20);
            this.textBox_Cor.TabIndex = 7;
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Placa.Location = new System.Drawing.Point(448, 166);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(46, 20);
            this.label_Placa.TabIndex = 51;
            this.label_Placa.Text = "Placa:";
            // 
            // textBox_Chassi
            // 
            this.textBox_Chassi.Location = new System.Drawing.Point(523, 199);
            this.textBox_Chassi.Name = "textBox_Chassi";
            this.textBox_Chassi.Size = new System.Drawing.Size(189, 20);
            this.textBox_Chassi.TabIndex = 8;
            // 
            // label_Chassi
            // 
            this.label_Chassi.AutoSize = true;
            this.label_Chassi.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Chassi.Location = new System.Drawing.Point(448, 201);
            this.label_Chassi.Name = "label_Chassi";
            this.label_Chassi.Size = new System.Drawing.Size(53, 20);
            this.label_Chassi.TabIndex = 53;
            this.label_Chassi.Text = "Chassi:";
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.Location = new System.Drawing.Point(523, 166);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(189, 20);
            this.textBox_Placa.TabIndex = 6;
            // 
            // label_RENAVAM
            // 
            this.label_RENAVAM.AutoSize = true;
            this.label_RENAVAM.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_RENAVAM.Location = new System.Drawing.Point(448, 130);
            this.label_RENAVAM.Name = "label_RENAVAM";
            this.label_RENAVAM.Size = new System.Drawing.Size(69, 20);
            this.label_RENAVAM.TabIndex = 55;
            this.label_RENAVAM.Text = "Renavam:";
            // 
            // textBox_RENAVAM
            // 
            this.textBox_RENAVAM.Location = new System.Drawing.Point(523, 130);
            this.textBox_RENAVAM.Name = "textBox_RENAVAM";
            this.textBox_RENAVAM.Size = new System.Drawing.Size(189, 20);
            this.textBox_RENAVAM.TabIndex = 4;
            // 
            // label_DataLicenciamento
            // 
            this.label_DataLicenciamento.AutoSize = true;
            this.label_DataLicenciamento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_DataLicenciamento.Location = new System.Drawing.Point(448, 234);
            this.label_DataLicenciamento.Name = "label_DataLicenciamento";
            this.label_DataLicenciamento.Size = new System.Drawing.Size(129, 20);
            this.label_DataLicenciamento.TabIndex = 57;
            this.label_DataLicenciamento.Text = "Data Licenciamento:";
            // 
            // comboBox_MesLicenciamento
            // 
            this.comboBox_MesLicenciamento.FormattingEnabled = true;
            this.comboBox_MesLicenciamento.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox_MesLicenciamento.Location = new System.Drawing.Point(583, 233);
            this.comboBox_MesLicenciamento.Name = "comboBox_MesLicenciamento";
            this.comboBox_MesLicenciamento.Size = new System.Drawing.Size(67, 21);
            this.comboBox_MesLicenciamento.TabIndex = 12;
            // 
            // numeric_AnoLicenciamento
            // 
            this.numeric_AnoLicenciamento.Location = new System.Drawing.Point(656, 233);
            this.numeric_AnoLicenciamento.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numeric_AnoLicenciamento.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numeric_AnoLicenciamento.Name = "numeric_AnoLicenciamento";
            this.numeric_AnoLicenciamento.Size = new System.Drawing.Size(56, 20);
            this.numeric_AnoLicenciamento.TabIndex = 13;
            this.numeric_AnoLicenciamento.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Categoria.Location = new System.Drawing.Point(448, 93);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(70, 20);
            this.label_Categoria.TabIndex = 60;
            this.label_Categoria.Text = "Categoria:";
            // 
            // comboBox_Categorias
            // 
            this.comboBox_Categorias.FormattingEnabled = true;
            this.comboBox_Categorias.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_Categorias.Location = new System.Drawing.Point(524, 94);
            this.comboBox_Categorias.Name = "comboBox_Categorias";
            this.comboBox_Categorias.Size = new System.Drawing.Size(64, 21);
            this.comboBox_Categorias.TabIndex = 2;
            // 
            // label_Fornecedor
            // 
            this.label_Fornecedor.AutoSize = true;
            this.label_Fornecedor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Fornecedor.Location = new System.Drawing.Point(53, 96);
            this.label_Fornecedor.Name = "label_Fornecedor";
            this.label_Fornecedor.Size = new System.Drawing.Size(83, 20);
            this.label_Fornecedor.TabIndex = 62;
            this.label_Fornecedor.Text = "Fornecedor:";
            // 
            // comboBox_Fornecedores
            // 
            this.comboBox_Fornecedores.FormattingEnabled = true;
            this.comboBox_Fornecedores.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_Fornecedores.Location = new System.Drawing.Point(166, 96);
            this.comboBox_Fornecedores.Name = "comboBox_Fornecedores";
            this.comboBox_Fornecedores.Size = new System.Drawing.Size(225, 21);
            this.comboBox_Fornecedores.TabIndex = 1;
            // 
            // groupBox_Caracteristicas
            // 
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Direcao);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_Alarme);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_Trava);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_Vidro);
            this.groupBox_Caracteristicas.Controls.Add(this.checkBox_ArCondicionado);
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Cambio);
            this.groupBox_Caracteristicas.Controls.Add(this.groupBox_Portas);
            this.groupBox_Caracteristicas.Location = new System.Drawing.Point(57, 323);
            this.groupBox_Caracteristicas.Name = "groupBox_Caracteristicas";
            this.groupBox_Caracteristicas.Size = new System.Drawing.Size(632, 157);
            this.groupBox_Caracteristicas.TabIndex = 64;
            this.groupBox_Caracteristicas.TabStop = false;
            this.groupBox_Caracteristicas.Text = "Características";
            // 
            // groupBox_Direcao
            // 
            this.groupBox_Direcao.Controls.Add(this.checkBox_Hidraulica);
            this.groupBox_Direcao.Controls.Add(this.checkBox_Eletrica);
            this.groupBox_Direcao.Location = new System.Drawing.Point(17, 93);
            this.groupBox_Direcao.Name = "groupBox_Direcao";
            this.groupBox_Direcao.Size = new System.Drawing.Size(183, 49);
            this.groupBox_Direcao.TabIndex = 2;
            this.groupBox_Direcao.TabStop = false;
            this.groupBox_Direcao.Text = "Direção";
            // 
            // checkBox_Hidraulica
            // 
            this.checkBox_Hidraulica.AutoSize = true;
            this.checkBox_Hidraulica.Location = new System.Drawing.Point(105, 19);
            this.checkBox_Hidraulica.Name = "checkBox_Hidraulica";
            this.checkBox_Hidraulica.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Hidraulica.TabIndex = 21;
            this.checkBox_Hidraulica.TabStop = true;
            this.checkBox_Hidraulica.Text = "Hidráulica";
            this.checkBox_Hidraulica.UseVisualStyleBackColor = true;
            // 
            // checkBox_Eletrica
            // 
            this.checkBox_Eletrica.AutoSize = true;
            this.checkBox_Eletrica.Location = new System.Drawing.Point(19, 19);
            this.checkBox_Eletrica.Name = "checkBox_Eletrica";
            this.checkBox_Eletrica.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Eletrica.TabIndex = 20;
            this.checkBox_Eletrica.TabStop = true;
            this.checkBox_Eletrica.Text = "Elétrica";
            this.checkBox_Eletrica.UseVisualStyleBackColor = true;
            // 
            // checkBox_Alarme
            // 
            this.checkBox_Alarme.AutoSize = true;
            this.checkBox_Alarme.Location = new System.Drawing.Point(17, 42);
            this.checkBox_Alarme.Name = "checkBox_Alarme";
            this.checkBox_Alarme.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Alarme.TabIndex = 17;
            this.checkBox_Alarme.Text = "Alarme";
            this.checkBox_Alarme.UseVisualStyleBackColor = true;
            // 
            // checkBox_Trava
            // 
            this.checkBox_Trava.AutoSize = true;
            this.checkBox_Trava.Location = new System.Drawing.Point(246, 42);
            this.checkBox_Trava.Name = "checkBox_Trava";
            this.checkBox_Trava.Size = new System.Drawing.Size(92, 17);
            this.checkBox_Trava.TabIndex = 19;
            this.checkBox_Trava.Text = "Trava Elétrica";
            this.checkBox_Trava.UseVisualStyleBackColor = true;
            // 
            // checkBox_Vidro
            // 
            this.checkBox_Vidro.AutoSize = true;
            this.checkBox_Vidro.Location = new System.Drawing.Point(371, 42);
            this.checkBox_Vidro.Name = "checkBox_Vidro";
            this.checkBox_Vidro.Size = new System.Drawing.Size(88, 17);
            this.checkBox_Vidro.TabIndex = 19;
            this.checkBox_Vidro.Text = "Vidro Elétrico";
            this.checkBox_Vidro.UseVisualStyleBackColor = true;
            // 
            // checkBox_ArCondicionado
            // 
            this.checkBox_ArCondicionado.AutoSize = true;
            this.checkBox_ArCondicionado.Location = new System.Drawing.Point(108, 42);
            this.checkBox_ArCondicionado.Name = "checkBox_ArCondicionado";
            this.checkBox_ArCondicionado.Size = new System.Drawing.Size(104, 17);
            this.checkBox_ArCondicionado.TabIndex = 18;
            this.checkBox_ArCondicionado.Text = "Ar Condicionado";
            this.checkBox_ArCondicionado.UseVisualStyleBackColor = true;
            // 
            // groupBox_Cambio
            // 
            this.groupBox_Cambio.Controls.Add(this.checkBox_Manual);
            this.groupBox_Cambio.Controls.Add(this.checkBox_Automatico);
            this.groupBox_Cambio.Location = new System.Drawing.Point(225, 93);
            this.groupBox_Cambio.Name = "groupBox_Cambio";
            this.groupBox_Cambio.Size = new System.Drawing.Size(183, 49);
            this.groupBox_Cambio.TabIndex = 1;
            this.groupBox_Cambio.TabStop = false;
            this.groupBox_Cambio.Text = "Câmbio";
            // 
            // checkBox_Manual
            // 
            this.checkBox_Manual.AutoSize = true;
            this.checkBox_Manual.Location = new System.Drawing.Point(105, 19);
            this.checkBox_Manual.Name = "checkBox_Manual";
            this.checkBox_Manual.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Manual.TabIndex = 23;
            this.checkBox_Manual.TabStop = true;
            this.checkBox_Manual.Text = "Manual";
            this.checkBox_Manual.UseVisualStyleBackColor = true;
            // 
            // checkBox_Automatico
            // 
            this.checkBox_Automatico.AutoSize = true;
            this.checkBox_Automatico.Location = new System.Drawing.Point(19, 19);
            this.checkBox_Automatico.Name = "checkBox_Automatico";
            this.checkBox_Automatico.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Automatico.TabIndex = 22;
            this.checkBox_Automatico.TabStop = true;
            this.checkBox_Automatico.Text = "Automático";
            this.checkBox_Automatico.UseVisualStyleBackColor = true;
            // 
            // groupBox_Portas
            // 
            this.groupBox_Portas.Controls.Add(this.checkBox_4portas);
            this.groupBox_Portas.Controls.Add(this.checkBox_2portas);
            this.groupBox_Portas.Location = new System.Drawing.Point(433, 93);
            this.groupBox_Portas.Name = "groupBox_Portas";
            this.groupBox_Portas.Size = new System.Drawing.Size(183, 52);
            this.groupBox_Portas.TabIndex = 0;
            this.groupBox_Portas.TabStop = false;
            this.groupBox_Portas.Text = "Portas";
            // 
            // checkBox_4portas
            // 
            this.checkBox_4portas.AutoSize = true;
            this.checkBox_4portas.Location = new System.Drawing.Point(95, 20);
            this.checkBox_4portas.Name = "checkBox_4portas";
            this.checkBox_4portas.Size = new System.Drawing.Size(64, 17);
            this.checkBox_4portas.TabIndex = 25;
            this.checkBox_4portas.TabStop = true;
            this.checkBox_4portas.Text = "4 Portas";
            this.checkBox_4portas.UseVisualStyleBackColor = true;
            // 
            // checkBox_2portas
            // 
            this.checkBox_2portas.AutoSize = true;
            this.checkBox_2portas.Location = new System.Drawing.Point(25, 20);
            this.checkBox_2portas.Name = "checkBox_2portas";
            this.checkBox_2portas.Size = new System.Drawing.Size(64, 17);
            this.checkBox_2portas.TabIndex = 24;
            this.checkBox_2portas.TabStop = true;
            this.checkBox_2portas.Text = "2 Portas";
            this.checkBox_2portas.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Pesquisar});
            this.toolStrip3.Location = new System.Drawing.Point(394, 94);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(26, 25);
            this.toolStrip3.TabIndex = 74;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton_Pesquisar
            // 
            this.toolStripButton_Pesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Pesquisar.Image")));
            this.toolStripButton_Pesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Pesquisar.Name = "toolStripButton_Pesquisar";
            this.toolStripButton_Pesquisar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Pesquisar.Text = "toolStripButton1";
            this.toolStripButton_Pesquisar.Click += new System.EventHandler(this.toolStripButton_Pesquisar_Click);
            // 
            // label_Combustivel
            // 
            this.label_Combustivel.AutoSize = true;
            this.label_Combustivel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Combustivel.Location = new System.Drawing.Point(53, 268);
            this.label_Combustivel.Name = "label_Combustivel";
            this.label_Combustivel.Size = new System.Drawing.Size(87, 20);
            this.label_Combustivel.TabIndex = 95;
            this.label_Combustivel.Text = "Combustível:";
            // 
            // comboBox_Combustivel
            // 
            this.comboBox_Combustivel.FormattingEnabled = true;
            this.comboBox_Combustivel.Items.AddRange(new object[] {
            "Flex",
            "Álcool",
            "Gasolina",
            "Diesel",
            "GNV"});
            this.comboBox_Combustivel.Location = new System.Drawing.Point(166, 270);
            this.comboBox_Combustivel.Name = "comboBox_Combustivel";
            this.comboBox_Combustivel.Size = new System.Drawing.Size(225, 21);
            this.comboBox_Combustivel.TabIndex = 15;
            // 
            // label_Tanque
            // 
            this.label_Tanque.AutoSize = true;
            this.label_Tanque.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_Tanque.Location = new System.Drawing.Point(451, 268);
            this.label_Tanque.Name = "label_Tanque";
            this.label_Tanque.Size = new System.Drawing.Size(117, 20);
            this.label_Tanque.TabIndex = 97;
            this.label_Tanque.Text = "Marcador Tanque:";
            // 
            // label_KM
            // 
            this.label_KM.AutoSize = true;
            this.label_KM.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label_KM.Location = new System.Drawing.Point(236, 237);
            this.label_KM.Name = "label_KM";
            this.label_KM.Size = new System.Drawing.Size(33, 20);
            this.label_KM.TabIndex = 98;
            this.label_KM.Text = "KM:";
            this.label_KM.Click += new System.EventHandler(this.label_KM_Click);
            // 
            // comboBox_Tanque
            // 
            this.comboBox_Tanque.FormattingEnabled = true;
            this.comboBox_Tanque.Items.AddRange(new object[] {
            "Reserva",
            "1/4",
            "2/4",
            "3/4",
            "1/1"});
            this.comboBox_Tanque.Location = new System.Drawing.Point(583, 267);
            this.comboBox_Tanque.Name = "comboBox_Tanque";
            this.comboBox_Tanque.Size = new System.Drawing.Size(66, 21);
            this.comboBox_Tanque.TabIndex = 16;
            this.comboBox_Tanque.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tanque_SelectedIndexChanged);
            // 
            // textBox_KM
            // 
            this.textBox_KM.Location = new System.Drawing.Point(295, 237);
            this.textBox_KM.Name = "textBox_KM";
            this.textBox_KM.Size = new System.Drawing.Size(96, 20);
            this.textBox_KM.TabIndex = 11;
            this.textBox_KM.TextChanged += new System.EventHandler(this.textBox_KM_TextChanged);
            // 
            // CadastroVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.textBox_KM);
            this.Controls.Add(this.comboBox_Tanque);
            this.Controls.Add(this.label_KM);
            this.Controls.Add(this.label_Tanque);
            this.Controls.Add(this.comboBox_Combustivel);
            this.Controls.Add(this.label_Combustivel);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.groupBox_Caracteristicas);
            this.Controls.Add(this.comboBox_Fornecedores);
            this.Controls.Add(this.label_Fornecedor);
            this.Controls.Add(this.comboBox_Categorias);
            this.Controls.Add(this.label_Categoria);
            this.Controls.Add(this.numeric_AnoLicenciamento);
            this.Controls.Add(this.comboBox_MesLicenciamento);
            this.Controls.Add(this.label_DataLicenciamento);
            this.Controls.Add(this.textBox_RENAVAM);
            this.Controls.Add(this.label_RENAVAM);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.label_Chassi);
            this.Controls.Add(this.textBox_Chassi);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.textBox_Cor);
            this.Controls.Add(this.label_Cor);
            this.Controls.Add(this.numeric_AnoFabricacao);
            this.Controls.Add(this.label_AnoFabricacao);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.label_Modelo);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.label_Marca);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AnoFabricacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_AnoLicenciamento)).EndInit();
            this.groupBox_Caracteristicas.ResumeLayout(false);
            this.groupBox_Caracteristicas.PerformLayout();
            this.groupBox_Direcao.ResumeLayout(false);
            this.groupBox_Direcao.PerformLayout();
            this.groupBox_Cambio.ResumeLayout(false);
            this.groupBox_Cambio.PerformLayout();
            this.groupBox_Portas.ResumeLayout(false);
            this.groupBox_Portas.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label_Marca;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.Label label_Modelo;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.Label label_AnoFabricacao;
        private System.Windows.Forms.NumericUpDown numeric_AnoFabricacao;
        private System.Windows.Forms.Label label_Cor;
        private System.Windows.Forms.TextBox textBox_Cor;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.TextBox textBox_Chassi;
        private System.Windows.Forms.Label label_Chassi;
        private System.Windows.Forms.TextBox textBox_Placa;
        private System.Windows.Forms.Label label_RENAVAM;
        private System.Windows.Forms.TextBox textBox_RENAVAM;
        private System.Windows.Forms.Label label_DataLicenciamento;
        private System.Windows.Forms.ComboBox comboBox_MesLicenciamento;
        private System.Windows.Forms.NumericUpDown numeric_AnoLicenciamento;
        private System.Windows.Forms.Label label_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Categorias;
        private System.Windows.Forms.Label label_Fornecedor;
        private System.Windows.Forms.ComboBox comboBox_Fornecedores;
        private System.Windows.Forms.GroupBox groupBox_Caracteristicas;
        private System.Windows.Forms.GroupBox groupBox_Direcao;
        private System.Windows.Forms.RadioButton checkBox_Hidraulica;
        private System.Windows.Forms.RadioButton checkBox_Eletrica;
        private System.Windows.Forms.CheckBox checkBox_Alarme;
        private System.Windows.Forms.CheckBox checkBox_Trava;
        private System.Windows.Forms.CheckBox checkBox_Vidro;
        private System.Windows.Forms.CheckBox checkBox_ArCondicionado;
        private System.Windows.Forms.GroupBox groupBox_Cambio;
        private System.Windows.Forms.RadioButton checkBox_Manual;
        private System.Windows.Forms.RadioButton checkBox_Automatico;
        private System.Windows.Forms.GroupBox groupBox_Portas;
        private System.Windows.Forms.RadioButton checkBox_4portas;
        private System.Windows.Forms.RadioButton checkBox_2portas;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Pesquisar;
        private System.Windows.Forms.Label label_Combustivel;
        private System.Windows.Forms.ComboBox comboBox_Combustivel;
        private System.Windows.Forms.Label label_Tanque;
        private System.Windows.Forms.Label label_KM;
        private System.Windows.Forms.ComboBox comboBox_Tanque;
        private System.Windows.Forms.TextBox textBox_KM;
    }
}
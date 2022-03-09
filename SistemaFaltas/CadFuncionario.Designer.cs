
namespace SistemaFaltas
{
    partial class CadFuncionario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnEditarMatricula = new System.Windows.Forms.Button();
            this.btnExcluirMatricula = new System.Windows.Forms.Button();
            this.txtHTPI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHTPC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCargaSuplementar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddMatricula = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNovaFoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbCadastroDeMatricula = new System.Windows.Forms.GroupBox();
            this.gbStatusMatricula = new System.Windows.Forms.GroupBox();
            this.rbMatriculaInativa = new System.Windows.Forms.RadioButton();
            this.rbMatriculaAtiva = new System.Windows.Forms.RadioButton();
            this.dgvListaMatriculas = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbCadastroDeMatricula.SuspendLayout();
            this.gbStatusMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(325, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(481, 29);
            this.txtNome.TabIndex = 0;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(325, 97);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(148, 29);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(275, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "C.P.F.";
            // 
            // boxCargo
            // 
            this.boxCargo.FormattingEnabled = true;
            this.boxCargo.Location = new System.Drawing.Point(75, 49);
            this.boxCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxCargo.Name = "boxCargo";
            this.boxCargo.Size = new System.Drawing.Size(323, 29);
            this.boxCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número da Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(171, 12);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(227, 29);
            this.txtMatricula.TabIndex = 3;
            // 
            // btnEditarMatricula
            // 
            this.btnEditarMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btnEditarMatricula.FlatAppearance.BorderSize = 0;
            this.btnEditarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarMatricula.Location = new System.Drawing.Point(344, 511);
            this.btnEditarMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarMatricula.Name = "btnEditarMatricula";
            this.btnEditarMatricula.Size = new System.Drawing.Size(150, 45);
            this.btnEditarMatricula.TabIndex = 28;
            this.btnEditarMatricula.Text = "Editar";
            this.btnEditarMatricula.UseVisualStyleBackColor = false;
            this.btnEditarMatricula.Click += new System.EventHandler(this.btnEditarMatricula_Click);
            // 
            // btnExcluirMatricula
            // 
            this.btnExcluirMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btnExcluirMatricula.FlatAppearance.BorderSize = 0;
            this.btnExcluirMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirMatricula.Location = new System.Drawing.Point(669, 511);
            this.btnExcluirMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluirMatricula.Name = "btnExcluirMatricula";
            this.btnExcluirMatricula.Size = new System.Drawing.Size(150, 45);
            this.btnExcluirMatricula.TabIndex = 27;
            this.btnExcluirMatricula.Text = "Excluir";
            this.btnExcluirMatricula.UseVisualStyleBackColor = false;
            this.btnExcluirMatricula.Click += new System.EventHandler(this.btnExcluirMatricula_Click);
            // 
            // txtHTPI
            // 
            this.txtHTPI.Location = new System.Drawing.Point(331, 180);
            this.txtHTPI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHTPI.Name = "txtHTPI";
            this.txtHTPI.Size = new System.Drawing.Size(67, 29);
            this.txtHTPI.TabIndex = 12;
            this.txtHTPI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomenteNumeros_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 183);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "HTPI";
            // 
            // txtHTPC
            // 
            this.txtHTPC.Location = new System.Drawing.Point(116, 180);
            this.txtHTPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHTPC.Name = "txtHTPC";
            this.txtHTPC.Size = new System.Drawing.Size(67, 29);
            this.txtHTPC.TabIndex = 11;
            this.txtHTPC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomenteNumeros_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "HTPC";
            // 
            // txtCargaSuplementar
            // 
            this.txtCargaSuplementar.Location = new System.Drawing.Point(331, 138);
            this.txtCargaSuplementar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargaSuplementar.Name = "txtCargaSuplementar";
            this.txtCargaSuplementar.Size = new System.Drawing.Size(67, 29);
            this.txtCargaSuplementar.TabIndex = 10;
            this.txtCargaSuplementar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomenteNumeros_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Carga Suplementar";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(116, 138);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(67, 29);
            this.txtCargaHoraria.TabIndex = 9;
            this.txtCargaHoraria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SomenteNumeros_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Carga horária";
            // 
            // btnAddMatricula
            // 
            this.btnAddMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btnAddMatricula.FlatAppearance.BorderSize = 0;
            this.btnAddMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMatricula.Location = new System.Drawing.Point(14, 511);
            this.btnAddMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddMatricula.Name = "btnAddMatricula";
            this.btnAddMatricula.Size = new System.Drawing.Size(150, 45);
            this.btnAddMatricula.TabIndex = 19;
            this.btnAddMatricula.Text = "Adicionar";
            this.btnAddMatricula.UseVisualStyleBackColor = false;
            this.btnAddMatricula.Click += new System.EventHandler(this.btnAddMatricula_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fim";
            // 
            // dateFim
            // 
            this.dateFim.Checked = false;
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(263, 97);
            this.dateFim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(135, 29);
            this.dateFim.TabIndex = 8;
            this.dateFim.ValueChanged += new System.EventHandler(this.AlteraFormato_dataFim);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Inicio";
            // 
            // dataInicio
            // 
            this.dataInicio.Checked = false;
            this.dataInicio.CustomFormat = "";
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(75, 97);
            this.dataInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(136, 29);
            this.dataInicio.TabIndex = 7;
            this.dataInicio.ValueChanged += new System.EventHandler(this.AlteraFormato_dataInicio);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Image = global::SistemaFaltas.Properties.Resources.voltar_50;
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 75);
            this.btVoltar.TabIndex = 11;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalvar.Location = new System.Drawing.Point(670, 511);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(150, 45);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 599);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            this.tabPage1.Controls.Add(this.btnNovaFoto);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btSalvar);
            this.tabPage1.Controls.Add(this.pbFuncionario);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(828, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Principais";
            // 
            // btnNovaFoto
            // 
            this.btnNovaFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(148)))));
            this.btnNovaFoto.FlatAppearance.BorderSize = 0;
            this.btnNovaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaFoto.Location = new System.Drawing.Point(50, 267);
            this.btnNovaFoto.Name = "btnNovaFoto";
            this.btnNovaFoto.Size = new System.Drawing.Size(198, 43);
            this.btnNovaFoto.TabIndex = 6;
            this.btnNovaFoto.Text = "Nova Foto";
            this.btnNovaFoto.UseVisualStyleBackColor = false;
            this.btnNovaFoto.Click += new System.EventHandler(this.btnNovaFoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(506, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Funcionário";
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(98, 26);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(84, 25);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            this.rbInativo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSeleciona_MouseClick);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(13, 26);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(71, 25);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.BackColor = System.Drawing.Color.LightGray;
            this.pbFuncionario.Location = new System.Drawing.Point(34, 31);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(230, 230);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 4;
            this.pbFuncionario.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            this.tabPage2.Controls.Add(this.gbCadastroDeMatricula);
            this.tabPage2.Controls.Add(this.dgvListaMatriculas);
            this.tabPage2.Controls.Add(this.btnEditarMatricula);
            this.tabPage2.Controls.Add(this.btnExcluirMatricula);
            this.tabPage2.Controls.Add(this.btnAddMatricula);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(828, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matrículas";
            // 
            // gbCadastroDeMatricula
            // 
            this.gbCadastroDeMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCadastroDeMatricula.Controls.Add(this.gbStatusMatricula);
            this.gbCadastroDeMatricula.Controls.Add(this.label5);
            this.gbCadastroDeMatricula.Controls.Add(this.label8);
            this.gbCadastroDeMatricula.Controls.Add(this.dateFim);
            this.gbCadastroDeMatricula.Controls.Add(this.boxCargo);
            this.gbCadastroDeMatricula.Controls.Add(this.label7);
            this.gbCadastroDeMatricula.Controls.Add(this.label10);
            this.gbCadastroDeMatricula.Controls.Add(this.txtHTPI);
            this.gbCadastroDeMatricula.Controls.Add(this.txtCargaHoraria);
            this.gbCadastroDeMatricula.Controls.Add(this.label13);
            this.gbCadastroDeMatricula.Controls.Add(this.label11);
            this.gbCadastroDeMatricula.Controls.Add(this.label3);
            this.gbCadastroDeMatricula.Controls.Add(this.dataInicio);
            this.gbCadastroDeMatricula.Controls.Add(this.txtHTPC);
            this.gbCadastroDeMatricula.Controls.Add(this.txtCargaSuplementar);
            this.gbCadastroDeMatricula.Controls.Add(this.txtMatricula);
            this.gbCadastroDeMatricula.Controls.Add(this.label12);
            this.gbCadastroDeMatricula.Location = new System.Drawing.Point(7, 269);
            this.gbCadastroDeMatricula.Name = "gbCadastroDeMatricula";
            this.gbCadastroDeMatricula.Size = new System.Drawing.Size(814, 220);
            this.gbCadastroDeMatricula.TabIndex = 30;
            this.gbCadastroDeMatricula.TabStop = false;
            // 
            // gbStatusMatricula
            // 
            this.gbStatusMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            this.gbStatusMatricula.Controls.Add(this.rbMatriculaInativa);
            this.gbStatusMatricula.Controls.Add(this.rbMatriculaAtiva);
            this.gbStatusMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbStatusMatricula.Location = new System.Drawing.Point(537, 12);
            this.gbStatusMatricula.Name = "gbStatusMatricula";
            this.gbStatusMatricula.Size = new System.Drawing.Size(198, 61);
            this.gbStatusMatricula.TabIndex = 27;
            this.gbStatusMatricula.TabStop = false;
            this.gbStatusMatricula.Text = "Status da Matricula";
            // 
            // rbMatriculaInativa
            // 
            this.rbMatriculaInativa.AutoSize = true;
            this.rbMatriculaInativa.Location = new System.Drawing.Point(98, 26);
            this.rbMatriculaInativa.Name = "rbMatriculaInativa";
            this.rbMatriculaInativa.Size = new System.Drawing.Size(84, 25);
            this.rbMatriculaInativa.TabIndex = 1;
            this.rbMatriculaInativa.TabStop = true;
            this.rbMatriculaInativa.Text = "Inativo";
            this.rbMatriculaInativa.UseVisualStyleBackColor = true;
            // 
            // rbMatriculaAtiva
            // 
            this.rbMatriculaAtiva.AutoSize = true;
            this.rbMatriculaAtiva.Location = new System.Drawing.Point(13, 26);
            this.rbMatriculaAtiva.Name = "rbMatriculaAtiva";
            this.rbMatriculaAtiva.Size = new System.Drawing.Size(71, 25);
            this.rbMatriculaAtiva.TabIndex = 0;
            this.rbMatriculaAtiva.TabStop = true;
            this.rbMatriculaAtiva.Text = "Ativo";
            this.rbMatriculaAtiva.UseVisualStyleBackColor = true;
            // 
            // dgvListaMatriculas
            // 
            this.dgvListaMatriculas.AllowUserToAddRows = false;
            this.dgvListaMatriculas.AllowUserToDeleteRows = false;
            this.dgvListaMatriculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMatriculas.Location = new System.Drawing.Point(9, 6);
            this.dgvListaMatriculas.MultiSelect = false;
            this.dgvListaMatriculas.Name = "dgvListaMatriculas";
            this.dgvListaMatriculas.ReadOnly = true;
            this.dgvListaMatriculas.RowTemplate.Height = 25;
            this.dgvListaMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMatriculas.Size = new System.Drawing.Size(812, 246);
            this.dgvListaMatriculas.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(131, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(363, 36);
            this.label14.TabIndex = 16;
            this.label14.Text = "Cadastro de Funcionário";
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(859, 717);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadFuncionario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadFuncionario_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbCadastroDeMatricula.ResumeLayout(false);
            this.gbCadastroDeMatricula.PerformLayout();
            this.gbStatusMatricula.ResumeLayout(false);
            this.gbStatusMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.Button btnAddMatricula;
        private System.Windows.Forms.Button btnExcluirMatricula;
        private System.Windows.Forms.TextBox txtHTPI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHTPC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCargaSuplementar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditarMatricula;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvListaMatriculas;
        private System.Windows.Forms.Button btnNovaFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbCadastroDeMatricula;
        private System.Windows.Forms.GroupBox gbStatusMatricula;
        private System.Windows.Forms.RadioButton rbMatriculaInativa;
        private System.Windows.Forms.RadioButton rbMatriculaAtiva;
    }
}
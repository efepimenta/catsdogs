namespace CatsAndDogs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServico = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIniciarServico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnAnimais = new System.Windows.Forms.ToolStripButton();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.btnServicos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnServicoManutencao = new System.Windows.Forms.ToolStripButton();
            this.btnIniciarServico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHistorico = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabClienteNovo = new System.Windows.Forms.TabPage();
            this.tabClienteDados = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabAnimal = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabAnimalNovo = new System.Windows.Forms.TabPage();
            this.tabAnimalDados = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabFuncionarioNovo = new System.Windows.Forms.TabPage();
            this.tabFuncionarioDados = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabServico = new System.Windows.Forms.TabPage();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.tabServicoManutencao = new System.Windows.Forms.TabPage();
            this.tabHistorico = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAnimal.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.mnuAnimais,
            this.mnuFuncionario,
            this.mnuServico});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuClientes.Image")));
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(152, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // mnuAnimais
            // 
            this.mnuAnimais.Image = ((System.Drawing.Image)(resources.GetObject("mnuAnimais.Image")));
            this.mnuAnimais.Name = "mnuAnimais";
            this.mnuAnimais.Size = new System.Drawing.Size(152, 22);
            this.mnuAnimais.Text = "Animais";
            this.mnuAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // mnuFuncionario
            // 
            this.mnuFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("mnuFuncionario.Image")));
            this.mnuFuncionario.Name = "mnuFuncionario";
            this.mnuFuncionario.Size = new System.Drawing.Size(152, 22);
            this.mnuFuncionario.Text = "Funcionários";
            this.mnuFuncionario.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // mnuServico
            // 
            this.mnuServico.Image = ((System.Drawing.Image)(resources.GetObject("mnuServico.Image")));
            this.mnuServico.Name = "mnuServico";
            this.mnuServico.Size = new System.Drawing.Size(152, 22);
            this.mnuServico.Text = "Serviços";
            this.mnuServico.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgenda});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // mnuAgenda
            // 
            this.mnuAgenda.Image = ((System.Drawing.Image)(resources.GetObject("mnuAgenda.Image")));
            this.mnuAgenda.Name = "mnuAgenda";
            this.mnuAgenda.Size = new System.Drawing.Size(182, 22);
            this.mnuAgenda.Text = "Novo Agendamento";
            this.mnuAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroServicos,
            this.mnuIniciarServico,
            this.mnuHistorico});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.relatóriosToolStripMenuItem.Text = "Serviços";
            // 
            // mnuCadastroServicos
            // 
            this.mnuCadastroServicos.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadastroServicos.Image")));
            this.mnuCadastroServicos.Name = "mnuCadastroServicos";
            this.mnuCadastroServicos.Size = new System.Drawing.Size(203, 22);
            this.mnuCadastroServicos.Text = "Manutenção de Serviços";
            this.mnuCadastroServicos.Click += new System.EventHandler(this.btnServicoManutencao_Click);
            // 
            // mnuIniciarServico
            // 
            this.mnuIniciarServico.Image = ((System.Drawing.Image)(resources.GetObject("mnuIniciarServico.Image")));
            this.mnuIniciarServico.Name = "mnuIniciarServico";
            this.mnuIniciarServico.Size = new System.Drawing.Size(203, 22);
            this.mnuIniciarServico.Text = "Iniciar Serviço";
            // 
            // mnuHistorico
            // 
            this.mnuHistorico.Image = ((System.Drawing.Image)(resources.GetObject("mnuHistorico.Image")));
            this.mnuHistorico.Name = "mnuHistorico";
            this.mnuHistorico.Size = new System.Drawing.Size(203, 22);
            this.mnuHistorico.Text = "Histórico";
            this.mnuHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnAnimais,
            this.btnFuncionarios,
            this.btnServicos,
            this.toolStripSeparator1,
            this.btnAgenda,
            this.toolStripSeparator2,
            this.btnServicoManutencao,
            this.btnIniciarServico,
            this.toolStripSeparator3,
            this.btnHistorico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(772, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClientes
            // 
            this.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(36, 36);
            this.btnClientes.Text = "Cadastro de Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnimais.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimais.Image")));
            this.btnAnimais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(36, 36);
            this.btnAnimais.Text = "Cadastro de Animais";
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(36, 36);
            this.btnFuncionarios.Text = "Cadastro de Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnServicos.Image = ((System.Drawing.Image)(resources.GetObject("btnServicos.Image")));
            this.btnServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(36, 36);
            this.btnServicos.Text = "Cadastro de Serviços";
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAgenda
            // 
            this.btnAgenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(36, 36);
            this.btnAgenda.Text = "Agendamentos";
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnServicoManutencao
            // 
            this.btnServicoManutencao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnServicoManutencao.Image = ((System.Drawing.Image)(resources.GetObject("btnServicoManutencao.Image")));
            this.btnServicoManutencao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicoManutencao.Name = "btnServicoManutencao";
            this.btnServicoManutencao.Size = new System.Drawing.Size(36, 36);
            this.btnServicoManutencao.Text = "Manutenção de Serviços";
            this.btnServicoManutencao.Click += new System.EventHandler(this.btnServicoManutencao_Click);
            // 
            // btnIniciarServico
            // 
            this.btnIniciarServico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIniciarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarServico.Image")));
            this.btnIniciarServico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIniciarServico.Name = "btnIniciarServico";
            this.btnIniciarServico.Size = new System.Drawing.Size(36, 36);
            this.btnIniciarServico.Text = "Inciar Serviço";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnHistorico
            // 
            this.btnHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorico.Image")));
            this.btnHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(36, 36);
            this.btnHistorico.Text = "Mostrar Histórico";
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabWelcome);
            this.tabMain.Controls.Add(this.tabCliente);
            this.tabMain.Controls.Add(this.tabAnimal);
            this.tabMain.Controls.Add(this.tabFuncionario);
            this.tabMain.Controls.Add(this.tabServico);
            this.tabMain.Controls.Add(this.tabAgenda);
            this.tabMain.Controls.Add(this.tabServicoManutencao);
            this.tabMain.Controls.Add(this.tabHistorico);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 63);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(772, 440);
            this.tabMain.TabIndex = 3;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(764, 414);
            this.tabWelcome.TabIndex = 6;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // tabCliente
            // 
            this.tabCliente.AllowDrop = true;
            this.tabCliente.Controls.Add(this.tabControl2);
            this.tabCliente.Controls.Add(this.groupBox1);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(764, 414);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cadastro de Clientes";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabClienteNovo);
            this.tabControl2.Controls.Add(this.tabClienteDados);
            this.tabControl2.Location = new System.Drawing.Point(8, 64);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(748, 358);
            this.tabControl2.TabIndex = 1;
            // 
            // tabClienteNovo
            // 
            this.tabClienteNovo.Location = new System.Drawing.Point(4, 22);
            this.tabClienteNovo.Name = "tabClienteNovo";
            this.tabClienteNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienteNovo.Size = new System.Drawing.Size(740, 332);
            this.tabClienteNovo.TabIndex = 0;
            this.tabClienteNovo.Text = "Novo Cliente";
            this.tabClienteNovo.UseVisualStyleBackColor = true;
            // 
            // tabClienteDados
            // 
            this.tabClienteDados.Location = new System.Drawing.Point(4, 22);
            this.tabClienteDados.Name = "tabClienteDados";
            this.tabClienteDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienteDados.Size = new System.Drawing.Size(740, 332);
            this.tabClienteDados.TabIndex = 1;
            this.tabClienteDados.Text = "Dados de ";
            this.tabClienteDados.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Clientes:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(655, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabAnimal
            // 
            this.tabAnimal.Controls.Add(this.tabControl3);
            this.tabAnimal.Controls.Add(this.groupBox2);
            this.tabAnimal.Location = new System.Drawing.Point(4, 22);
            this.tabAnimal.Name = "tabAnimal";
            this.tabAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimal.Size = new System.Drawing.Size(764, 414);
            this.tabAnimal.TabIndex = 2;
            this.tabAnimal.Text = "Cadastro de Animais";
            this.tabAnimal.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabAnimalNovo);
            this.tabControl3.Controls.Add(this.tabAnimalDados);
            this.tabControl3.Location = new System.Drawing.Point(8, 64);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(748, 358);
            this.tabControl3.TabIndex = 3;
            // 
            // tabAnimalNovo
            // 
            this.tabAnimalNovo.Location = new System.Drawing.Point(4, 22);
            this.tabAnimalNovo.Name = "tabAnimalNovo";
            this.tabAnimalNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimalNovo.Size = new System.Drawing.Size(740, 332);
            this.tabAnimalNovo.TabIndex = 0;
            this.tabAnimalNovo.Text = "Novo Animal";
            this.tabAnimalNovo.UseVisualStyleBackColor = true;
            // 
            // tabAnimalDados
            // 
            this.tabAnimalDados.Location = new System.Drawing.Point(4, 22);
            this.tabAnimalDados.Name = "tabAnimalDados";
            this.tabAnimalDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimalDados.Size = new System.Drawing.Size(740, 332);
            this.tabAnimalDados.TabIndex = 1;
            this.tabAnimalDados.Text = "Dados de ";
            this.tabAnimalDados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Animais:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(655, 20);
            this.textBox2.TabIndex = 0;
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.tabControl4);
            this.tabFuncionario.Controls.Add(this.groupBox3);
            this.tabFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionario.Size = new System.Drawing.Size(764, 414);
            this.tabFuncionario.TabIndex = 3;
            this.tabFuncionario.Text = "Cadastro de Funcionários";
            this.tabFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabFuncionarioNovo);
            this.tabControl4.Controls.Add(this.tabFuncionarioDados);
            this.tabControl4.Location = new System.Drawing.Point(8, 64);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(748, 358);
            this.tabControl4.TabIndex = 3;
            // 
            // tabFuncionarioNovo
            // 
            this.tabFuncionarioNovo.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarioNovo.Name = "tabFuncionarioNovo";
            this.tabFuncionarioNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarioNovo.Size = new System.Drawing.Size(740, 332);
            this.tabFuncionarioNovo.TabIndex = 0;
            this.tabFuncionarioNovo.Text = "Novo Funcionário";
            this.tabFuncionarioNovo.UseVisualStyleBackColor = true;
            // 
            // tabFuncionarioDados
            // 
            this.tabFuncionarioDados.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarioDados.Name = "tabFuncionarioDados";
            this.tabFuncionarioDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarioDados.Size = new System.Drawing.Size(740, 332);
            this.tabFuncionarioDados.TabIndex = 1;
            this.tabFuncionarioDados.Text = "Dados de ";
            this.tabFuncionarioDados.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Funcionário:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(655, 20);
            this.textBox3.TabIndex = 0;
            // 
            // tabServico
            // 
            this.tabServico.Location = new System.Drawing.Point(4, 22);
            this.tabServico.Name = "tabServico";
            this.tabServico.Padding = new System.Windows.Forms.Padding(3);
            this.tabServico.Size = new System.Drawing.Size(764, 414);
            this.tabServico.TabIndex = 1;
            this.tabServico.Text = "Cadastro de Serviços";
            this.tabServico.UseVisualStyleBackColor = true;
            // 
            // tabAgenda
            // 
            this.tabAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(764, 414);
            this.tabAgenda.TabIndex = 4;
            this.tabAgenda.Text = "Agendamentos";
            this.tabAgenda.UseVisualStyleBackColor = true;
            // 
            // tabServicoManutencao
            // 
            this.tabServicoManutencao.Location = new System.Drawing.Point(4, 22);
            this.tabServicoManutencao.Name = "tabServicoManutencao";
            this.tabServicoManutencao.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicoManutencao.Size = new System.Drawing.Size(764, 414);
            this.tabServicoManutencao.TabIndex = 5;
            this.tabServicoManutencao.Text = "Manutenção dos Serviços";
            this.tabServicoManutencao.UseVisualStyleBackColor = true;
            // 
            // tabHistorico
            // 
            this.tabHistorico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorico.Name = "tabHistorico";
            this.tabHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorico.Size = new System.Drawing.Size(764, 414);
            this.tabHistorico.TabIndex = 7;
            this.tabHistorico.Text = "Histórico";
            this.tabHistorico.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 525);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cats And Dogs Control System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAnimal.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabFuncionario.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAgenda;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuIniciarServico;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnAnimais;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimais;
        private System.Windows.Forms.ToolStripMenuItem mnuServico;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroServicos;
        private System.Windows.Forms.ToolStripMenuItem mnuHistorico;
        private System.Windows.Forms.TabPage tabServico;
        private System.Windows.Forms.TabPage tabAnimal;
        private System.Windows.Forms.TabPage tabFuncionario;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabClienteNovo;
        private System.Windows.Forms.TabPage tabClienteDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabAnimalNovo;
        private System.Windows.Forms.TabPage tabAnimalDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabFuncionarioNovo;
        private System.Windows.Forms.TabPage tabFuncionarioDados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripButton btnFuncionarios;
        private System.Windows.Forms.ToolStripButton btnServicos;
        private System.Windows.Forms.ToolStripButton btnAgenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnServicoManutencao;
        private System.Windows.Forms.ToolStripButton btnIniciarServico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnHistorico;
        private System.Windows.Forms.TabPage tabServicoManutencao;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabHistorico;
    }
}


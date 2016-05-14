using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CatsAndDogs
{
    public partial class MainForm : Form
    {
        private List<ClienteHumano> clienteHumano = new List<ClienteHumano>();
        private List<ClienteAnimal> clienteAnimal = new List<ClienteAnimal>();
        private List<Funcionario> funcionario = new List<Funcionario>();
        private List<Servico> servico = new List<Servico>();
        private static List<Agenda> agenda = new List<Agenda>();

        private void initData()
        {
            //popular alguns clientes
            ClienteHumano cli01 = new ClienteHumano() { nome = "Darcilio Gabriel", endereco = "Rua gabriel, 33", telefone = "9999-9999" };
            ClienteHumano cli02 = new ClienteHumano() { nome = "Fabio Pimenta", endereco = "Rua fabio, 44", telefone = "8888-8888" };
            ClienteHumano cli03 = new ClienteHumano() { nome = "Paulo Donizete", endereco = "Rua paulo, 55", telefone = "777-7777" };
            clienteHumano.Add(cli01);
            clienteHumano.Add(cli02);
            clienteHumano.Add(cli03);
            //popular alguns animais
            ClienteAnimal ani01 = new ClienteAnimal() { nome = "Bili", tipo = "Cao", raca = "Purga", sexo = 'M', cliente = cli01 };
            ClienteAnimal ani02 = new ClienteAnimal() { nome = "Bolo", tipo = "Cao", raca = "Carra-Pato", sexo = 'F', cliente = cli01 };
            ClienteAnimal ani03 = new ClienteAnimal() { nome = "Meau", tipo = "Gato", raca = "Vira", sexo = 'F', cliente = cli02 };
            ClienteAnimal ani04 = new ClienteAnimal() { nome = "Faiô", tipo = "Cavalo", raca = "Lata", sexo = 'M', cliente = cli03 };
            clienteAnimal.Add(ani01);
            clienteAnimal.Add(ani02);
            clienteAnimal.Add(ani03);
            clienteAnimal.Add(ani04);
            //popular um funcionario
            Funcionario func01 = new Funcionario() { nome = "Lilica" };
            funcionario.Add(func01);
            //popular alguns servicos
            Servico serv01 = new Servico() { nome = "Banho", status = "", valor = 50.00 };
            Servico serv02 = new Servico() { nome = "Tosa", status = "", valor = 45.00 };
            servico.Add(serv01);
            servico.Add(serv02);
        }

        private void hideAllTabs()
        {
            tabMain.TabPages.Remove(tabWelcome);
            tabMain.TabPages.Remove(tabCliente);
            tabMain.TabPages.Remove(tabAnimal);
            tabMain.TabPages.Remove(tabFuncionario);
            tabMain.TabPages.Remove(tabServico);
            tabMain.TabPages.Remove(tabAgenda);
            tabMain.TabPages.Remove(tabServicoManutencao);
            tabMain.TabPages.Remove(tabHistorico);
            tabMain.TabPages.Remove(tabInicioServico);
            tabMain.TabPages.Remove(tabFinalizar);
        }

        private void showTab(TabPage page)
        {
            this.hideAllTabs();
            tabMain.TabPages.Add(page);
        }

        public MainForm()
        {
            InitializeComponent();
            this.showTab(tabWelcome);
            this.initData();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.showTab(tabCliente);
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            this.showTab(tabAnimal);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.showTab(tabFuncionario);
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            this.showTab(tabServico);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            cbbAgendaCliente.Text = "Selecione um cliente";
            cbbAgendaServiço.Text = "Selecione um serviço";
            cbbAgendaCliente.Items.Clear();
            cbbAgendaServiço.Items.Clear();
            cbbAgendaAnimal.Items.Clear();
            foreach (ClienteHumano hu in clienteHumano)
            {
                cbbAgendaCliente.Items.Add(hu.nome);
            }
            foreach (Servico srv in servico)
            {
                cbbAgendaServiço.Items.Add(srv.nome);
            }
            this.showTab(tabAgenda);
        }

        private void btnServicoManutencao_Click(object sender, EventArgs e)
        {
            this.showTab(tabServicoManutencao);
            lstManutAgenda.Items.Clear();
            foreach (Agenda age in agenda)
            {
                try
                {
                    if (age.servico.status != "Concluído") {
                        ListViewItem item = new ListViewItem();
                        item.Text = String.Format("C = {0}, A = {1}, S = {2}, D = {3}, H = {4}", age.cliente.nome, age.animal.nome, age.servico.nome, age.data, age.hora);
                        item.SubItems.Add(age.funcionario.nome);
                        item.SubItems.Add(age.servico.status);
                        lstManutAgenda.Items.Add(item);
                    }
                }
                catch (Exception)
                {

                }

            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();
            this.showTab(tabHistorico);
            foreach (Agenda age in agenda)
            {
                try
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = String.Format("C = {0}, A = {1}, S = {2}, D = {3}, H = {4}", age.cliente.nome, age.animal.nome, age.servico.nome, age.data, age.hora);
                    item.SubItems.Add(age.funcionario.nome);
                    item.SubItems.Add(age.servico.status);
                    lstHistorico.Items.Add(item);
                }
                catch (Exception)
                {

                }
                    
            }
        }

        private void btnIniciarServico_Click(object sender, EventArgs e)
        {
            cboAgendamento.Text = "Selecione um agendamento";
            cboFuncionário.Text = "Selecione um funcionário";
            cboAgendamento.Items.Clear();
            cboFuncionário.Items.Clear();
            this.hideAllTabs();
            this.showTab(tabInicioServico);
            foreach (Agenda age in agenda)
            {
                if (age.servico.status != "Concluído")
                {
                    cboAgendamento.Items.Add(String.Format("C = {0}, A = {1}, S = {2}, D = {3}, H = {4}", age.cliente.nome, age.animal.nome, age.servico.nome, age.data, age.hora));
                }
            }
            foreach (Funcionario fu in funcionario)
            {
                cboFuncionário.Items.Add(fu.nome);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serviço iniciado com sucesso");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteHumano cli = new ClienteHumano() { nome = txtHumanpNome.Text, endereco = txtHumanoEndereco.Text, telefone = txtHumanoTelefone.Text };
            clienteHumano.Add(cli);
            MessageBox.Show(String.Format("Cliente {0} cadastrado com sucesso",txtHumanpNome.Text));
            txtHumanpNome.Clear();
            txtHumanoEndereco.Clear();
            txtHumanoTelefone.Clear();
        }

        private void listaClienteHumano()
        {
            lstHumano.Items.Clear();
            foreach (ClienteHumano cli in clienteHumano)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cli.nome;
                item.SubItems.Add(cli.endereco);
                item.SubItems.Add(cli.telefone);
                lstHumano.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listaClienteHumano();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstHumano.Items.Count -1; i++)
            {
                if (lstHumano.Items[i].Checked)
                {
                    clienteHumano.RemoveAt(i);
                }
            }
            this.listaClienteHumano();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbAgendaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAgendaAnimal.Text = "Selecione um animal";
            cbbAgendaAnimal.Items.Clear();
            foreach (ClienteAnimal an in clienteAnimal)
            {
                if (an.cliente.nome == cbbAgendaCliente.Text)
                {
                    cbbAgendaAnimal.Items.Add(an.nome);
                }
            }
        }

        private void btnAgendaSalvar_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            ag.animal = clienteAnimal.Find(n => n.nome == cbbAgendaAnimal.Text);
            ag.cliente = clienteHumano.Find(h => h.nome == cbbAgendaCliente.Text);
            ag.servico = servico.Find(s => s.nome == cbbAgendaServiço.Text);
            ag.data = dtpAgenda.Value.Date;
            string hora = string.Format("{0}:{1}:{2}", dtpAgenda.Value.Hour, dtpAgenda.Value.Minute, dtpAgenda.Value.Second);
            ag.hora = DateTime.Parse(hora);
            ag.servico.status = "Agendado";
            agenda.Add(ag);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string lista;
            foreach (Agenda age in agenda)
            {
                lista = String.Format("C = {0}, A = {1}, S = {2}, D = {3}, H = {4}", age.cliente.nome, age.animal.nome, age.servico.nome, age.data, age.hora);
                if (lista == cboAgendamento.Text)
                {
                    age.funcionario = new Funcionario() { nome = cboFuncionário.Text };
                    age.servico.status = "Em Execução";
                    MessageBox.Show("sou igual");
                    return;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.showTab(tabFinalizar);
        }
    }
}

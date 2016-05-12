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
        private void showTab(TabPage page)
        {
            tabMain.TabPages.Remove(tabWelcome);
            tabMain.TabPages.Remove(tabCliente);
            tabMain.TabPages.Remove(tabAnimal);
            tabMain.TabPages.Remove(tabFuncionario);
            tabMain.TabPages.Remove(tabServico);
            tabMain.TabPages.Remove(tabAgenda);
            tabMain.TabPages.Remove(tabServicoManutencao);
            tabMain.TabPages.Remove(tabHistorico);
            tabMain.TabPages.Add(page);
        }

        public MainForm()
        {
            InitializeComponent();
            this.showTab(tabWelcome);
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
            this.showTab(tabAgenda);
        }

        private void btnServicoManutencao_Click(object sender, EventArgs e)
        {
            this.showTab(tabServicoManutencao);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.showTab(tabHistorico);
        }
    }
}

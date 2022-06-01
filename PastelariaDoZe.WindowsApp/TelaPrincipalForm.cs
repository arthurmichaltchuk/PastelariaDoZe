using Autofac;
using PastelariaDoZe.WindowsApp.Features.FuncionarioFeature;
using PastelariaDoZe.WindowsApp.Features.DashboardFeature;
using PastelariaDoZe.WindowsApp.Features.LoginFeature;
using PastelariaDoZe.WindowsApp.Shared;
using System;
using System.Threading;
using System.Windows.Forms;
using PastelariaDoZe.WindowsApp.Features.Configuracoes;
using PastelariaDoZe.WindowsApp.Features.ClienteFeature;
using PastelariaDoZe.WindowsApp.Features.ProdutoFeature;
using PastelariaDoZe.Infra.ExtensionMethods.Linguagem;

namespace PastelariaDoZe.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia;
        public static DashboardControl dash;
        private ICadastravel operacoes;

        public TelaPrincipalForm()
        {
            Instancia = this;
            InitializeComponent();
            ConfigurarPainelDashBoard();
            SetColor();
            
            BotaoHome();
            GeneralConfig.SetLanguageData();

            ConfigureTexts();

        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void menuItemClientes_Click(object sender, EventArgs e)
        {
            ConfiguracaoClienteToolBox configuracao = new ConfiguracaoClienteToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFacDI.Container.Resolve<OperacoesCliente>();

            ConfigurarPainelRegistros();
        }

        private void menuItemProdutos_Click(object sender, EventArgs e)
        {
            ConfiguracaoProdutoToolBox configuracao = new ConfiguracaoProdutoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFacDI.Container.Resolve<OperacoesProduto>();

            ConfigurarPainelRegistros();
        }

        private void menuItemFuncionario_Click(object sender, EventArgs e)
        {
            ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFacDI.Container.Resolve<OperacoesFuncionario>();

            ConfigurarPainelRegistros();
        }

        private void menuItemConfiguracoes_Click(object sender, EventArgs e)
        {
            new ConfiguraçõesForm().ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operacoes = null;
            BotaoHome();
        }

        private void SetColor()
        {
           
        }

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarPainelDashBoard()
        {
            UserControl tabela = AutoFacDI.Container.Resolve<DashboardControl>();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            labelTipoCadastro.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
            btnFiltrar.ToolTipText = configuracao.ToolTipFiltrar;

            btnFiltrar.Enabled = configuracao.EnabledFiltrar;
            btnAdicionar.Enabled = configuracao.EnabledAdicionar;
            btnEditar.Enabled = configuracao.EnabledEditar;
            btnExcluir.Enabled = configuracao.EnabledExcluir;
        }

        private void BotaoHome()
        {
            ConfiguracaoDashboardToolBox configuracao = new ConfiguracaoDashboardToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            ConfigurarPainelDashBoard();
        }

        private void ChamarTelaLogin()
        {
            Application.Run(AutoFacDI.Container.Resolve<TelaLoginForm>());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            operacoes.FiltrarRegistros();
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            //DarkMode.TrocarModo();

            //Serilogger.Logger.Information("Troca de modo de exibição");

            //SetColor();

            //if (operacoes != null)
            //{
            //    IAparenciaAlteravel tabela = (IAparenciaAlteravel)operacoes.ObterTabela();

            //    tabela.AtualizarAparencia();
            //}
            //else
            //    BotaoHome();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var th = new Thread(ChamarTelaLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Dispose();
        }

        private void ConfigureTexts()
        {
            this.menuItemHome.Text = GeneralConfig.Data["Home"];
            this.menuItemDividas.Text = GeneralConfig.Data["Debit"];
            this.menuItemClientes.Text = GeneralConfig.Data["Customers"];
            this.menuItemVendas.Text = GeneralConfig.Data["Sells"];
            this.menuItemFuncionario.Text = GeneralConfig.Data["Employee"];
            this.menuItemProdutos.Text = GeneralConfig.Data["Products"];
            this.cadastrosToolStripMenuItem.Text = GeneralConfig.Data["Registration"];
            this.menuItemConfiguracoes.Text = GeneralConfig.Data["Configuration"];
        }

        private void TelaPrincipalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }
    }
}

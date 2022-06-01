
namespace PastelariaDoZe.WindowsApp
{
    partial class TelaPrincipalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.toolboxAcoes = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.btnModo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDividas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripFooter = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolboxAcoes.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStripFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolboxAcoes
            // 
            this.toolboxAcoes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolboxAcoes.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolboxAcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolboxAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.btnFiltrar,
            this.btnLogOut,
            this.btnModo,
            this.toolStripSeparator2,
            this.labelTipoCadastro});
            this.toolboxAcoes.Location = new System.Drawing.Point(0, 30);
            this.toolboxAcoes.Name = "toolboxAcoes";
            this.toolboxAcoes.Size = new System.Drawing.Size(1212, 37);
            this.toolboxAcoes.TabIndex = 4;
            this.toolboxAcoes.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Image = global::PastelariaDoZe.WindowsApp.Properties.Resources.outline_add_circle_outline_black_24dp;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Size = new System.Drawing.Size(34, 34);
            this.btnAdicionar.Text = "toolStripButton1";
            this.btnAdicionar.ToolTipText = "Inserir";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::PastelariaDoZe.WindowsApp.Properties.Resources.outline_mode_edit_black_24dp;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::PastelariaDoZe.WindowsApp.Properties.Resources.close;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(34, 34);
            this.btnExcluir.Text = "toolStripButton1";
            this.btnExcluir.ToolTipText = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnFiltrar.Size = new System.Drawing.Size(34, 34);
            this.btnFiltrar.Text = "btn";
            this.btnFiltrar.ToolTipText = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogOut.Enabled = false;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(5);
            this.btnLogOut.Size = new System.Drawing.Size(34, 34);
            this.btnLogOut.Text = "toolStripButton1";
            this.btnLogOut.ToolTipText = "Devolver veículo";
            // 
            // btnModo
            // 
            this.btnModo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModo.Image = ((System.Drawing.Image)(resources.GetObject("btnModo.Image")));
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(29, 34);
            this.btnModo.Text = "toolStripButton1";
            this.btnModo.ToolTipText = "Mudar Tema";
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(281, 34);
            this.labelTipoCadastro.Text = "Cadastro Selecionado: Nenhum";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHome,
            this.cadastrosToolStripMenuItem,
            this.menuItemConfiguracoes});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1212, 30);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemHome
            // 
            this.menuItemHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuItemHome.Name = "menuItemHome";
            this.menuItemHome.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.menuItemHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuItemHome.Size = new System.Drawing.Size(85, 26);
            this.menuItemHome.Text = "Home";
            this.menuItemHome.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDividas,
            this.menuItemClientes,
            this.menuItemVendas,
            this.menuItemFuncionario,
            this.menuItemProdutos});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuItemDividas
            // 
            this.menuItemDividas.Name = "menuItemDividas";
            this.menuItemDividas.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuItemDividas.Size = new System.Drawing.Size(235, 26);
            this.menuItemDividas.Text = "Dívidas";
            // 
            // menuItemClientes
            // 
            this.menuItemClientes.Name = "menuItemClientes";
            this.menuItemClientes.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuItemClientes.Size = new System.Drawing.Size(235, 26);
            this.menuItemClientes.Text = "Clientes";
            this.menuItemClientes.Click += new System.EventHandler(this.menuItemClientes_Click);
            // 
            // menuItemVendas
            // 
            this.menuItemVendas.Name = "menuItemVendas";
            this.menuItemVendas.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuItemVendas.Size = new System.Drawing.Size(235, 26);
            this.menuItemVendas.Text = "Vendas";
            // 
            // menuItemFuncionario
            // 
            this.menuItemFuncionario.Name = "menuItemFuncionario";
            this.menuItemFuncionario.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuItemFuncionario.Size = new System.Drawing.Size(235, 26);
            this.menuItemFuncionario.Text = "Funcionários";
            this.menuItemFuncionario.Click += new System.EventHandler(this.menuItemFuncionario_Click);
            // 
            // menuItemProdutos
            // 
            this.menuItemProdutos.Name = "menuItemProdutos";
            this.menuItemProdutos.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItemProdutos.Size = new System.Drawing.Size(235, 26);
            this.menuItemProdutos.Text = "Produtos";
            this.menuItemProdutos.Click += new System.EventHandler(this.menuItemProdutos_Click);
            // 
            // menuItemConfiguracoes
            // 
            this.menuItemConfiguracoes.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuItemConfiguracoes.Name = "menuItemConfiguracoes";
            this.menuItemConfiguracoes.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.menuItemConfiguracoes.Size = new System.Drawing.Size(158, 26);
            this.menuItemConfiguracoes.Text = "Configurações";
            this.menuItemConfiguracoes.Click += new System.EventHandler(this.menuItemConfiguracoes_Click);
            // 
            // statusStripFooter
            // 
            this.statusStripFooter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStripFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStripFooter.Location = new System.Drawing.Point(0, 887);
            this.statusStripFooter.Name = "statusStripFooter";
            this.statusStripFooter.Padding = new System.Windows.Forms.Padding(1, 0, 26, 0);
            this.statusStripFooter.Size = new System.Drawing.Size(1212, 28);
            this.statusStripFooter.TabIndex = 6;
            this.statusStripFooter.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(85, 22);
            this.labelRodape.Text = "Tudo Ok";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegistros.Location = new System.Drawing.Point(22, 94);
            this.panelRegistros.Margin = new System.Windows.Forms.Padding(5);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(1159, 772);
            this.panelRegistros.TabIndex = 5;
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIconSystemTray";
            this.notifyIconSystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseDoubleClick);
            // 
            // TelaPrincipalForm
            // 
            this.AccessibleDescription = "Engloba todas as funcionalidades do programa";
            this.AccessibleName = "Tela Principal";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1212, 915);
            this.Controls.Add(this.statusStripFooter);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolboxAcoes);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastelaria do Zé";
            this.Resize += new System.EventHandler(this.TelaPrincipalForm_Resize);
            this.toolboxAcoes.ResumeLayout(false);
            this.toolboxAcoes.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStripFooter.ResumeLayout(false);
            this.statusStripFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolboxAcoes;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDividas;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientes;
        private System.Windows.Forms.StatusStrip statusStripFooter;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemVendas;
        private System.Windows.Forms.ToolStripMenuItem menuItemHome;
        private System.Windows.Forms.ToolStripMenuItem menuItemFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuItemConfiguracoes;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripButton btnModo;
        private System.Windows.Forms.ToolStripMenuItem menuItemProdutos;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
    }
}


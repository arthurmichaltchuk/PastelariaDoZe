﻿using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using PastelariaDoZe.Aplicacao.ClienteCNPJModule;
using PastelariaDoZe.Dominio.ClienteModule;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace PastelariaDoZe.WindowsApp.Features.ClienteFeature
{
    public partial class TelaClienteForm : Form
    {
        private ClienteBase cliente;
        private ClienteCNPJAppService CNPJService;
        public TelaClienteForm(ClienteCNPJAppService CNPJService)
        {
            this.CNPJService = CNPJService;
            InitializeComponent();
            PopularCombobox();
            SetColor();
        }

        public ClienteBase Cliente
        {
            get { return cliente; }

            set
            {
                cliente = value;

                txtID.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtEndereco.Text = cliente.Endereco;
                mskTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                rbFisico.Enabled = false;
                rbJuridico.Enabled = false;

                if (cliente is ClienteCPF)
                {
                    ClienteCPF clienteCPF = (ClienteCPF)cliente;
                    mskCpf.Text = clienteCPF.Cpf;
                    mskRg.Text = clienteCPF.Rg;
                    mskCnh.Text = clienteCPF.Cnh;
                    dtDataValidade.Value = clienteCPF.DataValidade;
                    cbEmpresas.SelectedItem = clienteCPF.Cliente;
                    rbFisico.Checked = true;

                }
                else
                {
                    ClienteCNPJ clienteCNPJ = (ClienteCNPJ)cliente;
                    mskCnpj.Text = clienteCNPJ.Cnpj;
                    rbJuridico.Checked = true;
                }

            }

        }

        public FiltroClienteEnum TipoCliente
        {
            get
            {
                if (rbFisico.Checked)
                    return FiltroClienteEnum.PessoaFisica;
                else
                    return FiltroClienteEnum.PessoaJuridica;
            }
        }

        private void SetColor()
        {
            //this.header_Cliente.BackColor = DarkMode.corHeader;
            //this.BackColor = DarkMode.corPanel;
            //this.ForeColor = DarkMode.corFonte;
            //txtID.BackColor = Color.DarkSeaGreen;
            //txtNome.BackColor = DarkMode.corFundoTxBox;
            //txtEndereco.BackColor = DarkMode.corFundoTxBox;
            //mskTelefone.BackColor = DarkMode.corFundoTxBox;
            //mskCpf.BackColor = DarkMode.corFundoTxBox;
            //mskCnpj.BackColor = DarkMode.corFundoTxBox;
            //mskCnh.BackColor = DarkMode.corFundoTxBox;
            //dtDataValidade.BackColor = DarkMode.corFundoTxBox;
            //mskRg.BackColor = DarkMode.corFundoTxBox;
            //cbEmpresas.BackColor = DarkMode.corFundoTxBox;
            //txtEmail.BackColor = DarkMode.corFundoTxBox;

            //txtID.ForeColor = DarkMode.corFonte;
            //txtNome.ForeColor = DarkMode.corFonte;
            //txtEndereco.ForeColor = DarkMode.corFonte;
            //mskTelefone.ForeColor = DarkMode.corFonte;
            //mskCpf.ForeColor = DarkMode.corFonte;
            //mskCnpj.ForeColor = DarkMode.corFonte;
            //mskCnh.ForeColor = DarkMode.corFonte;
            //dtDataValidade.ForeColor = DarkMode.corFonte;
            //mskRg.ForeColor = DarkMode.corFonte;
            //cbEmpresas.ForeColor = DarkMode.corFonte;
            //txtEmail.ForeColor = DarkMode.corFonte;

            //btnGravar.BackColor = DarkMode.corFundoTxBox;
            //btnCancelar.BackColor = DarkMode.corFundoTxBox;
            //rbFisico.ForeColor = DarkMode.corFonte;
            //rbJuridico.ForeColor = DarkMode.corFonte;
        }

        private void PopularCombobox()
        {
            List<ClienteCNPJ> empresas = CNPJService.GetAll();

            empresas.ForEach(x => cbEmpresas.Items.Add(x));
        }

        private void ConfigurarCliente()
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;

            if (rbFisico.Checked)
            {
                string cpf = mskCpf.Text;
                string rg = mskRg.Text;
                string cnh = mskCnh.Text;
                DateTime dataValidade = dtDataValidade.Value;
                ClienteCNPJ empresa = (ClienteCNPJ)cbEmpresas.SelectedItem;

                if (cliente != null)
                {

                    ClienteCPF clienteCPF = (ClienteCPF)cliente;
                    clienteCPF.Cpf = cpf;
                    clienteCPF.Rg = rg;
                    clienteCPF.Cnh = cnh;
                    clienteCPF.DataValidade = dataValidade;
                    clienteCPF.Cliente = empresa;
                    clienteCPF.Nome = nome;
                    clienteCPF.Endereco = endereco;
                    clienteCPF.Telefone = telefone;
                    clienteCPF.Email = email;

                    cliente = clienteCPF;
                }
                else
                    cliente = new ClienteCPF(nome, telefone, endereco, cpf, rg, cnh, dataValidade, email, empresa);
            }
            else
            {
                string cnpj = mskCnpj.Text;
                if (cliente != null)
                {
                    ClienteCNPJ clienteCNPJ = (ClienteCNPJ)cliente;
                    clienteCNPJ.Cnpj = cnpj;
                    clienteCNPJ.Nome = nome;
                    clienteCNPJ.Endereco = endereco;
                    clienteCNPJ.Telefone = telefone;
                    clienteCNPJ.Email = email;

                    cliente = clienteCNPJ;
                }
                else
                    cliente = new ClienteCNPJ(nome, endereco, telefone, cnpj, email);
            }
        }

        private void rbFisico_CheckedChanged(object sender, EventArgs e)
        {
            mskCpf.Enabled = true;
            mskCnh.Enabled = true;
            dtDataValidade.Enabled = true;
            mskRg.Enabled = true;
            cbEmpresas.Enabled = true;
            mskCnpj.Enabled = false;
        }

        private void rbJuridico_CheckedChanged(object sender, EventArgs e)
        {
            mskCpf.Enabled = false;
            mskCnh.Enabled = false;
            mskRg.Enabled = false;
            dtDataValidade.Enabled = false;
            cbEmpresas.Enabled = false;
            mskCnpj.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ConfigurarCliente();

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaClienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        public void txtCampo_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }

        public void txtCampo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.LightCyan;
            }
        }
    }
}

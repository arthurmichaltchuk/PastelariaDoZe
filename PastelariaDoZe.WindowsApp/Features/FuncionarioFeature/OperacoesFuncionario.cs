﻿using PastelariaDoZe.Aplicacao.FuncionarioModule;
using PastelariaDoZe.Dominio.FuncionarioModule;
using PastelariaDoZe.WindowsApp;
using PastelariaDoZe.WindowsApp.Features.FuncionarioFeature;
using PastelariaDoZe.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.FuncionarioFeature
{
    public class OperacoesFuncionario : ICadastravel
    {
        private readonly FuncionarioAppService funcionarioService;
        private readonly TabelaFuncionarioControl tabelaFuncionarios;

        public OperacoesFuncionario(FuncionarioAppService funcionarioService)
        {
            this.funcionarioService = funcionarioService;
            tabelaFuncionarios = new TabelaFuncionarioControl();
        }


        public void DevolverVeiculo()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (!VerificarIdSelecionado(id, "Editar", "Edição"))
                return;

            Funcionario funcionarioSelecionado = funcionarioService.GetById(id);

            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            tela.Funcionario = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                funcionarioService.Editar(tela.Funcionario);

                List<Funcionario> compromissos = funcionarioService.GetAll();

                tabelaFuncionarios.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Funcionario.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaFuncionarios.ObtemIdSelecionado();

            if (!VerificarIdSelecionado(id, "Excluir", "Exclusão"))
                return;

            Funcionario funcionarioSelecionado = funcionarioService.GetById(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Funcionário: [{funcionarioSelecionado.Nome}] ?",
                "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                funcionarioService.Excluir(funcionarioSelecionado);

                List<Funcionario> compromissos = funcionarioService.GetAll();

                tabelaFuncionarios.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{funcionarioSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                funcionarioService.Inserir(tela.Funcionario);

                List<Funcionario> funcionarios = funcionarioService.GetAll();

                tabelaFuncionarios.AtualizarRegistros(funcionarios);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Funcionario.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Funcionario> funcionarios = funcionarioService.GetAll();

            tabelaFuncionarios.AtualizarRegistros(funcionarios);

            return tabelaFuncionarios;
        }

        private bool VerificarIdSelecionado(int id, string acao, string onde)
        {
            if (id == 0)
            {
                MessageBox.Show($"Selecione um Funcionário para poder {acao}!", $"{onde} de Funcionários",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public void PesquisarRegistro(string pesquisa)
        {
            List<Funcionario> funcionarios = funcionarioService.GetAll();

            var palavras = pesquisa.Split(' ');

            List<Funcionario> filtrados = funcionarios.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();

            tabelaFuncionarios.AtualizarRegistros(filtrados);
        }
    }
}

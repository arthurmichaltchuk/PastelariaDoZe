using PastelariaDoZe.Aplicacao.ProdutoModule;
using PastelariaDoZe.Dominio.ProdutoModule;
using PastelariaDoZe.WindowsApp;
using PastelariaDoZe.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    public class OperacoesProduto : ICadastravel
    {
        private readonly ProdutoAppService produtoService;
        private readonly TabelaProdutoControl tabelaprodutos;

        public OperacoesProduto(ProdutoAppService produtoService)
        {
            this.produtoService = produtoService;
            tabelaprodutos = new TabelaProdutoControl();
        }

        public void EditarRegistro()
        {
            int id = tabelaprodutos.ObtemIdSelecionado();

            if (!VerificarIdSelecionado(id, "Editar", "Edição"))
                return;

            Produto produtoSelecionado = produtoService.GetById(id);

            TelaProdutoForm tela = new TelaProdutoForm();

            tela.Produto = produtoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                produtoService.Editar(tela.Produto);

                List<Produto> compromissos = produtoService.GetAll();

                tabelaprodutos.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Produto: [{tela.Produto.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaprodutos.ObtemIdSelecionado();

            if (!VerificarIdSelecionado(id, "Excluir", "Exclusão"))
                return;

            Produto produtoSelecionado = produtoService.GetById(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Funcionário: [{produtoSelecionado.Nome}] ?",
                "Exclusão de Funcionários", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                produtoService.Excluir(produtoSelecionado);

                List<Produto> compromissos = produtoService.GetAll();

                tabelaprodutos.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{produtoSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TelaProdutoForm tela = new TelaProdutoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                produtoService.Inserir(tela.Produto);

                List<Produto> produtos = produtoService.GetAll();

                tabelaprodutos.AtualizarRegistros(produtos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Funcionário: [{tela.Produto.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Produto> produtos = produtoService.GetAll();

            tabelaprodutos.AtualizarRegistros(produtos);

            return tabelaprodutos;
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
            List<Produto> produtos = produtoService.GetAll();

            var palavras = pesquisa.Split(' ');

            List<Produto> filtrados = produtos.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();

            tabelaprodutos.AtualizarRegistros(filtrados);
        }
    }
}

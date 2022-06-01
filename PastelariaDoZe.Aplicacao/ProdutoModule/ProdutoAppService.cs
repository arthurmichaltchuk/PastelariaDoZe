using PastelariaDoZe.Infra.ExtensionMethods;
using PastelariaDoZe.Infra.Logger;
using PastelariaDoZe.Dominio.ProdutoModule;
using System.Collections.Generic;

namespace PastelariaDoZe.Aplicacao.ProdutoModule
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository ProdutoRepository;

        public ProdutoAppService(IProdutoRepository ProdutoRepo)
        {
            ProdutoRepository = ProdutoRepo;
        }

        public bool Inserir(Produto Produto)
        {
            string resultadoValidacaoDominio = Produto.Validar();

            Serilogger.Logger.Aqui().Debug("REGISTRANDO PRODUTO {ProdutoNome} ", Produto.Nome);

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                ProdutoRepository.Inserir(Produto);

                Serilogger.Logger.Aqui().Debug("PRODUTO {ProdutoNome} REGISTRADO COM SUCESSO", Produto.Nome);

                return true;
            }
            else
            {
                Serilogger.Logger.Aqui().Error("NÃO FOI POSSÍVEL REGISTRAR PRODUTO {ProdutoNome}", Produto.Nome);

                return false;
            }


        }
        public bool Editar(Produto Produto)
        {
            string resultadoValidacaoDominio = Produto.Validar();

            Serilogger.Logger.Aqui().Debug("EDITANDO PRODUTO {ProdutoNome} ", Produto.Nome);

            if (resultadoValidacaoDominio == "ESTA_VALIDO")
            {
                ProdutoRepository.Editar(Produto);

                Serilogger.Logger.Aqui().Debug("PRODUTO {ProdutoNome} EDITADO COM SUCESSO", Produto.Nome);

                return true;
            }
            else
            {
                Serilogger.Logger.Aqui().Error("NÃO FOI POSSÍVEL EDITAR PRODUTO {ProdutoNome}", Produto.Nome);

                return false;
            }
        }

        public bool Excluir(Produto Produto)
        {
            Serilogger.Logger.Aqui().Debug("REMOVENDO PRODUTO {Id}", Produto.Id);

            var excluiu = ProdutoRepository.Excluir(Produto);

            if (excluiu)
                Serilogger.Logger.Aqui().Debug("PRODUTO {Id} REMOVIDO COM SUCESSO", Produto.Id);
            else
                Serilogger.Logger.Aqui().Error("NÃO FOI POSSÍVEL REMOVER PRODUTO {Id}.", Produto.Id);

            return excluiu;
        }

        public Produto GetById(int id)
        {
            Serilogger.Logger.Aqui().Debug("SELECIONANDO O PRODUTO ID: {Id}", id);

            Produto Produto = ProdutoRepository.GetById(id);

            if (Produto == null)
                Serilogger.Logger.Aqui().Information("NÃO FOI POSSÍVEL ENCONTRAR O PRODUTO ID {Id}", Produto.Id);
            else
                Serilogger.Logger.Aqui().Debug("PRODUTO ID {Id} SELECIONADO COM SUCESSO", Produto.Id);

            return Produto;
        }

        public List<Produto> GetAll()
        {
            Serilogger.Logger.Aqui().Debug("SELECIONANDO TODOS OS PRODUTOS");

            List<Produto> Produto = ProdutoRepository.GetAll();

            if (Produto.Count == 0)
                Serilogger.Logger.Aqui().Information("NÃO HÁ PRODUTOS CADASTRADOS");
            else
                Serilogger.Logger.Aqui().Debug("A SELEÇÃO TROUXE {Quantidade} PRODUTO(S) EXISTENTE(S)", Produto.Count);

            return Produto;
        }
    }
}

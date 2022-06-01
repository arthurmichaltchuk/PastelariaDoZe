using PastelariaDoZe.WindowsApp.Shared;

namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    public class ConfiguracaoProdutoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Cadastrar um Produto"; }
        }

        public string TipoCadastro
        {
            get { return "Cadastro de Produtos"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Produto"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Produto"; }
        }

        public string ToolTipFiltrar
        {
            get { return "Filtrar Produtos"; }
        }

        public bool EnabledFiltrar
        {
            get { return false; }
        }
        public bool EnabledDevolver
        {
            get { return false; }
        }

        public bool EnabledAdicionar => true;

        public bool EnabledEditar => true;

        public bool EnabledExcluir => true;

        public bool EnabledPesquisar => true;
    }
}

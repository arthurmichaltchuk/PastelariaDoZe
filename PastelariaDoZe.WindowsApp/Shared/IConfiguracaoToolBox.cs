namespace PastelariaDoZe.WindowsApp.Shared
{
    public interface IConfiguracaoToolBox
    {
        string ToolTipAdicionar { get; }
        string TipoCadastro { get; }
        string ToolTipEditar { get; }
        string ToolTipExcluir { get; }
        string ToolTipFiltrar { get; }

        bool EnabledAdicionar { get; }
        bool EnabledEditar { get; }
        bool EnabledExcluir { get; }
        bool EnabledFiltrar { get; }
        bool EnabledDevolver { get; }
        bool EnabledPesquisar { get; }
    }
}

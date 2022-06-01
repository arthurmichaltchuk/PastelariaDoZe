using PastelariaDoZe.Dominio.ProdutoModule;
using PastelariaDoZe.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    public partial class TabelaProdutoControl : UserControl, IAparenciaAlteravel
    {
        public TabelaProdutoControl()
        {
            InitializeComponent();
            ConfigurarGridLightMode();
            gridProdutos.ConfigurarGridSomenteLeitura();
            gridProdutos.Columns.AddRange(ObterColunas());
        } 

        public void ConfigurarGridLightMode()
        {
            gridProdutos.ConfigurarGridZebrado();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorUnitario", HeaderText = "Valor Unitário"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataValidade", HeaderText = "Data de Validade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridProdutos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            gridProdutos.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                gridProdutos.Rows.Add(produto.Id, produto.Nome, produto.ValorUnitario,
                    produto.DataValidade, produto.Quantidade);

            }
        }
        public void AtualizarAparencia()
        {
            ConfigurarGridLightMode();
        }
    }
}

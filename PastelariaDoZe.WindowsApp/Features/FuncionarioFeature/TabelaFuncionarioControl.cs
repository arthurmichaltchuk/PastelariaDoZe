
using PastelariaDoZe.Dominio.FuncionarioModule;
using PastelariaDoZe.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.FuncionarioFeature
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();
            ConfigurarGridLightMode();
            gridFuncionarios.ConfigurarGridSomenteLeitura();
            gridFuncionarios.Columns.AddRange(ObterColunas());
        } 

        public void ConfigurarGridLightMode()
        {
            gridFuncionarios.ConfigurarGridZebrado();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Salario", HeaderText = "Salário"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Data de Entrada", HeaderText = "Data de Entrada"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Usuario", HeaderText = "Usuário"}
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridFuncionarios.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            gridFuncionarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                gridFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.CpfFuncionario,
                    funcionario.Salario, funcionario.DataEntrada, funcionario.Usuario);

            }
        }
        public void AtualizarAparencia()
        {
            ConfigurarGridLightMode();
        }
    }
}

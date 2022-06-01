﻿using PastelariaDoZe.WindowsApp.Shared;

namespace PastelariaDoZe.WindowsApp.Features.ClienteFeature
{
    public class ConfiguracaoClienteToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar um Cliente"; }
        }
        public string TipoCadastro
        {
            get { return "Cadastro de Clientes"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Cliente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Cliente"; }
        }

        public string ToolTipFiltrar
        {
            get { return "Filtrar Clientes"; }
        }

        public string ToolTipDevolver
        {
            get { return "Devolver um Veículo"; }
        }

        public bool EnabledFiltrar => true;

        public bool EnabledDevolver => false;

        public bool EnabledAdicionar => true;

        public bool EnabledEditar => true;

        public bool EnabledExcluir => true;

        public bool EnabledPesquisar => true;
    }
}

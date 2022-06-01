using PastelariaDoZe.Dominio.FuncionarioModule;
using PastelariaDoZe.Infra.Context;
using PastelariaDoZe.Infra.ORM.Shared;
using System;
using System.Collections.Generic;

namespace PastelariaDoZe.Infra.ORM.FuncionarioModule
{
    public class FuncionarioDAO : BaseDAO<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioDAO(PastelContext contexto) : base(contexto)
        {
            
        }
    }
}

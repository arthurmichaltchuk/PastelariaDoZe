using PastelariaDoZe.Dominio.ProdutoModule;
using PastelariaDoZe.Infra.Context;
using PastelariaDoZe.Infra.ORM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelariaDoZe.Infra.ORM.ProdutoModule
{
    public class ProdutoDAO : BaseDAO<Produto>, IProdutoRepository
    {
        public ProdutoDAO(PastelContext contexto) : base(contexto)
        {

        }
    }
}

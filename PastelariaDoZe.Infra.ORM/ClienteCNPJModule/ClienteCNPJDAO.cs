using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Infra.Context;
using PastelariaDoZe.Infra.ORM.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PastelariaDoZe.Infra.ORM.ClienteCNPJModule
{
    public class ClienteCNPJDAO : BaseDAO<ClienteCNPJ>, IClienteCNPJRepository
    {
        public ClienteCNPJDAO(PastelContext context) : base(context)
        {

        }
        public override ClienteCNPJ GetById(int id)
        {
            return registros.SingleOrDefault(x => x.Id == id);
        }
        public override List<ClienteCNPJ> GetAll()
        {
            return registros.ToList();
        }
        public bool ExisteCNPJ(string cnpj)
        {
            return registros.ToList().Exists(x => x.Cnpj == cnpj);
        }
    }
}

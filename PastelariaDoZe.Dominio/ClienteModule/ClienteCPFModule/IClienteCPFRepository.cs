using PastelariaDoZe.Dominio.Shared;
using System.Collections.Generic;

namespace PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule
{
    public interface IClienteCPFRepository : IBaseRepository<ClienteCPF>
    {
        List<ClienteCPF> SelecionarPorIdEmpresa(int id);
        bool ExisteCPF(string cpf);
    }
}

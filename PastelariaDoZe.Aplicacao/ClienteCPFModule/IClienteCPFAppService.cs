using PastelariaDoZe.Aplicacao.Shared;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using System.Collections.Generic;

namespace PastelariaDoZe.Aplicacao.ClienteCPFModule
{
    public interface IClienteCPFAppService : IBaseAppService<ClienteCPF>
    {
        List<ClienteCPF> GetAllEmpresaId(int id);
    }
}
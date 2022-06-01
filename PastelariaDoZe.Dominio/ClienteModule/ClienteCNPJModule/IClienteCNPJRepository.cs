using PastelariaDoZe.Dominio.Shared;

namespace PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule
{
    public interface IClienteCNPJRepository : IBaseRepository<ClienteCNPJ>
    {
        bool ExisteCNPJ(string cnpj);
    }
}

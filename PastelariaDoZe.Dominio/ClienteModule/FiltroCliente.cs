using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using System.Collections.Generic;

namespace PastelariaDoZe.Dominio.ClienteModule
{
    public class FiltroCliente : IFiltroCliente
    {
        private readonly IClienteCNPJRepository clienteCNPJRepo;
        private readonly IClienteCPFRepository clienteCPFRepo;

        public FiltroCliente(IClienteCNPJRepository clienteCNPJRepo, IClienteCPFRepository clienteCPFRepo)
        {
            this.clienteCNPJRepo = clienteCNPJRepo;
            this.clienteCPFRepo = clienteCPFRepo;
        }
        public IEnumerable<ClienteBase> FiltrarClientes(FiltroClienteEnum tipoFiltro)
        {
            switch (tipoFiltro)
            {
                case FiltroClienteEnum.PessoaFisica:
                    return clienteCPFRepo.GetAll();

                case FiltroClienteEnum.PessoaJuridica:
                    return clienteCNPJRepo.GetAll();

                default: return null;
            }
        }
    }
}

using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelariaDoZe.Dominio.ClienteModule
{
    public interface IFiltroCliente
    {
        IEnumerable<ClienteBase> FiltrarClientes(FiltroClienteEnum tipoFiltro);
    }
}

using Autofac;
using PastelariaDoZe.Aplicacao.FuncionarioModule;
using PastelariaDoZe.Dominio.FuncionarioModule;
using PastelariaDoZe.Infra.Context;
using PastelariaDoZe.Infra.ORM.FuncionarioModule;
using PastelariaDoZe.Infra.ORM.LoginModule;
using PastelariaDoZe.WindowsApp.Features.FuncionarioFeature;
using PastelariaDoZe.WindowsApp.Features.LoginFeature;
using PastelariaDoZe.WindowsApp.Features.DashboardFeature;
using PastelariaDoZe.Dominio.ClienteModule;
using PastelariaDoZe.WindowsApp.Features.ClienteFeature;
using PastelariaDoZe.Aplicacao.ClienteCNPJModule;
using PastelariaDoZe.Aplicacao.ClienteCPFModule;
using PastelariaDoZe.Infra.ORM.ClienteCNPJModule;
using PastelariaDoZe.Infra.ORM.ClienteCPFModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using PastelariaDoZe.WindowsApp.Features.ProdutoFeature;
using PastelariaDoZe.Aplicacao.ProdutoModule;
using PastelariaDoZe.Dominio.ProdutoModule;
using PastelariaDoZe.Infra.ORM.ProdutoModule;

namespace PastelariaDoZe.WindowsApp.Shared
{
    public class AutoFacDI
    {
        private static ContainerBuilder Builder = new();
        public static IContainer Container;

        static AutoFacDI()
        {
            Builder.RegisterType<PastelContext>().InstancePerLifetimeScope();

            ConfigurarORM();

            ConfigurarInterfaces();

            ConfigurarService();

            ConfigurarOperacao();

            ConfigurarTela();

            Container = Builder.Build();
        }

        private static void ConfigurarInterfaces()
        {
            Builder.RegisterType<DashboardControl>().InstancePerDependency();
            Builder.RegisterType<FiltroCliente>().InstancePerDependency();
        }

        private static void ConfigurarTela()
        {
            Builder.RegisterType<TelaLoginForm>().InstancePerDependency();
        }

        private static void ConfigurarOperacao()
        {
            Builder.RegisterType<OperacoesFuncionario>().InstancePerDependency();
            Builder.RegisterType<OperacoesProduto>().InstancePerDependency();
            Builder.RegisterType<OperacoesCliente>().InstancePerDependency();
        }

        private static void ConfigurarService()
        {
            Builder.RegisterType<ProdutoAppService>().InstancePerDependency();
            Builder.RegisterType<ClienteCNPJAppService>().InstancePerDependency();
            Builder.RegisterType<ClienteCPFAppService>().InstancePerDependency();
            Builder.RegisterType<FuncionarioAppService>().InstancePerDependency();
        }
        private static void ConfigurarORM()
        {
            Builder.RegisterType<ClienteCNPJDAO>().As<IClienteCNPJRepository>().InstancePerDependency();
            Builder.RegisterType<FuncionarioDAO>().As<IFuncionarioRepository>().AsSelf().InstancePerDependency();
            Builder.RegisterType<ClienteCPFDAO>().As<IClienteCPFRepository>().InstancePerDependency();
            Builder.RegisterType<ProdutoDAO>().As<IProdutoRepository>().InstancePerDependency();
            Builder.RegisterType<LoginDAO>().InstancePerDependency();
        }
    }
}

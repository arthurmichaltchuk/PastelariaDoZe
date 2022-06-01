using PastelariaDoZe.Infra.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PastelariaDoZe.Dominio.FuncionarioModule;
using System.IO;
using Microsoft.Extensions.Logging;
using PastelariaDoZe.Infra.Logger;
using PastelariaDoZe.Dominio.ProdutoModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using Serilog;

namespace PastelariaDoZe.Infra.Context
{
    public class PastelContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ClienteCPF> ClientesCPF { get; set; }
        public DbSet<ClienteCNPJ> ClientesCNPJ { get; set; }

        private static readonly ILoggerFactory SeriLog = LoggerFactory.Create(builder =>
        {
            builder.
                AddFilter((category, logLevel) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && logLevel == LogLevel.Debug).
                AddDebug().
                AddSerilog(Serilogger.Logger, dispose: true);
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PastelariaDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PastelContext).Assembly);

            var memoryStreamConverter = new ValueConverter<MemoryStream, byte[]>(
                        p => p.ToArray(),
                        p => p.ToMemoryStream());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(MemoryStream))
                        property.SetValueConverter(memoryStreamConverter);
                }
            }
        }

    }

}


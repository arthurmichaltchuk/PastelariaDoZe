using PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace PastelariaDoZe.Infra.Configurations.ClienteCPFModule
{
    class ClienteCPFConfiguration : IEntityTypeConfiguration<ClienteCPF>
    {
        public void Configure(EntityTypeBuilder<ClienteCPF> builder)
        {
            builder.ToTable("TBClientesCPF");

            builder.Property(e => e.Cpf).HasColumnType("VARCHAR(14)").IsRequired();

            builder.Property(e => e.Cnh).HasColumnType("VARCHAR(12)").IsRequired();

            builder.Property(e => e.Rg).HasColumnType("VARCHAR(10)").IsRequired();
        }
    }
}

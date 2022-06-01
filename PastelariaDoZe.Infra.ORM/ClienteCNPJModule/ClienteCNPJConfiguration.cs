using PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule;
using PastelariaDoZe.Infra.Context;
using PastelariaDoZe.Infra.ORM.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelariaDoZe.Infra.Configurations.ClienteCNPJModule
{
    public class ClienteCNPJConfiguration : IEntityTypeConfiguration<ClienteCNPJ>
    {
        public void Configure(EntityTypeBuilder<ClienteCNPJ> builder)
        {
            builder.ToTable("TBClientesCNPJ");

            builder.Property(e => e.Cnpj).HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
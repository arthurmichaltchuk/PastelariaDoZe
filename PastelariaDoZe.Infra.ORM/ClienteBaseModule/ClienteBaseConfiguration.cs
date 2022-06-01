﻿using PastelariaDoZe.Dominio.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PastelariaDoZe.Infra.ORM.ClienteBaseModule
{
    public class ClienteBaseConfiguration : IEntityTypeConfiguration<ClienteBase>
    {
        public void Configure(EntityTypeBuilder<ClienteBase> builder)
        {
            builder.ToTable("TBClientesBase");

            builder.HasKey(c => c.Id);

            builder.Property(e => e.Email).HasColumnType("VARCHAR(250)").IsRequired();

            builder.Property(e => e.Endereco).HasColumnType("VARCHAR(100)").IsRequired();

            builder.Property(e => e.Nome).HasColumnType("VARCHAR(100)").IsRequired();

            builder.Property(e => e.Telefone).HasColumnType("VARCHAR(15)").IsRequired();

        }
    }
}

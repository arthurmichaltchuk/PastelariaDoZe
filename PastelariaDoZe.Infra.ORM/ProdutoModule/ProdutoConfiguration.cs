using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PastelariaDoZe.Dominio.ProdutoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelariaDoZe.Infra.ORM.ProdutoModule
{
    class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TBProdutos");

            builder.HasKey(produto => produto.Id);

            builder.Property(produto => produto.Nome).HasColumnType("VARCHAR(50)").IsRequired();

            builder.Property(produto => produto.ValorUnitario).HasColumnType("FLOAT").IsRequired();

            builder.Property(produto => produto.DataValidade).HasColumnType("DATE").IsRequired();

            builder.Property(produto => produto.Quantidade).HasColumnType("INT").IsRequired();
        }
    }
}

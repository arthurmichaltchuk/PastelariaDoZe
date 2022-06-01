﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PastelariaDoZe.Infra.Context;

namespace PastelariaDoZe.Infra.ORM.Migrations
{
    [DbContext(typeof(PastelContext))]
    partial class PastelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PastelariaDoZe.Dominio.ClienteModule.ClienteBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("TBClientesBase");
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.FuncionarioModule.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfFuncionario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("DATE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<double>("Salario")
                        .HasColumnType("FLOAT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(64)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TBFuncionarios");
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.ProdutoModule.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("DATE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INT");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("FLOAT");

                    b.HasKey("Id");

                    b.ToTable("TBProdutos");
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule.ClienteCNPJ", b =>
                {
                    b.HasBaseType("PastelariaDoZe.Dominio.ClienteModule.ClienteBase");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.ToTable("TBClientesCNPJ");
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule.ClienteCPF", b =>
                {
                    b.HasBaseType("PastelariaDoZe.Dominio.ClienteModule.ClienteBase");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Cnh")
                        .IsRequired()
                        .HasColumnType("VARCHAR(12)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.HasIndex("ClienteId");

                    b.ToTable("TBClientesCPF");
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule.ClienteCNPJ", b =>
                {
                    b.HasOne("PastelariaDoZe.Dominio.ClienteModule.ClienteBase", null)
                        .WithOne()
                        .HasForeignKey("PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule.ClienteCNPJ", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule.ClienteCPF", b =>
                {
                    b.HasOne("PastelariaDoZe.Dominio.ClienteModule.ClienteCNPJModule.ClienteCNPJ", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("PastelariaDoZe.Dominio.ClienteModule.ClienteBase", null)
                        .WithOne()
                        .HasForeignKey("PastelariaDoZe.Dominio.ClienteModule.ClienteCPFModule.ClienteCPF", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

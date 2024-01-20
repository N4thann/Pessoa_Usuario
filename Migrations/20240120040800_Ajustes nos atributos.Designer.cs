﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PessoaFisica.Data;

#nullable disable

namespace PessoaFisica.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240120040800_Ajustes nos atributos")]
    partial class Ajustesnosatributos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PessoaFisica.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("CEP1")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CEP1");

                    b.Property<string>("CEP2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("CEP2");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("CPF");

                    b.Property<string>("Cidade1")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Cidade1");

                    b.Property<string>("Cidade2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Cidade2");

                    b.Property<string>("Complemento1")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Complemento1");

                    b.Property<string>("Complemento2")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Complemento2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Email");

                    b.Property<string>("Estado1")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Estado1");

                    b.Property<string>("Estado2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Estado2");

                    b.Property<string>("Logradouro1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Logradouro1");

                    b.Property<string>("Logradouro2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Logradouro2");

                    b.Property<string>("Nome")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Nome");

                    b.Property<string>("Nome1")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nome1");

                    b.Property<string>("Nome2")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nome2");

                    b.Property<int?>("Numero1")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasColumnName("Numero1");

                    b.Property<int?>("Numero2")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasColumnName("Numero2");

                    b.Property<string>("RG")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("RG");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Sobrenome");

                    b.Property<string>("TipoContato1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoContato1");

                    b.Property<string>("TipoContato2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoContato2");

                    b.Property<string>("ValorContato1")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ValorContato1");

                    b.Property<string>("ValorContato2")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ValorContato2");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("PessoaFisica.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Email");

                    b.Property<string>("Imagem")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Imagem");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("Telefone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PessoaFisica.Models.Pessoa", b =>
                {
                    b.HasOne("PessoaFisica.Models.Usuario", "Usuario")
                        .WithMany("ListaDePessoas")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PessoaFisica.Models.Usuario", b =>
                {
                    b.Navigation("ListaDePessoas");
                });
#pragma warning restore 612, 618
        }
    }
}

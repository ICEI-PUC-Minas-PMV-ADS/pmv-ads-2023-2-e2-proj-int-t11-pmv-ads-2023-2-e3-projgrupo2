﻿// <auto-generated />
using System;
using EassyDental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EassyDental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231118190243_M01")]
    partial class M01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EassyDental.Models.AgendaEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("HorarioConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioClienteId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioDentistaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioClienteId");

                    b.HasIndex("UsuarioDentistaId");

                    b.ToTable("AgendaEvento");
                });

            modelBuilder.Entity("EassyDental.Models.UsuarioCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuarioCliente");
                });

            modelBuilder.Entity("EassyDental.Models.UsuarioDentista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CRO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Especialidade")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HorarioAbertura")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HorarioEncerramento")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeClinica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsuarioDentista");
                });

            modelBuilder.Entity("EassyDental.Models.AgendaEvento", b =>
                {
                    b.HasOne("EassyDental.Models.UsuarioCliente", "UsuarioCliente")
                        .WithMany("AgendaEventos")
                        .HasForeignKey("UsuarioClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EassyDental.Models.UsuarioDentista", "UsuarioDentista")
                        .WithMany("AgendaEventos")
                        .HasForeignKey("UsuarioDentistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioCliente");

                    b.Navigation("UsuarioDentista");
                });

            modelBuilder.Entity("EassyDental.Models.UsuarioCliente", b =>
                {
                    b.Navigation("AgendaEventos");
                });

            modelBuilder.Entity("EassyDental.Models.UsuarioDentista", b =>
                {
                    b.Navigation("AgendaEventos");
                });
#pragma warning restore 612, 618
        }
    }
}
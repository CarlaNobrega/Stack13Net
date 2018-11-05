﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Slack13Net.Core.Contexts;

namespace Slack13Net.Core.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181105190408_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Slack13Net.Core.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .IsUnicode(false);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new { CategoriaId = 1, Descricao = "javascript" },
                        new { CategoriaId = 2, Descricao = "c#" },
                        new { CategoriaId = 3, Descricao = "jquery" },
                        new { CategoriaId = 4, Descricao = "html" },
                        new { CategoriaId = 5, Descricao = "sql" },
                        new { CategoriaId = 6, Descricao = "asp.net" },
                        new { CategoriaId = 7, Descricao = "asp.net core" },
                        new { CategoriaId = 8, Descricao = "json" }
                    );
                });

            modelBuilder.Entity("Slack13Net.Core.Models.Pergunta", b =>
                {
                    b.Property<int>("PerguntaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("CategoriaId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("Tags")
                        .IsUnicode(false);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("PerguntaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Perguntas");

                    b.HasData(
                        new { PerguntaId = 1, Autor = "Wallace Maxters", CategoriaId = 1, DataCadastro = new DateTime(2018, 11, 5, 17, 4, 8, 565, DateTimeKind.Local), Descricao = "Quanto tento retornar um objeto literal com Arrow Function, dá um erro: <br>var items = [1, 2, 3].map( i => {valor: i, data: new Date() })<br>Como contornar isso no Javascript?", Tags = "javascript,característica-linguagem", Titulo = "Como retornar um objeto literal num arrow function?" },
                        new { PerguntaId = 2, Autor = "Adrian Matheus Fernandez", CategoriaId = 2, DataCadastro = new DateTime(2018, 11, 5, 17, 4, 8, 573, DateTimeKind.Local), Descricao = "É possível reescrever qualquer código em C/C# que use ponteiros de um modo que faça a mesma coisa sem utilizá-los?<br>Meu medo são códigos mais complexos. Os simples eu acredito que não haja dificuldades de se reescrever.<br>Como poderia substituir os ponteiros usando o mesmo conceito em JavaScript?", Tags = "javascript,c#,c++,node.js,ponteiro", Titulo = "É possível reescrever qualquer código que use ponteiros (C#) sem usar ponteiros em Node.js?" }
                    );
                });

            modelBuilder.Entity("Slack13Net.Core.Models.Resposta", b =>
                {
                    b.Property<int>("RespostaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<int>("PerguntaId");

                    b.HasKey("RespostaId");

                    b.HasIndex("PerguntaId");

                    b.ToTable("Respostas");

                    b.HasData(
                        new { RespostaId = 1, Autor = "Jones Araujo", DataCadastro = new DateTime(2018, 11, 5, 17, 4, 8, 573, DateTimeKind.Local), Descricao = "Vixi cara boa pergunta!", PerguntaId = 1 }
                    );
                });

            modelBuilder.Entity("Slack13Net.Core.Models.Pergunta", b =>
                {
                    b.HasOne("Slack13Net.Core.Models.Categoria", "Categoria")
                        .WithMany("Perguntas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Slack13Net.Core.Models.Resposta", b =>
                {
                    b.HasOne("Slack13Net.Core.Models.Pergunta", "Pergunta")
                        .WithMany("Respostas")
                        .HasForeignKey("PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
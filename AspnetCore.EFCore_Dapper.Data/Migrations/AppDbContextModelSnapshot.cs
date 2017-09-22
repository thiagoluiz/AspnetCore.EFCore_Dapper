﻿// <auto-generated />
using AspnetCore.EFCore_Dapper.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspnetCore.EFCore_Dapper.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspnetCore.EFCore_Dapper.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("AspnetCore.EFCore_Dapper.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoPublicacao");

                    b.Property<int>("AutorID");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("AspnetCore.EFCore_Dapper.Domain.Entities.Livro", b =>
                {
                    b.HasOne("AspnetCore.EFCore_Dapper.Domain.Entities.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

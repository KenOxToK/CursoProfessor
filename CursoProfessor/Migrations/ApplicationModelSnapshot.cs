﻿// <auto-generated />
using CursoProfessor.Respository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CursoProfessor.Migrations
{
    [DbContext(typeof(Application))]
    partial class ApplicationModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CursoProfessor.Models.Cursos", b =>
                {
                    b.Property<int>("cursos_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cursos_nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cursos_sala")
                        .HasColumnType("int");

                    b.HasKey("cursos_id");

                    b.ToTable("TabelaDeCursos");
                });

            modelBuilder.Entity("CursoProfessor.Models.Professores", b =>
                {
                    b.Property<int>("professores_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("professores_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("professores_nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("professores_id");

                    b.ToTable("TabelaDeProfessores");
                });
#pragma warning restore 612, 618
        }
    }
}

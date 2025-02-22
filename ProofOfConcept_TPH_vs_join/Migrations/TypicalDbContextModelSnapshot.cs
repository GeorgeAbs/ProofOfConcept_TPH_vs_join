﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProofOfConcept_TPH_vs_2_queries;

#nullable disable

namespace ProofOfConcept_TPH_vs_join.Migrations
{
    [DbContext(typeof(TypicalDbContext))]
    partial class TypicalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("queries_2")
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity21", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("EntityTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("F12")
                        .HasColumnType("integer");

                    b.Property<int>("F13")
                        .HasColumnType("integer");

                    b.Property<int>("F14")
                        .HasColumnType("integer");

                    b.Property<int>("F15")
                        .HasColumnType("integer");

                    b.Property<int>("F16")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entities21", "queries_2");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity22", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("EntityTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("F22")
                        .HasColumnType("integer");

                    b.Property<int>("F23")
                        .HasColumnType("integer");

                    b.Property<int>("F24")
                        .HasColumnType("integer");

                    b.Property<int>("F25")
                        .HasColumnType("integer");

                    b.Property<int>("F26")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entities22", "queries_2");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity23", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("EntityTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("F32")
                        .HasColumnType("integer");

                    b.Property<int>("F33")
                        .HasColumnType("integer");

                    b.Property<int>("F34")
                        .HasColumnType("integer");

                    b.Property<int>("F35")
                        .HasColumnType("integer");

                    b.Property<int>("F36")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entities23", "queries_2");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity24", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("EntityTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("F42")
                        .HasColumnType("integer");

                    b.Property<int>("F43")
                        .HasColumnType("integer");

                    b.Property<int>("F44")
                        .HasColumnType("integer");

                    b.Property<int>("F45")
                        .HasColumnType("integer");

                    b.Property<int>("F46")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entities24", "queries_2");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.EntityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("EntityTypes", "queries_2");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity21", b =>
                {
                    b.HasOne("ProofOfConcept_TPH_vs_2_queries.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityType");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity22", b =>
                {
                    b.HasOne("ProofOfConcept_TPH_vs_2_queries.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityType");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity23", b =>
                {
                    b.HasOne("ProofOfConcept_TPH_vs_2_queries.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityType");
                });

            modelBuilder.Entity("ProofOfConcept_TPH_vs_2_queries.Entities.Entity24", b =>
                {
                    b.HasOne("ProofOfConcept_TPH_vs_2_queries.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityType");
                });
#pragma warning restore 612, 618
        }
    }
}

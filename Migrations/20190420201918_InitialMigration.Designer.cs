﻿// <auto-generated />
using System;
using Election10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Election10.Migrations
{
    [DbContext(typeof(AplicationContext))]
    [Migration("20190420201918_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Election10.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CitizensId");

                    b.Property<int>("ElectionId");

                    b.Property<int>("NumberInTheList");

                    b.HasKey("Id");

                    b.HasIndex("CitizensId");

                    b.HasIndex("ElectionId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Election10.Models.ChairmanCC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CitizensId");

                    b.Property<int>("ElectionId");

                    b.Property<int>("VirtualCantonId");

                    b.HasKey("Id");

                    b.HasIndex("CitizensId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("VirtualCantonId");

                    b.ToTable("ChairmanCCs");
                });

            modelBuilder.Entity("Election10.Models.CharmanDC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CitizensId");

                    b.Property<int>("ElectionId");

                    b.Property<int>("VirtualCantonId");

                    b.HasKey("Id");

                    b.HasIndex("CitizensId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("VirtualCantonId");

                    b.ToTable("CharmanDCs");
                });

            modelBuilder.Entity("Election10.Models.Citizens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PIN");

                    b.HasKey("Id");

                    b.ToTable("Citizenses");
                });

            modelBuilder.Entity("Election10.Models.Election", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChairmanCC");

                    b.Property<DateTime>("EndElection");

                    b.Property<DateTime>("StartElection");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Elections");
                });

           

            modelBuilder.Entity("Election10.Models.VirtualCanton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Centre");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("VirtualCantons");
                });

            modelBuilder.Entity("Election10.Models.VirtualDistrict", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Title");

                    b.Property<int>("VirtualCantonId");

                    b.HasKey("Id");

                    b.ToTable("VirtualDistricts");
                });

            modelBuilder.Entity("Election10.Models.Voice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CandidatId");

                    b.Property<int?>("CandidateId");

                    b.Property<int>("CitizensId");

                    b.Property<int>("ElectionId");

                    b.Property<int>("VirtualCantonId");

                    b.Property<int>("VirtualDistrictId");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("CitizensId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("VirtualCantonId");

                    b.HasIndex("VirtualDistrictId");

                    b.ToTable("Voices");
                });

            modelBuilder.Entity("Election10.Models.Candidate", b =>
                {
                    b.HasOne("Election10.Models.Citizens", "Citizens")
                        .WithMany()
                        .HasForeignKey("CitizensId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.Election", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Election10.Models.ChairmanCC", b =>
                {
                    b.HasOne("Election10.Models.Citizens", "Citizens")
                        .WithMany()
                        .HasForeignKey("CitizensId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.Election", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.VirtualCanton", "VirtualCanton")
                        .WithMany()
                        .HasForeignKey("VirtualCantonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Election10.Models.CharmanDC", b =>
                {
                    b.HasOne("Election10.Models.Citizens", "Citizens")
                        .WithMany()
                        .HasForeignKey("CitizensId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.Election", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.VirtualCanton", "VirtualCanton")
                        .WithMany()
                        .HasForeignKey("VirtualCantonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Election10.Models.Voice", b =>
                {
                    b.HasOne("Election10.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId");

                    b.HasOne("Election10.Models.Citizens", "Citizens")
                        .WithMany()
                        .HasForeignKey("CitizensId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.Election", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.VirtualCanton", "VirtualCanton")
                        .WithMany()
                        .HasForeignKey("VirtualCantonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Election10.Models.VirtualDistrict", "GetVirtualDistrict")
                        .WithMany()
                        .HasForeignKey("VirtualDistrictId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

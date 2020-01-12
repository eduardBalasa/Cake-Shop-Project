﻿// <auto-generated />
using System;
using CakeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CakeShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190730125341_TransactionFields")]
    partial class TransactionFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CakeShop.Models.Cake", b =>
                {
                    b.Property<int>("CakeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageName");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("CakeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cakes");

                    b.HasData(
                        new { CakeId = 1, CategoryId = 1, Description = "In nuante pastelate, ghirlanda de trandafiri cu care am decorat acest tort de nunta ii confera o nota de eleganta si rafinament. Perlele si brosa sunt cateva din detaliile mici delicate si elegante.", ImageName = "TortGhirlandaDeTrandafiri.jpg", Name = "Ghirlanda de trandafiri", Price = 500m },
                        new { CakeId = 2, CategoryId = 1, Description = "Un tort de nunta pe care am ales sa il decoram cu o cascada de fluturi in degradee de mov, iar deasupra au fost asezati cei doi miri realizati manual.", ImageName = "FluturiInDegradee.jpg", Name = "Fluturi in Degradee", Price = 700m },
                        new { CakeId = 3, CategoryId = 2, Description = "Flavia Maria a avut parte de un tort de botez pe masura petrecerii. Decorat cu detalii in nuante de roz pastel si alb, o luna instelata si insertii aurite, tortul cu o compozitie usoara si fructata, a facut deliciul invitatilor aflati la petrecere.", ImageName = "LunaRoz.jpg", Name = "Luna Roz", Price = 400m },
                        new { CakeId = 4, CategoryId = 2, Description = "Tort de botez pentru baieti cu doua etaje, realizat in pasteluri bleu si argintii, asemenea celui din imagine. Alege compozitia preferata si lasa-i pe designerii nostri sa transforme tortul intr-o poveste magica!", ImageName = "LunaAlbastra.jpg", Name = "Luna Albastra", Price = 450m },
                        new { CakeId = 5, CategoryId = 3, Description = "Iata un desert ciocolatos si pufos ! Briosele au o aroma intensa de ciocolata si fi servite alaturi de o cafea.", ImageName = "BrioseCuCiocolata.jpg", Name = "Briose cu Ciocolata", Price = 50m },
                        new { CakeId = 6, CategoryId = 3, Description = "Produs de cofetărie de origine franceză, realizat din pudra de migdale, avand la mijloc o cremă deosebită.", ImageName = "MacaronsChristmasTree.jpg", Name = "Macarons Christmas Tree", Price = 80m },
                        new { CakeId = 7, CategoryId = 4, Description = "Prajituri delicioase preparate pe un blat alb pufos, bine insiropat, avand un strat de crema de ciocolata alba si lamaie. Sunt finisate cu fondant, in diverse culori.", ImageName = "MiniAmandine.jpg", Name = "Mini Amandine", Price = 30m },
                        new { CakeId = 8, CategoryId = 4, Description = "Mini eclere –  sunt preparate din aluat oparit si pufos, cu o cremă delicioasa de ciocolata, acoperite cu o crustă bogată de fondant.", ImageName = "MiniEclere.jpg", Name = "MiniEclere", Price = 40m }
                    );
                });

            modelBuilder.Entity("CakeShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, Name = "Torturi Nunta" },
                        new { CategoryId = 2, Name = "Torturi Botez" },
                        new { CategoryId = 3, Name = "Candy Bar" },
                        new { CategoryId = 4, Name = "Deserturi" }
                    );
                });

            modelBuilder.Entity("CakeShop.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CakeId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email");

                    b.HasKey("ReviewId");

                    b.HasIndex("CakeId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CakeShop.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("CakeShop.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Buyer");

                    b.Property<int>("CakeId");

                    b.Property<int>("Quantity");

                    b.HasKey("TransactionId");

                    b.HasIndex("CakeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CakeShop.Models.Cake", b =>
                {
                    b.HasOne("CakeShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CakeShop.Models.Review", b =>
                {
                    b.HasOne("CakeShop.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CakeShop.Models.Transaction", b =>
                {
                    b.HasOne("CakeShop.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

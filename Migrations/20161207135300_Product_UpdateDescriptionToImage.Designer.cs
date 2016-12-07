using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Inventory.Models;

namespace inventorydemo.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20161207135300_Product_UpdateDescriptionToImage")]
    partial class Product_UpdateDescriptionToImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventory.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("costPrice");

                    b.Property<double>("sellingPrice");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });
        }
    }
}

using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CPRG214.Assets.Data
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code that will contain the entity framework
    * references and the content used to create the database
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetsContext : DbContext
    {

        public AssetsContext() : base() { }
        //database table for assets
        public DbSet<Asset> Assets { get; set; }
        //database table for asset types
        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder assetConnection)
        {
            //sql server connection string
            assetConnection.UseSqlServer(@"Server=localhost\sqlexpress;
                                          Database=Assets;
                                          Trusted_Connection=True;");
        }
        //method that will create records in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data created here
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1, Name = "Computer" },
                new AssetType { Id = 2, Name = "Monitor" },
                new AssetType { Id = 3, Name = "Phone" }
                );
                 

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    TagNumber = "59T2V22",
                    Manufacturer = "Dell",
                    Model = "Inspiron",
                    Description = "Laptop 16gb ram",
                    SerialNumber = "K47839J999",
                    AssetTypeId = 1
                    
                },
                new Asset
                {
                    Id = 2,
                    TagNumber = "VN7591G",
                    Manufacturer = "Acer",
                    Model = "Aspire",
                    Description = "Desktop 16GB ram",
                    SerialNumber = "NXMQLLAAA0054",
                    AssetTypeId = 1
                },
                new Asset
                {
                    Id = 3,
                    TagNumber = "GH7591G-23",
                    Manufacturer = "Acer",
                    Model = "Nitro",
                    Description = "Full HD Gaming",
                    SerialNumber = "ADLKNNE009AFD883-1",
                    AssetTypeId = 2
                },
                new Asset
                {
                    Id = 4,
                    TagNumber = "GH7591G-23",
                    Manufacturer = "LG",
                    Model = "UltraFine",
                    Description = "UHD 4K",
                    SerialNumber = "KJHEFNG0067-55",
                    AssetTypeId = 2
                },

                new Asset
                {
                    Id = 5,
                    TagNumber = "J7J7M28",
                    Manufacturer = "Cisco",
                    Model = "8845 VoIP",
                    Description = "High-Fidelity and Secure",
                    SerialNumber = "ADFJ8AEEF000000JU88",
                    AssetTypeId = 3
                },
                new Asset
                {
                    Id = 6,
                    TagNumber = "7m3LKUE8890-1",
                    Manufacturer = "Polycom",
                    Model = "VVX601 IP",
                    Description = "Videoconference ready desktop",
                    SerialNumber = "LKJEI00001",
                    AssetTypeId = 3
                }
                );
        }
    }
}

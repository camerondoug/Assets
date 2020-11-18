using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPRG214.Assets.Domain
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the asset domain class
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    [Table("Asset")]
    public class Asset
    {
        [Required]  //anything with required will be not null in the database
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Serial Number")]  //set the display format for headings
        public string SerialNumber { get; set; }

        [Display(Name = "Asset Type")]
        public int AssetTypeId { get; set; }

        public AssetType AssetType { get; set; }

    }
}

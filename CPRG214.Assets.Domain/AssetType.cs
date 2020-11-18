using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPRG214.Assets.Domain
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the asset type domain class
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        //navigation property
        public ICollection<Asset> Assets { get; set; }
    }
}

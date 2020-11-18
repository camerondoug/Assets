using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPRG214.Assets.Tracking.Models
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the asset view model
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetViewModel
    {
        //[Required]
        public int Id { get; set; }

        public string TagNumber { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Asset Type")]
        public string AssetType { get; set; }
    }

}

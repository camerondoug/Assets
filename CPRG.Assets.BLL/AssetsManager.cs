using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CPRG.Assets.BLL
{   /*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the asset database operations
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetsManager
    {
        //method to get all asset from the database and return them as a list
        public static List<Asset> GetAll()
        {
            var context = new AssetsContext();
            var assets = context.Assets.Include(rp => rp.AssetType)
                .ToList();
            return assets;
        }
        //method to get all assets from the database by type of asset and return
        //as a list
        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetsContext();
            var assets = context.Assets.
                Where (a => a.AssetTypeId == id). //get the asset for the id past to method
                Include(rp => rp.AssetType)//get the assets type for dropdown
                .ToList();
            return assets;
        }
        //method that adds a new asset to the database
        public static void Add(Asset asset)
        {
            var context = new AssetsContext();
            context.Assets.Add(asset); //add the asset to the context
            context.SaveChanges(); //save changes to the database
        }
    }

}

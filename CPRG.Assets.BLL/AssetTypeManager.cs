using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CPRG214.Assets.BLL
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the asset types database operations
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetTypeManager
    {
        //method to get all asset types from the datbase and return them as a list
        public static List<AssetType> GetAll()
        {
            var context = new AssetsContext();
            var assetTypes = context.AssetTypes.Include(rp => rp).ToList();
            return assetTypes;
        }
        //method to get all asset types from the database and assign to key value pairs
        //and return as a list
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetsContext();
            var types = context.AssetTypes.Select(t => new
            {
                Value = t.Id,  //value will be the id
                Text = t.Name  //text will be the asset type
            }).ToList();
            return types;
        }
        //method that adds a new asset type to the database
        public static void Add(AssetType assetType)
        {
            var context = new AssetsContext();
            context.AssetTypes.Add(assetType);//add the asset to the context
            context.SaveChanges();//save changes to the database
        }
    }
    
}

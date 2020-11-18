using CPRG.Assets.BLL;
using CPRG214.Assets.Domain;
using CPRG214.Assets.Tracking.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPRG214.Assets.Tracking.ViewComponents
{   /*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the assets view component
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetsByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            List<Asset> assets = null;

            if (id == 0)
            {
                assets = AssetsManager.GetAll();  //if there is no id yet, get all assets
            }
            else
            {       //if there is an id from dropdown, then get only those asset types
                assets = AssetsManager.GetAllByAssetType(id);
            }

            //create and return the new asset view model
            var newAsset = assets.Select(a => new AssetViewModel

            {
                Id = a.Id,
                Model = a.Model,
                Description = a.Description,
                SerialNumber = a.SerialNumber,
                TagNumber = a.TagNumber,
                AssetType = a.AssetType.Name

            }).ToList();

            return View(newAsset);
        }
    }
}

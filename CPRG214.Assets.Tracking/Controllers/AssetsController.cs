using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG.Assets.BLL;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;
using CPRG214.Assets.Tracking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CPRG214.Assets.Tracking.Controllers
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the assets controller
    * Author: Doug Cameron
    * Date: Aug, 2020
    */
    public class AssetsController : Controller
    {   
        //method to create the view for the assets
        public IActionResult Index()
        {
            //call to the assets manager class to get a list of all assets
            //and create a new assets view model
            var assets = AssetsManager.GetAll();
            var viewModels = assets.Select(a => new AssetViewModel
            {
                Id = a.Id,
                Model = a.Model,
                Description = a.Description,
                SerialNumber = a.SerialNumber,
                TagNumber = a.TagNumber,
                AssetType = a.AssetType.Name
            })
            .ToList();

            return View(viewModels);
        }
        //method that calls asset manager to get all the assets filtered
        //per type
        public IActionResult Search()
        {
            ViewBag.AssetTypes = GetAssetTypes();
            return View();
        }
   

        //method to create the collection of asset types select list items
        public IActionResult Create()
        {
            
            ViewBag.AssetTypeId = GetAssetTypes();

            return View();
        }

        //method that handles the form for creating a new asset
        [HttpPost]
        public IActionResult Create(Asset asset)
        {

            try
            {
                AssetsManager.Add(asset);  // call the method to add the info to the database
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        //method to get the asset types as a key value pair
        //and return as a list to use in the types drop down list
        protected IEnumerable GetAssetTypes()
        {
            var types = AssetTypeManager.GetAsKeyValuePairs(); // call the asset type manager
            var typesList = new SelectList(types, "Value", "Text");
            
            var list = typesList.ToList();
            list.Insert(0, new SelectListItem //insert a new default list item for dropdown list
            {
                Text = "All Types",
                Value = "0"

            });

            return list;
        }

        //method that will return the partial view of the asset types
        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }
    }
}

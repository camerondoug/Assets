using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG.Assets.BLL;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;
using CPRG214.Assets.Tracking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPRG214.Assets.Tracking.Controllers
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the assets types controller
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class AssetTypeController : Controller
    {

        //method to create the view for the asset types
        public IActionResult Index()
        {
            //call to the assets types manager class to get a list of all asset types
            //and create a new asset type view model
            var assets = AssetTypeManager.GetAll();
            var viewModels = assets.Select(a => new AssetTypeViewModel
            {
                
                Name = a.Name
            })
            .ToList();

            return View(viewModels);
        }

        //method that return the view to create a new asset type
        public IActionResult Create()
        {
            return View();
        }
        //method that handles the form for creating a new asset type from the form
        [HttpPost]
        public IActionResult Create(AssetType asset)
        {

            try
            {
                AssetTypeManager.Add(asset);  // call the add method from manager
                return RedirectToAction("Index");//redirect back to list of asset types
            }
            catch
            {
                return View();
            }

        }
    }

}

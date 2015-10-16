using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using LaptopListingSystem.Data;
using LaptopListingSystem.Web.Models.Home;
using AutoMapper.QueryableExtensions;

namespace LaptopListingSystem.Web.Controllers
{
    public class HomeController : BaseController
    {


        public HomeController(ILaptopListingSystemData data)
            : base(data)
        { }
        
        public ActionResult Index()
        {
            var laptops = this.Data.Laptops.All()
                .OrderByDescending(l => l.Votes.Count())
                .Take(6)
                .Select(v => new LaptopViewModels
                {
                    Id = v.Id,
                    Manufacturer = v.Manufacturer.Name,
                    Model = v.Model,
                    Price = v.Price,
                    Image = v.Image
                });
                                
            return View(laptops);
        }        
    }
}
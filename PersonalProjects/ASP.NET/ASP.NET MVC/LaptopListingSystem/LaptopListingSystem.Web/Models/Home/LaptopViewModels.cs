namespace LaptopListingSystem.Web.Models.Home
{
    using System;
    using AutoMapper;

    using LaptopListingSystem.Models;
    using LaptopListingSystem.Web.Infrastructure.Mapping;

    public class LaptopViewModels
    {
        //manufacturer, model, image and price.
        public int Id { get; set; }

        public string Manufacturer { get; set; }
        
        public string Model { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }        
    }
}
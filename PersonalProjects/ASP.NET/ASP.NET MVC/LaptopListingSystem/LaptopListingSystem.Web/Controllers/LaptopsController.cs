namespace LaptopListingSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;

    using LaptopListingSystem.Data;
    using LaptopListingSystem.Models;
    using LaptopListingSystem.Web.Models.Laptops;
    using LaptopListingSystem.Web.Models.Comments;

    public class LaptopsController : BaseController
    {
        public LaptopsController(ILaptopListingSystemData data)
            : base(data)
        {

        }

        // GET: Laptops
        public ActionResult Details(int id)
        {
            var currentUserId = User.Identity.GetUserId();
            var laptop = this.Data.Laptops.All()
                .Where(l => l.Id == id)
                .Select(l => new LaptopDetailsViewModel
                {
                    Id = l.Id,
                    Manufacturer = l.Manufacturer.Name,
                    Model = l.Model,
                    ScreenSize = l.ScreenSize,
                    Ram = l.Ram,
                    HardDisk = l.HardDisk,
                    Weight = l.Weight,
                    Image = l.Image,
                    Description = l.Description,
                    Price = l.Price,
                    Comments = l.Comments.Select(c => new CommentViewModel
                    {
                        AuthorUserName = c.User.UserName,
                        Content = c.Content
                    }),
                    Votes = l.Votes.Count(),
                    UserVoteAuthorization = !l.Votes.Any(vote => vote.UserId == currentUserId)
                })
                .FirstOrDefault();

            return View(laptop);
        }

        public ActionResult Vote(int id)
        {
            var currentUserId = User.Identity.GetUserId();
            var userVoteAuthorization = !this.Data.Votes.All().Any(vote => vote.LaptopId == id && vote.UserId == currentUserId);

            if (userVoteAuthorization)
            {
                this.Data.Laptops.GetById(id).Votes.Add(new Vote
                {
                    LaptopId = id,
                    UserId = currentUserId
                });

                this.Data.SaveChanges();
            }

            var votes = this.Data.Laptops.GetById(id).Votes.Count();

            return Content(votes.ToString());
        }
    }
}
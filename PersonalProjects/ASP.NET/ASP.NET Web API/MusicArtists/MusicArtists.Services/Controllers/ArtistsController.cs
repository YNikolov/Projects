

namespace MusicArtists.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using MusicArtists.Data;
    using MusicArtists.Data.Repositories;
    using MusicArtists.Data.UoW;
    using MusicArtists.Data.Interfaces;
    using MusicArtists.Model;
    using MusicArtists.Services.Models;

    public class ArtistsController : ApiController
    {
        private IMusicArtistsData data;

        public ArtistsController()
            : this(new MusicArtistsData())
        { }

        public ArtistsController(IMusicArtistsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artists = this.data.Artists
                .All()
                .Select(CoverModel.FromCover);

            return Ok(artists);
        }
               
        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artist = this.data.Artists
                .All()
                .Where(a => a.Id == id)
                .Select(ArtistModel.FromArtist)
                .FirstOrDefault();
            
            this.CheckIfExist(artist, "Artist");

            return Ok(artist);
        }

        [HttpGet]
        public IHttpActionResult ByName(string inputArtist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artist = this.data.Artists
                .All()
                .Where(a => a.Name == inputArtist)
                .Select(ArtistModel.FromArtist)
                .FirstOrDefault();
            
            this.CheckIfExist(artist, "Artist");

            return Ok(artist);
        }

        [HttpPost]
        public IHttpActionResult CreateArtist([FromUri]Artist artist) // TODO Check for solution to get the data from the body(see createArtist in service file && html file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }          

            var newArtist = this.data.Artists
                .All()
                .FirstOrDefault(a => a.Name == artist.Name);
            if (newArtist != null)
            {
                return BadRequest("Such Artist already exist!");
            }
            
            this.data.Artists.Add(artist);
            this.data.SaveChanges();

            return Ok(artist);
        }

        [HttpPost]    //TODO  check for existing album in artist before adding
        public IHttpActionResult AddAlbum(string artist, string album)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingArtist = this.data.Artists
                    .All()
                    .FirstOrDefault(a => a.Name == artist);

            this.CheckIfExist(existingArtist, "Artist");
            
            var existingAlbum = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Name == album);

            this.CheckIfExist(existingAlbum, "Album");


            existingArtist.Albums.Add(existingAlbum);

            this.data.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artist = this.data.Artists
                .All()
                .FirstOrDefault(a => a.Id == id);
            
            this.CheckIfExist(artist, "Artist");
                       
            this.data.Artists.Delete(artist);

            this.data.SaveChanges();

            return Ok();
        }

        [HttpDelete]   //     TODO
        public IHttpActionResult ByIdRange(int startRange, int endRange)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            
            //  TODO not working find another solution
                                
            
            var artists = this.data.Artists.All()
                .Where(a => a.Id > startRange && a.Id < endRange)
                //.OrderBy(a => a.Id)
                //.Skip(startRange)
                //.Take(endRange)
                .Select(a => a);

            //for (int i = 0; i < endRange ; i++)
            //{
            //     this.data.Artists.Delete(artists[i]);
            //}


            //foreach (var art in artists)
            //{
            //    this.data.Artists.Delete(art);                
            //}

            //this.data.Artists.Delete(artists);
            this.data.SaveChanges();

            return Ok();
        }
        [HttpPost]    
        public IHttpActionResult UpdateById(int id, ArtistModel newArtist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artist = this.data.Artists.All()
                .FirstOrDefault(a => a.Id == id);
            
            artist.Name = newArtist.Name;
            artist.Country = newArtist.Country;
            artist.ImageUrl = newArtist.ImageUrl;

            this.data.Artists.Update(artist);

            this.data.SaveChanges();
            
            newArtist.ArtistId = id;
            
            return Ok(newArtist);
        }

        private void CheckIfExist(object obj, string objectName)
        {
            if (obj == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = "Such " + objectName + " does not exist!"
                });
            }

        }        
    }
}

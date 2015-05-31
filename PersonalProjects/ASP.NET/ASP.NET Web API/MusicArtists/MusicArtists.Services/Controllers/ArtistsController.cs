

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

        //[HttpGet]
        //public IHttpActionResult ByCount()
        //{
        //    var artists = this.data.Artists.All().Count();
        //}
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
            
            this.CheckIfExist(artist);

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
            
            this.CheckIfExist(artist);

            return Ok(artist);
        }

        [HttpPost]
        public IHttpActionResult CreateArtist([FromUri]Artist artist) // TODO Check for solution to get the data from the body(see createArtist in service file && html file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }          

            this.data.Artists.Add(artist);
            this.data.SaveChanges();

            return Ok(artist);
        }

        [HttpPost]
        public IHttpActionResult AddAlbum(int id, int albumId)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var artist = this.data.Artists
            //        .All()
            //        .FirstOrDefault(a => a.Id == id);
            
            //this.CheckIfExist(artist);

            var album = this.data.Albums
                .All()
                .FirstOrDefault(al => al.Id == albumId);

            this.CheckIfExist(album);

            album.ArtistId = id;

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
            
            this.CheckIfExist(artist);
            //var artistAlbums = this.data.Albums.All().Where(a => a.ArtistId == id);
            //var albumId = this.data.Albums.All().Where()
            //var albumSongs = this.data.Songs.All().Where(artistAlbums.Contains(); 

            //foreach (var alb in artistAlbums)
            //{
            //    this.data.Albums.Delete(alb);
            //}
            
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
        private void CheckIfExist(object obj)
        {
            if (obj == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)
               {
                   ReasonPhrase = "Such Artist does not exist!"
               });
            }

        }
    }
}

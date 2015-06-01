
namespace MusicArtists.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.ComponentModel.DataAnnotations;

    using MusicArtists.Data;
    using MusicArtists.Data.Repositories;
    using MusicArtists.Data.UoW;
    using MusicArtists.Data.Interfaces;
    using MusicArtists.Model;
    using MusicArtists.Services.Models;

    //using MusicArtists.Model;
    public class AlbumsController : ApiController
    {
        private IMusicArtistsData data;

        public AlbumsController()
            : this(new MusicArtistsData())
        { }

        public AlbumsController(IMusicArtistsData data)
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

            var albums = this.data.Albums
                .All()
                .Select(CoverModel.FromCover);
             
            return Ok(albums);
        }

        [HttpGet]
        public IHttpActionResult ByAlbumsName([FromUri]string albName)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Name == albName);

            if (album == null)
            {
                return BadRequest("Such Album does not exist!");

            }

            return Ok(album);
        }
        [HttpGet] // TODO
        public IHttpActionResult ArtistId([FromUri]int id)
        {                
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var albums = this.data.Albums
                .All()
                .Where(al => al.ArtistId == id)
                .Select(CoverModel.FromCover);

            return Ok(albums);
        }

        [HttpGet]
        public IHttpActionResult ByArtist(string artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingArtist = this.data.Artists
                .All()
                .FirstOrDefault(a => a.Name == artist);


            var albums = this.data.Albums
                .All()
                .Where(al => al.ArtistId == existingArtist.Id)
                .Select(CoverModel.FromCover);

            return Ok(albums);
        }
        [HttpPost]
        public IHttpActionResult Create([FromUri]AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAlbum = new Album
            {                
                Name = album.Name,
                Genre = album.Genre,
                ImageUrl = album.ImageUrl,
                Producer = album.Producer,
                ArtistId = album.ArtistId
            };

            this.data.Albums.Add(newAlbum);

            this.data.SaveChanges();
            album.Id = newAlbum.Id;

            return Ok(album);
        }

        [HttpPost]    //     TODO
        public IHttpActionResult UpdateByName(string name, Album newAlbum)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Name == name);
 
            if (album == null)
            {
                return BadRequest("Such Album does not exist");
            }

            album.Name = newAlbum.Name;
            album.Producer = newAlbum.Producer;
            album.Genre = newAlbum.Genre;
            album.ImageUrl = newAlbum.ImageUrl;
            album.Songs = newAlbum.Songs;   
            

            this.data.Albums.Update(album);
            this.data.SaveChanges();

            newAlbum.Id = album.Id;
            return Ok(newAlbum);
            
        }

        [HttpPost]     //     TODO
        public IHttpActionResult UpdateByid(int id, int idAl, string name)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var existingAlbum = this.data.Albums.All()
            //    .FirstOrDefault(a => a.Id == id);

            var tt = this.data.Artists.All()
                .FirstOrDefault(a => a.Id == id).Albums.Any(al => al.Name == name);
            //tt.Albums.Add(newAlbum);
            var del = this.data.Artists.All()
                .FirstOrDefault(a => a.Id == id).Albums;
            //del.Remove(del.Remove(tt));
           //var art = this.data.Artists.Add(tt.Albums.Add(newAlbum);
            //var art = this.data.Artists.All()
            //    .Select(ArtistModel.FromArtist);
                
                

            //var oldArtist = existingAlbum.ArtistId;
//            this.data.Artists.Detach(existingAlbum);
            //id na artist,detach albmid in artist.albums




            //var album = new Album
            //{
            //    Id = ne
            //}
            //var album = this.data.Albums
            //    .All()
            //    .FirstOrDefault(a => a.Id == id);

            //if (album == null)
            //{
            //    return BadRequest("Such Album does not exist");
            //}
            
            //album.Id = id;
            //album.Name = newAlbum.Name;
            //album.Genre = newAlbum.Genre;
            ////artist.Select(a => a.Albums
            ////artist.

            //album.ArtistId = newAlbum.ArtistId;
            //album.Artist = newAlbum.Artist;
            //album.ImageUrl = newAlbum.ImageUrl;
            


            //this.data.Albums.Update(album);
            //this.data.SaveChanges();
            //newAlbum.Id = id;
            //newAlbum.Id = album.Id;

            return Ok();
        }
        [HttpPost]
        public IHttpActionResult AddSong(string albName, string songName)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums
                .All()
                .FirstOrDefault(a => a.Name == albName);

            this.CheckIfExist(album, "Album");

            var song = this.data.Songs
                .All()
                .FirstOrDefault(s => s.Name == songName);

            this.CheckIfExist(song, "Song");

            album.Songs.Add(song);

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

            var album = this.data.Albums.
                All()
                .FirstOrDefault(a => a.Id == id);

            this.data.Albums.Delete(album);

            this.data.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ByName(string name)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums.
                All()
                .FirstOrDefault(a => a.Name == name);

            this.data.Albums.Delete(album);

            this.data.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ByArtistId(int artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums.
                All()
                .Where(a => a.ArtistId == artist);

            foreach (var al in album)
        	{
		         this.data.Albums.Delete(al);
	        }
            
            this.data.SaveChanges();

            return Ok();
        }

        //     TODO  Change Artist...
        [HttpPut]
        public IHttpActionResult ChangeAlbumsArtistById(string albumName, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.data.Albums.All()
                .FirstOrDefault(s => s.Name == albumName);

            if (album == null)
            {
                return BadRequest("The Album does not exist!");
            }

            var existingArtist = this.data.Artists
                .All()
                .Where(a => a.Id == id)
                .FirstOrDefault();

            if (existingArtist == null)
            {
                return BadRequest("Such Artist does not exist!");
            }

            album.ArtistId = id;
            this.data.Albums.Update(album);
            this.data.SaveChanges();

            return Ok();
        }

        //[HttpPut] TODO
        //public IHttpActionResult ChangeAlbumsArtistByName(string albName, string artistName)
        //{
        //    if (!this.ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var album = this.data.Albums.All()
        //        .FirstOrDefault(s => s.Name == albName);

        //    if (album == null)
        //    {
        //        return BadRequest("The Album does not exist!");
        //    }

        //    var existingArtist = this.data.Artists
        //        .All()
        //        .Where(a => a.Name == artistName)
        //        .FirstOrDefault();

        //    if (existingArtist == null)
        //    {
        //        return BadRequest("Such Artist does not exist!");
        //    }
        //    existingArtist.Albums.Add(album);
        //    this.data.Artists.Update(existingArtist);
        //    //album.Artist.Name = artistName;
        //    //this.data.Albums.Update(album);
        //    this.data.SaveChanges();

        //    return Ok();
        //}
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

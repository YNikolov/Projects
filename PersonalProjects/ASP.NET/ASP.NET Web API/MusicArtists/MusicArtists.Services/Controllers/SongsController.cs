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
    using MusicArtists.Model;
    using MusicArtists.Data.UoW;
    using MusicArtists.Data.Interfaces;
    using MusicArtists.Services.Models;
    public class SongsController : ApiController
    {
        private IMusicArtistsData data;

        public SongsController()
            : this(new MusicArtistsData())
        { }

        public SongsController(IMusicArtistsData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var songs = this.data.Songs
                .All()
                .Select(CoverModel.FromCover);

            return Ok(songs);
        }

        [HttpPost]
        public IHttpActionResult CreateSong([FromUri]Song song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingSong = this.data.Songs
                .All()
                .FirstOrDefault(s => s.Name == song.Name);

            if (existingSong != null)
            {
                return BadRequest("The Song, already exist!");
            }

            this.data.Songs.Add(song);
            this.data.SaveChanges();

            return Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult ByName(string name)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var song = this.data.Songs
                .All()
                .FirstOrDefault(s => s.Name == name);

            if(song == null)
            {
                return BadRequest("The Song does not exist");
            }

            this.data.Songs.Delete(song);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ByAlbumName(string albName)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var songs = this.data.Songs
                .All()
                .Where(s => s.Album.Name == albName)
                .Select(CoverModel.FromCover);

            return Ok(songs);
        }

        [HttpPost]
        public IHttpActionResult ChangeSongsAlbum(string name, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var song = this.data.Songs.All()
                .FirstOrDefault(s => s.Name == name);

            if (song == null)
            {
                return BadRequest("The Song does not exist!");
            }

            var existingAlbum = this.data.Albums
                .All()
                .Where(album => album.Id == id)
                .FirstOrDefault();

            if (existingAlbum == null)
            {
                return BadRequest("Such Album does not exist!");
            }

            song.AlbumId = id;

            this.data.SaveChanges();

            return Ok();
        }
    }
}

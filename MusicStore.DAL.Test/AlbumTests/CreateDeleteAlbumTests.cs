using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.AlbumTests
{
    [TestClass]
    public class CreateDeleteAlbumTests : BaseTest
    {
        private int createdAlbumId;

        private IRepository<Album> repository;

        public CreateDeleteAlbumTests()
        {
            this.repository = new AlbumRepository(this.dbContext);
        }
        
        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var album = this.repository.GetById(createdAlbumId);
                if (album != null)
                {
                    this.repository.Remove(album.Id);
                }
            }
            catch { }
        }
        [TestMethod]
        public void Create_ValidEntity_ShouldCreateAlbum()
        {
            // Arrange
            var album = new Album
            {
                Name = "Butterfly",
                Price = 40,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                ArtistId = 4,
                Tracks = new List<Track>()
                {
                    new Track
                    {
                        Name = "my all",
                        Duration = 3.51f,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        GenreId = 4,
                    },
                    new Track
                    {
                        Name = "close my eyes",
                        Duration = 4.20f,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        GenreId = 4,
                    }
                }
            };

            // Act
            this.repository.Create(album);
            this.createdAlbumId = album.Id;

            var insertedAlbum = this.repository.GetById(album.Id);

            // Assert
            Assert.IsNotNull(insertedAlbum);
            Assert.AreEqual("Butterfly", insertedAlbum.Name);
            Assert.AreEqual(40, insertedAlbum.Price);
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Create_InvalidEntityWithNoLogin_ShouldNotCreatAlbum()
        {
            // Arrange & Act & Assert
            this.repository.Create(new Album
            {
                Name = "Sun"
            });
        }
    }
}

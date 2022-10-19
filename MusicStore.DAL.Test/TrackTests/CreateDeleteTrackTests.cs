using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.TrackTests
{
    [TestClass]
    public class CreateDeleteTrackTests : BaseTest
    {
        private int createdTrackId;

        private ITrackRepository repository;

        public CreateDeleteTrackTests()
        {
            this.repository = new TrackRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var track = this.repository.GetById(createdTrackId);
                if (track != null)
                {
                    this.repository.Remove(track.Id);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Add_ValidEntity_ShouldAddTrack()
        {
            // Arrange
            var track = new Track
            {
                Name = "my all",
                Duration = 3.51f,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                GenreId = 4,
                AlbumId = 9
            };

            // Act
            this.repository.Create(track);
            this.createdTrackId = track.Id;

            var insertedTrack = this.repository.GetById(track.Id);

            // Assert
            Assert.IsNotNull(insertedTrack);
            Assert.AreEqual("my all", insertedTrack.Name);
            Assert.AreEqual(3.51f, insertedTrack.Duration);
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Create_InvalidEntityWithNoLogin_ShouldNotCreatTrack()
        {
            // Arrange & Act & Assert
            this.repository.Create(new Track
            {
                Name = "Me And Your Mama"
            });
        }
    }
}




using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;
using System.Linq;

namespace MusicStore.DAL.Test.TrackTests
{
    [TestClass]
    public class ShowTracksFromAlbumTests: BaseTest
    {
        private ITrackRepository repository;

        public ShowTracksFromAlbumTests()
        {
            this.repository = new TrackRepository(this.dbContext);
        }

        [TestMethod]
        public void ShowTracksFromAlbum_ExistingAlbum_ShouldReturnTracks()
        {
            // Arrange
            const int EXISTING_ALBUMID = 8;

            // Act
            var tracks = this.repository.GetTracksFromAlbum(EXISTING_ALBUMID).ToList();

            // Assert
            Assert.IsNotNull(tracks);
            Assert.IsTrue(tracks.Any());
        }

        [TestMethod]
        public void ShowTracksFromAlbum_UnExistingAlbum_ShouldNotReturnTracks()
        {
            // Arrange
            var UNEXISTING_ALBUMID = 99;

            // Act
            var orders = this.repository.GetTracksFromAlbum(UNEXISTING_ALBUMID).ToList();

            // Assert
            Assert.AreEqual(0, orders.Count);
        }
    }
}

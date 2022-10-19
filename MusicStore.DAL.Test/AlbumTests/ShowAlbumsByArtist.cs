using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;
using System.Linq;

namespace MusicStore.DAL.Test.AlbumTests
{
    [TestClass]
    public class ShowAlbumsByArtist : BaseTest
    {
        private IArtistRepository repository;

        public ShowAlbumsByArtist()
        {
            this.repository = new ArtistRepository(this.dbContext);
        }

        [TestMethod]
        public void ShowAlbumsByArtist_ExistingArtist_ShouldReturnAlbums()
        {
            // Arrange
            const int EXISTING_ARTISTID = 3;

            // Act
            var albums = this.repository.GetAlbums(EXISTING_ARTISTID).ToList();

            // Assert
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Any());
        }

        [TestMethod]
        public void ShowAlbumsByArtist_UnExistingArtist_ShouldReturnAlbums()
        {
            // Arrange
            var UNEXISTING_ARTISTID = 99;

            // Act
            var orders = this.repository.GetAlbums(UNEXISTING_ARTISTID).ToList();

            // Assert
            Assert.AreEqual(0, orders.Count);
        }

    }
}

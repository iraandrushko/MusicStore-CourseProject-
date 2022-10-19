using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.AlbumTests
{
    [TestClass]
    public class UpdateAlbumTests : BaseTest
    {
        private const int ALBUM_TOUPDATE_ID = 10;
        private const int ALBUM_TOUPDATE_OLDPRICE = 40;
        private const int ALBUM_TOUPDATE_NEWPRICE = 30;

        private IRepository<Album> repository;

        public UpdateAlbumTests()
        {
            this.repository = new AlbumRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var album = this.repository.GetById(ALBUM_TOUPDATE_ID);
                if (album != null)
                {
                    album.Price = ALBUM_TOUPDATE_OLDPRICE;
                    this.repository.Update(album);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Update_ValidPrice_ShouldUpdateAlbum()
        {
            // Arrange & Act
            var album = this.repository.GetById(ALBUM_TOUPDATE_ID);
            album.Price = ALBUM_TOUPDATE_NEWPRICE;
            repository.Update(album);

            var updatedAlbum = this.repository.GetById(ALBUM_TOUPDATE_ID);

            // Assert
            Assert.IsNotNull(updatedAlbum);
            Assert.AreEqual(ALBUM_TOUPDATE_NEWPRICE, updatedAlbum.Price);
        }
       

    }
}

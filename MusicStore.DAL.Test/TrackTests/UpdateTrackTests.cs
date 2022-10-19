using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.TrackTests
{
    [TestClass]
    public class UpdateTrackTests : BaseTest
    {
        private const int TRACK_TOUPDATE_ID = 7;
        private const string  TRACK_TOUPDATE_OLDNAME = "same effect";
        private const string TRACK_TOUPDATE_NEWNAME = "snail";

        private ITrackRepository repository;

        public UpdateTrackTests()
        {
            this.repository = new TrackRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var track = this.repository.GetById(TRACK_TOUPDATE_ID);
                if (track != null)
                {
                    track.Name = TRACK_TOUPDATE_OLDNAME;
                    this.repository.Update(track);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Update_ValidName_ShouldUpdateTrack()
        {
            // Arrange & Act
            var track = this.repository.GetById(TRACK_TOUPDATE_ID);
            track.Name = TRACK_TOUPDATE_NEWNAME;
            repository.Update(track);

            var updatedTrack = this.repository.GetById(TRACK_TOUPDATE_ID);

            // Assert
            Assert.IsNotNull(updatedTrack);
            Assert.AreEqual(TRACK_TOUPDATE_NEWNAME, updatedTrack.Name);
        }
    }
}

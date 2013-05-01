using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using OrangeCode.Codemotion.SpotifyViewer.Services;

namespace OrangeCode.Codemotion.SpotifyViewer.Fixture.Services
{
    [TestClass]
    public class SongServiceFixture
    {
        private SongService _service;
        
        public SongServiceFixture()
        {
            _service = new SongService();
        }
        
        [TestMethod]
        public async Task Query_Should_LoadDataFromServer()
        {
          
            var data=await _service.Query("Tiesto");

            Assert.IsNotNull(data);
        }

        [TestMethod]
        public async Task Query_Should_Load_ProperArtist()
        {
            var data = await _service.Query("Tiesto");
            Assert.IsTrue(data.tracks.Count!=0);
        }
    }
}

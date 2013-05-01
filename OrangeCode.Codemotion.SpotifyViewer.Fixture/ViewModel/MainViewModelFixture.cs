using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using OrangeCode.Codemotion.SpotifyViewer.Services;
using OrangeCode.Codemotion.SpotifyViewer.ViewModel;

namespace OrangeCode.Codemotion.SpotifyViewer.Fixture.ViewModel
{
    [TestClass]
    public class MainViewModelFixture
    {
        [TestMethod]
        public void Ctor_Should_Initialize_UserList()
        {
            MainViewModel viewModel = new MainViewModel(new SongService());

            Assert.IsNotNull(viewModel.TrackList);
        }
        
    }
}

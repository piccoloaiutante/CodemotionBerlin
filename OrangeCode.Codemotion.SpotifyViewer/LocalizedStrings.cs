using OrangeCode.Codemotion.SpotifyViewer.Resources;

namespace OrangeCode.Codemotion.SpotifyViewer
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}
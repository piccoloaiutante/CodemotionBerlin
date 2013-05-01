using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using OrangeCode.Codemotion.SpotifyViewer.Dto;
using OrangeCode.Codemotion.SpotifyViewer.Services;

namespace OrangeCode.Codemotion.SpotifyViewer.ViewModel
{
    public class MainViewModel :INotifyPropertyChanged
    {
        private readonly ISongService _songService;
        public string SearchedText { get; set; }
        public IList<track> TrackList { get; set; }

        public MainViewModel(ISongService songService)
        {
            _songService = songService;
            TrackList= new List<track>();
        }

        public async Task  Search()
        {

            TrackList = (await _songService.Query(SearchedText)).tracks;
            
            OnPropertyChanged("TrackList");

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

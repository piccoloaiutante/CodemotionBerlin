using Microsoft.Phone.Controls;
using OrangeCode.Codemotion.SpotifyViewer.Services;
using OrangeCode.Codemotion.SpotifyViewer.ViewModel;

namespace OrangeCode.Codemotion.SpotifyViewer.Views
{
    public partial class MainView : PhoneApplicationPage
    {
        // Constructor
        public MainView()
        {
            InitializeComponent();

            DataContext = new MainViewModel(new SongService());
           
          
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           await ((MainViewModel)DataContext).Search();
        }

        
    }
}
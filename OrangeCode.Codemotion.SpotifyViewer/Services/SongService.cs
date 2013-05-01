using System.Threading.Tasks;
using OrangeCode.Codemotion.SpotifyViewer.Dto;
using OrangeCode.Codemotion.SpotifyViewer.Infrastructure;
using RestSharp;

namespace OrangeCode.Codemotion.SpotifyViewer.Services
{
    public interface ISongService
    {
        Task<info> Query(string query);
    }


    public class SongService:ISongService
    {
        string _baseUrl;
        private RestClient _client; 
        
        public SongService()
        {
            _client = new RestClient();
            _client.BaseUrl = "http://ws.spotify.com/search/1/track.json?q=";
        }


        public async Task<info> Query(string query)
        {

            var request = new RestRequest(query, Method.GET);

            var response=(await _client.ExecuteTaskAsync<info>(request));
            
            return response.Data;
        }
    }
}

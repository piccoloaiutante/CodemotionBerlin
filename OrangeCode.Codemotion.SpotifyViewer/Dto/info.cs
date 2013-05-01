using System.Collections.Generic;

namespace OrangeCode.Codemotion.SpotifyViewer.Dto
{
    public class info
    {
        public int num_result { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public string query { get; set; }
        public string type { get; set; }
        public int page { get; set; }
        public List<track> tracks { get; set; }   
    }
}

using System.Collections.Generic;

namespace OrangeCode.Codemotion.SpotifyViewer.Dto
{
    public class track
    {
        public album album { get; set; }
        public string name { get; set; }
        public double length { get; set; }
        public List<artist> artist { get; set; }
    }
}

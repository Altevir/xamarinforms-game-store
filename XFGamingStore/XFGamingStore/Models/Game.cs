namespace XFGamingStore.Models
{
    public class Game
    {
        public string name { get; set; }
        public string description { get; set; }
        public string urlTrailer { get; set; }
        public string image { get; set; }
        public string imageBackground { get; set; }
        public bool android { get; set; }
        public bool appleIOS { get; set; }
        public bool xBox { get; set; }
        public bool sonyPlaystation { get; set; }
        public bool nintendoSwitch { get; set; }
        public bool pc { get; set; }
        public int trophies { get; set; }
    }
}

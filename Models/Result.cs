namespace WeatherApp.Models {
    public class ResultWeather {
        public float temperature { get; set; }
        public int timestamp { get; set; }
    }

    public class Result {
        public string city { get; set; }
        public ResultWeather[] weather { get; set; }
    }
}
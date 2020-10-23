namespace WeatherApp.Models {
    public class WeatherCity {
        public string name { get; set; }
    }

    public class WeatherForecast {
        public float temp { get; set; }
    }

    public class WeatherList {
        public int dt { get; set; }
        public WeatherForecast main { get; set; }
    }

    public class Weather {
        public WeatherCity city { get; set; }
        public WeatherList[] list { get; set; }
    }
}
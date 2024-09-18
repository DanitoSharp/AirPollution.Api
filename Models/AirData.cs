using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AirPollution.Api.Models;

public class Coord
{
    [JsonProperty("lon")]
    public double Lon { get; set; }
    [JsonProperty("lat")]
    public double Lat { get; set; }

}


public class MainData
{
    [JsonProperty("aqi")]
    public int Aqi { get; set; }
}

public class Components
{
    [JsonProperty("co")]
    public double Co { get; set; }
    [JsonProperty("no")]
    public double No { get; set; }
    [JsonProperty("no2")]
    public double No2 { get; set; }
    [JsonProperty("o3")]
    public double O3 { get; set; }
    [JsonProperty("so2")]
    public double So2 { get; set; }
    [JsonProperty("pm2_5")]
    public double Pm2_5 { get; set; }
    [JsonProperty("pm10")]
    public double Pm10 { get; set; }
    [JsonProperty("nh3")]
    public double Nh3 { get; set; }
}

public class AirReport
{
    [JsonProperty("main")]
    public MainData? Main { get; set; }

    [JsonProperty("components")]
    public Components? Components { get; set; }

    [JsonProperty("dt")]
    public long Dt { get; set; }

}

public class AirData
{
    [JsonProperty("coord")]
    public Coord? Coord { get; set; }
    [JsonProperty("list")]
    public IEnumerable<AirReport>? List { get; set; }

}

// {"coord":{
//     "lon":8.5954,
//     "lat":6.0968},
// "list":[
//     {"main":{"aqi":2},
//     "components":{
//         "co":847.82,
//         "no":0.01,
//         "no2":3.04,
//         "o3":6.44,
//         "so2":0.35,
//         "pm2_5":22.56,
//         "pm10":26.7,
//         "nh3":0.64
//            },
//         "dt":1726613719}]}
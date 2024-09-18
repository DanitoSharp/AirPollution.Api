// using System;

// namespace AirPollution.Api.Models
// {

//     using System;
//     using System.Collections.Generic;

//     public class Air
//     {
//         public Coord Coord { get; set; }
//         public List<WeatherData> List { get; set; }
//     }

//     public class Coord
//     {
//         public double Lon { get; set; }
//         public double Lat { get; set; }
//     }

//     public class WeatherData
//     {
//         public MainData Main { get; set; }
//         public Components Components { get; set; }
//         public long Dt { get; set; }
//     }

//     public class MainData
//     {
//         public int Aqi { get; set; }
//     }

//     public class Components
//     {
//         public double Co { get; set; }
//         public double No { get; set; }
//         public double No2 { get; set; }
//         public double O3 { get; set; }
//         public double So2 { get; set; }
//         public double Pm2_5 { get; set; }
//         public double Pm10 { get; set; }
//         public double Nh3 { get; set; }
//     }


// }
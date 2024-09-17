using System;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http.Connections;

namespace AirPollution.Api.Models;

public class Coord
{
    public double Lon { get; set; }
    public double Lat { get; set; }

}
public class Info
{


    public Main? Main { get; set; }
    public Components? Components { get; set; }

    public long Dt { get; set; }

}
public record Main(
    int Aqi
);
public record Components(
    double Co,
    double No,
    double No2,
    double O3,
    double So2,
    double Pm2_5,
    double Pm10,
    double Nh3
);

public class AirData
{
    public Coord? Coord { get; set; }
    public List<Info>? List { get; set; }

}

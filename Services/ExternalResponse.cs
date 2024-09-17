using System;
using System.Text.Json;
using AirPollution.Api.Models;

namespace AirPollution.Api.Services
{

    public interface IExternalResponse
    {
        Task<AirData?> GetAirPollutionData();
        Task<AirData?> GetAirPollutionForcast();
    }

    public class ExternalResponse : IExternalResponse
    {

        private readonly HttpClient Client;

        public ExternalResponse(HttpClient _Client)
        {
            Client = _Client;
        }

        public async Task<AirData?> GetAirPollutionData()
        {
            // var lat = 6.096801;
            // var lon = 8.595430;
            // var key = "74c8c25a92f9766ce646f557d3b2a596";
            
            var link = $"http://api.openweathermap.org/data/2.5/air_pollution?lat=6.096801&lon=8.595430&appid=74c8c25a92f9766ce646f557d3b2a596";

            var message = await Client.GetAsync(link);

            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();

                AirData? inject = JsonSerializer.Deserialize<AirData>(result);

                return inject;
            }
            else
            {
                throw new HttpRequestException("Error trying to fatch data from external Api!");
            }

        }

        public async Task<AirData?> GetAirPollutionForcast()
        {
            
            var link =$"http://api.openweathermap.org/data/2.5/air_pollution/forecast?lat=6.096801&lon=8.595430&appid=74c8c25a92f9766ce646f557d3b2a596";
            var message = await Client.GetAsync(link);

            if(message.IsSuccessStatusCode)
            {
                var result = await message.Content.ReadAsStringAsync();

                AirData? inject = JsonSerializer.Deserialize<AirData>(result);
                
                return inject;
                
            }
            else{
                throw new HttpRequestException("Error trying to fatch data from external Api!");
            }
        }

    }
}
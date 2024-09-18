using System;
using System.Text.Json;
using AirPollution.Api.Models;
using Newtonsoft.Json;

namespace AirPollution.Api.Services
{

    public interface IExternalResponse
    {
        Task<AirData?> GetAirPollutionData(double lat, double lon);
        Task<AirData?> GetAirPollutionForcast(double lat, double lon);
    }

    public class ExternalResponse : IExternalResponse
    {

        private readonly HttpClient Client;

        public ExternalResponse(HttpClient _Client)
        {
            Client = _Client;
        }

        public async Task<AirData?> GetAirPollutionData(double lat, double lon)
        {
            
            // var key = "74c8c25a92f9766ce646f557d3b2a596";
            
            //var link = $"http://api.openweathermap.org/data/2.5/air_pollution?lat=6.096801&lon=8.595430&appid=74c8c25a92f9766ce646f557d3b2a596";
            var link = $"http://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid=74c8c25a92f9766ce646f557d3b2a596";

            var message = await Client.GetAsync(link);

            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();

                AirData? inject = JsonConvert.DeserializeObject<AirData>(result);

                return inject;
            }
            else
            {
                throw new HttpRequestException("Error trying to fatch data from external Api!");
            }

        }

        public async Task<AirData?> GetAirPollutionForcast(double lat, double lon)
        {
            
            //var link ="http://api.openweathermap.org/data/2.5/air_pollution/forecast?lat=6.096801&lon=8.595430&appid=74c8c25a92f9766ce646f557d3b2a596";
            var link = $"http://api.openweathermap.org/data/2.5/air_pollution/forecast?lat={lat}&lon={lon}&appid=74c8c25a92f9766ce646f557d3b2a596";
            
            var message = await Client.GetAsync(link);

            if(message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();

                AirData? inject = JsonConvert.DeserializeObject<AirData>(result);
                
                return inject;
                
            }
            else{
                throw new HttpRequestException("Error trying to fatch data from external Api!");
            }
        }

    }
}
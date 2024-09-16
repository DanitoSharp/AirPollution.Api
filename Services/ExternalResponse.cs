using System;

namespace AirPollution.Api.Services
{

    public interface IExternalResponse
    {
        Task<string> GetAirPollutionData();
    }

    public class ExternalResponse : IExternalResponse
    {

        private readonly HttpClient Client;

        public ExternalResponse(HttpClient _Client)
        {
            Client = _Client;
        }

        public async Task<string> GetAirPollutionData()
        {

            var link = "http://api.openweathermap.org/data/2.5/air_pollution?lat=6.096801&lon=8.595430&appid=74c8c25a92f9766ce646f557d3b2a596";

            HttpResponseMessage client = await Client.GetAsync(link);

            if (client.IsSuccessStatusCode)
            {
                return await client.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException("Error trying to fatch data from external Api!");
            }

        }

    }
}
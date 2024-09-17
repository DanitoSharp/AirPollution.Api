using AirPollution.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirPollution.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirPollutionController : ControllerBase
    {

        private readonly IExternalResponse response;
        public AirPollutionController(IExternalResponse _response)
        {
            response = _response;
        }


        [HttpGet("/CurrentData")]
        public async Task<IActionResult> GetCurrentData()
        {
            try{
                var data = await response.GetAirPollutionData();
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("/ForcastData")]
        public async Task<IActionResult> GetForcastData()
        {
            try{

                var data = await response.GetAirPollutionForcast();
                return Ok(data);

            }catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        
    }
}

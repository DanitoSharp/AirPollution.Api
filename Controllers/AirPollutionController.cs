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
        public async Task<IActionResult> GetCurrentData(double lat, double lon)
        {
            try{
                var data = await response.GetAirPollutionData(lat, lon);
                if(data is null)
                {
                    return NotFound();
                }
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("/ForcastData")]
        public async Task<IActionResult> GetForcastData([FromQuery]double lat, [FromQuery] double lon)
        {
            try{

                var data = await response.GetAirPollutionForcast(lat, lon);
                if(data is null)
                {
                    return NotFound();
                }
                return Ok(data);
            }catch(Exception ex)
            {

                return BadRequest(ex.Message);
                
            }
        }

        [HttpGet("creator")]
        public IActionResult Creator()
        {
            return Ok("Daniel Ekeleme");
        }

        
    }
}

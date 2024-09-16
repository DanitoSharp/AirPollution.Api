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


        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            try{
                var data = await response.GetAirPollutionData();
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}

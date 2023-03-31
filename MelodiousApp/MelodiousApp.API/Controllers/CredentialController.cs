using MelodiousApp.DataTrasfer;
using MelodiousApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiousApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredentialController : ControllerBase
    {
        private readonly ICredentialService _credentialService;
        public CredentialController(ICredentialService credentialService)
        {
            _credentialService = credentialService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<CredentialDto>>> GetCredentials()
        {
            try
            {
                var credentials = await _credentialService.GetAll();
                return Ok(credentials);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> AddNewCredential([FromBody] CredentialDto credential)
        {
            try
            {
                var newId = await _credentialService.AddNew(credential);
                var anonymouseResponse = new
                {
                    newId
                };
                return Ok(anonymouseResponse);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateCredential([FromBody] CredentialDto credential)
        {
            try
            {
                var credentialUdpated = await _credentialService.Update(credential);
                return Ok(credentialUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
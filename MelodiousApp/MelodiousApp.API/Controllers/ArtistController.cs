using MelodiousApp.DataTrasfer;
using MelodiousApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiousApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<ArtistDto>>> GetArtists()
        {
            try
            {
                var artists = await _artistService.GetAll();
                return Ok(artists);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> AddNewArtist([FromBody] ArtistDto artist)
        {
            try
            {
                var newId = await _artistService.AddNew(artist);
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
        public async Task<ActionResult> UpdateArtist([FromBody] ArtistDto artist)
        {
            try
            {
                var artistUdpated = await _artistService.Update(artist);
                return Ok(artistUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
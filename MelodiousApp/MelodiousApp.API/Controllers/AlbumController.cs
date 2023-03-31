using MelodiousApp.DataTrasfer;
using MelodiousApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiousApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<AlbumDto>>> GetAlbums()
        {
            try
            {
                var albums = await _albumService.GetAll();
                return Ok(albums);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> AddNewAlbum([FromBody] AlbumDto album)
        {
            try
            {
                var newId = await _albumService.AddNew(album);
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
        public async Task<ActionResult> UpdateAlbum([FromBody] AlbumDto album)
        {
            try
            {
                var albumUdpated = await _albumService.Update(album);
                return Ok(albumUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
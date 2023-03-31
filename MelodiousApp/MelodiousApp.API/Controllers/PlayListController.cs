using MelodiousApp.DataTrasfer;
using MelodiousApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiousApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayListController : ControllerBase
    {
        private readonly IPlayListService _playListService;
        public PlayListController(IPlayListService playListService)
        {
            _playListService = playListService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<PlayListDto>>> GetPlayLists()
        {
            try
            {
                var playLists = await _playListService.GetAll();
                return Ok(playLists);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost()]
        public async Task<ActionResult> AddNewPlayList([FromBody] PlayListDto playList)
        {
            try
            {
                var newId = await _playListService.AddNew(playList);
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
        public async Task<ActionResult> UpdatePlayList([FromBody] PlayListDto playList)
        {
            try
            {
                var playListUdpated = await _playListService.Update(playList);
                return Ok(playListUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
using MelodiousApp.DataTrasfer;
using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.Models;
using MelodiousApp.Services.Interface;

namespace MelodiousApp.Services.Services
{
    public class PlayListService : IPlayListService
    {
        private readonly IPlayListRepository _playlistRepository;
        public PlayListService(IPlayListRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        public async Task<int> AddNew(PlayListDto playListDto)
        {
            PlayList playList = PlayListMapper.DtoToModel(playListDto);
            var playListCreated = await _playlistRepository.Create(playList);
            return playListCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var entityDeleted = await _playlistRepository.Delete(id);
            return entityDeleted.Id;
        }
        public async Task<List<PlayListDto>> GetAll()
        {
            var playList = await _playlistRepository.GetAll();
            var playListDto = playList.Select(PlayListMapper.ModelToDto).ToList();
            return playListDto;
        }
        public async Task<PlayListDto> GetById(int id)
        {
            var playList = await _playlistRepository.GetOne(id);
            return PlayListMapper.ModelToDto(playList);
        }
        public async Task<PlayListDto> Update(PlayListDto playListDto)
        {
            var playList = PlayListMapper.DtoToModel(playListDto);
            var playListModel = await _playlistRepository.Update(playList);
            return PlayListMapper.ModelToDto(playListModel);
        }
    }
}
using MelodiousApp.DataTrasfer;
using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.Models;
using MelodiousApp.Services.Interface;

namespace MelodiousApp.Services.Services
{
    internal class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;
        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<int> AddNew(SongDto songDto)
        {
            Song song = SongMapper.DtoToModel(songDto);
            var songCreated = await _songRepository.Create(song);
            return songCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var songDeleted = await _songRepository.Delete(id);
            return songDeleted.Id;
        }
        public async Task<List<SongDto>> GetAll()
        {
            var songs = await _songRepository.GetAll();
            var songDto = songs.Select(SongMapper.ModelToDto).ToList();
            return songDto;
        }

        public async Task<SongDto> GetById(int id)
        {
            var song = await _songRepository.GetOne(id);
            return SongMapper.ModelToDto(song);
        }
        public async Task<SongDto> Update(SongDto songDto)
        {
            var song = SongMapper.DtoToModel(songDto);
            var songModel = await _songRepository.Update(song);
            return SongMapper.ModelToDto(songModel);
        }
    }
}
using MelodiousApp.DataTrasfer;
using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.Models;
using MelodiousApp.Services.Interface;

namespace MelodiousApp.Services.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public async Task<int> AddNew(AlbumDto albumDto)
        {
            Album album = AlbumMapper.DtoToModel(albumDto);
            var albumCreated = await _albumRepository.Create(album);
            return albumCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var entityDeleted = await _albumRepository.Delete(id);
            return entityDeleted.Id;
        }
        public async Task<List<AlbumDto>> GetAll()
        {
            var albums = await _albumRepository.GetAll();
            var albumsDto = albums.Select(AlbumMapper.ModelToDto).ToList();
            return albumsDto;
        }

        public async Task<AlbumDto> GetById(int id)
        {
            var album = await _albumRepository.GetOne(id);
            return AlbumMapper.ModelToDto(album);
        }
        public async Task<AlbumDto> Update(AlbumDto albumDto)
        {
            var album = AlbumMapper.DtoToModel(albumDto);
            var albumModel = await _albumRepository.Update(album);
            return AlbumMapper.ModelToDto(albumModel);
        }
    }
}
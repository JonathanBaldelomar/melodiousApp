using MelodiousApp.DataTrasfer;
using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.Services.Interface;

namespace MelodiousApp.Services.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public async Task<int> AddNew(ArtistDto artistDto)
        {
            Artist artist = ArtistMapper.DtoToModel(artistDto);
            var artistCreated = await _artistRepository.Create(artist);
            return artistCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var entityDeleted = await _artistRepository.Delete(id);
            return entityDeleted.Id;
        }
        public async Task<List<ArtistDto>> GetAll()
        {
            var albums = await _albumRepository.GetAll();
            var albumsDto = albums.Select(albumMapper.ModelToDto).ToList();
            return albumsDto;
        }

        public async Task<ArtistDto> GetById(int id)
        {
            var artist = await _artistRepository.GetOne(id);
            return artistMapper.ModelToDto(artist);
        }
        public async Task<ArtistDto> Update(ArtistDto artistDto)
        {
            var artist = ArtistMapper.DtoToModel(artistDto);
            var artistModel = await _artistRepository.Update(artist);
            return ArtistMapper.ModelToDto(artistModel);
        }
    }
}
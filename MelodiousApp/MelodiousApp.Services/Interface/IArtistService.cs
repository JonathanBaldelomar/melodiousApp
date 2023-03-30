using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface IArtistService
    {
        public Task<List<ArtistDto>> GetAll();
        public Task<ArtistDto> GetById(int id);
        public Task<int> AddNew(ArtistDto artistDto);
        public Task<ArtistDto> Update(ArtistDto artistDto);
        public Task<int> Delete(int id);
    }
}
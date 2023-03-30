using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface IAlbumService
    {
        public Task<List<AlbumDto>> GetAll();
        public Task<AlbumDto> GetById(int id);
        public Task<int> AddNew(AlbumDto albumDto);
        public Task<AlbumDto> Update(AlbumDto albumDto);
        public Task<int> Delete(int id);
    }
}
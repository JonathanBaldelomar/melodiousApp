using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface ISongService
    {
        public Task<List<SongDto>> GetAll();
        public Task<SongDto> GetById(int id);
        public Task<int> AddNew(SongDto songDto);
        public Task<SongDto> Update(SongDto songDto);
        public Task<int> Delete(int id);
    }
}
using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface IPlayListService
    {
        public Task<List<PlayListDto>> GetAll();
        public Task<PlayListDto> GetById(int id);
        public Task<int> AddNew(PlayListDto playListDto);
        public Task<PlayListDto> Update(PlayListDto playListDto);
        public Task<int> Delete(int id);
    }
}
using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface IUserService
    {
        public Task<List<UserDto>> GetAll();
        public Task<UserDto> GetById(int id);
        public Task<int> AddNew(UserDto userDto);
        public Task<UserDto> Update(UserDto userDto);
        public Task<int> Delete(int id);
    }
}
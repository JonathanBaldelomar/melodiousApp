using MelodiousApp.Models;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public class UserMapper
    {
        public static User DtoToModel(UserDto userDto)
            => new User()
            {
                Id = userDto.Id,
                Name = userDto.Name
            };

        public static UserDto ModelToDto(User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                Name = user.Name
            };
        }
    }
}

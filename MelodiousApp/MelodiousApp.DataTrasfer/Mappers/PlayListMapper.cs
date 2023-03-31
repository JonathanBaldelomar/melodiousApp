using MelodiousApp.Models;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class PlayListMapper
    {
        public static PlayList DtoToModel(PlayListDto playListDto)
            => new PlayList()
            {
                Id = playListDto.Id,
                Title = playListDto.Title,
                Description = playListDto.Description
            };

        public static PlayListDto ModelToDto(PlayList playList)
        {
            return new PlayListDto()
            {
                Id = playList.Id,
                Title = playList.Title,
                Description = playList.Description
            };
        }
    }
}

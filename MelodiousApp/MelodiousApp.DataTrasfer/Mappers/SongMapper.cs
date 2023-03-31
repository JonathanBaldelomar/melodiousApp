using MelodiousApp.Models;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class SongMapper
    {
        public static Song DtoToModel(SongDto songDto)
            => new Song()
            {
                Id = songDto.Id,
                Title = songDto.Title,
                Length = songDto.Length,
                ReleaseDate = songDto.ReleaseDate
            };

        public static SongDto ModelToDto(Song song)
        {
            return new SongDto()
            {
                Id = song.Id,
                Title = song.Title,
                Length = (int)song.Length,
                ReleaseDate = (DateTime)song.ReleaseDate
            };
        }
    }
}

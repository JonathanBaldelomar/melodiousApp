using MelodiousApp.Models;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class ArtistMapper
    {
        public static Artist DtoToModel(ArtistDto artistDto)
            => new Artist()
            {
                Id = artistDto.Id,
                Name = artistDto.Name,
                Biography = artistDto.Biography
            };

        public static ArtistDto ModelToDto(Artist artist)
        {
            return new ArtistDto()
            {
                Id = artist.Id,
                Name = artist.Name,
                Biography = artist.Biography
            };
        }
    }
}

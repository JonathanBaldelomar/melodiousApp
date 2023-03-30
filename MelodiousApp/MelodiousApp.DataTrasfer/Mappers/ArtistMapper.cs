using MelodiousApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class ArtistMapper
    {
        public static Artist DtoToMOdel(ArtistDto artistDto)
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
                Name = artist.Title,
                Biography = artist.Biography
            };
        }
    }
}

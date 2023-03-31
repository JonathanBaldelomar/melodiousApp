using MelodiousApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class AlbumMapper
    {
        public static Album DtoToModel(AlbumDto albumDto)
            => new Album()
            {
                Id = albumDto.Id,
                Title = albumDto.Title,
                ReleaseDate = albumDto.ReleaseDate
            };

        public static AlbumDto ModelToDto(Album album)
        {
            return new AlbumDto()
            {
                Id = album.Id,
                Title = album.Title,
                ReleaseDate = (DateTime)album.ReleaseDate
            };
        }
    }
}

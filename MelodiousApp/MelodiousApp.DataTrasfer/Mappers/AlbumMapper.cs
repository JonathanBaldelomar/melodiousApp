<<<<<<< HEAD
﻿using MelodiousApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class AlbumMapper
=======
﻿namespace MelodiousApp.DataTrasfer.Mappers
{
    public class AlbumMapper
>>>>>>> 9d4e5190182c5ef0b25c3f0ad11be77850add52e
    {
        public static Artist DtoToMOdel(ArtistDto albumDto)
            => new Artist()
            {
                Id = albumDto.Id,
                Title = albumDto.Title,
                ReleaseDate = albumDto.ReleaseDate
            };

        public static ArtistDto ModelToDto(Artist album)
        {
            return new ArtistDto()
            {
                Id = album.Id,
                Title = album.Title,
                ReleaseDate = (DateTime)album.ReleaseDate
            };
        }
    }
}

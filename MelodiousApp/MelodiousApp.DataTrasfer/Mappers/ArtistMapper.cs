<<<<<<< HEAD
﻿using MelodiousApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public static class ArtistMapper
=======
﻿namespace MelodiousApp.DataTrasfer.Mappers
{
    public class ArtistMapper
>>>>>>> 9d4e5190182c5ef0b25c3f0ad11be77850add52e
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

using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class ArtistSong : BaseEntity
    {
        public virtual Artist Artist { get; set; } = null!;
        public int ArtistId { get; set; }

        public virtual Song Song { get; set; } = null!;
        public int SongId { get; set; }

    }
}

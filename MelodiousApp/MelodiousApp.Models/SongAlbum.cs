using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class SongAlbum
    {
        public virtual Song Song { get; set; } = null!;
        public int SongId { get; set; }

        public virtual Artist Album { get; set; } = null!;
        public int AlbumId { get; set; }
    }
}

using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class PlayListSong : BaseEntity
    {
        public virtual PlayList PlayList { get; set; } = null!;
        public int PlayListId { get; set; }

        public virtual Song Song { get; set; } = null!;
        public int SongId { get; set; }
    }
}

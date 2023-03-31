using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class Album : BaseEntity
    {
        public string Title { get; set; } = null!;
        public DateTime? ReleaseDate { get; set; }
    }
}

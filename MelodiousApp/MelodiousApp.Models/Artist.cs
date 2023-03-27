using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Biography { get; set; } = null!;
    }
}

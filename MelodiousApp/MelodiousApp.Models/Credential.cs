using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class Credential : BaseEntity
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public int UserId { get; set; }
    }
}

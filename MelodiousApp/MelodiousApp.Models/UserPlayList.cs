﻿using MelodiousApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Models
{
    public class UserPlayList : BaseEntity
    {
        public virtual User User { get; set; } = null!;
        public int UserId { get; set; }

        public virtual PlayList PlayList { get; set; } = null!;
        public int PlayListId { get; set; }
    }
}

using MelodiousApp.DataAccess.Persistence;
using MelodiousApp.DataAccess.Repository.Base;
using MelodiousApp.DataAccess.Repository.Interfaces;
using MelodiousApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.DataAccess.Repository.Implementation
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(MelodiousContext melodiousContext) : base(melodiousContext)
        {

        }
    }
}

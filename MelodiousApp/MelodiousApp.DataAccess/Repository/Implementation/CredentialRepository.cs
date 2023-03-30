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
    public class CredentialRepository : BaseRepository<Credential>, ICredentialRepository
    {
        public CredentialRepository(MelodiousContext melodiousContext) : base(melodiousContext)
        {

        }
    }
}

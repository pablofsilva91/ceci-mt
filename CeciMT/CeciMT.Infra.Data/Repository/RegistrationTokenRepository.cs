﻿using CeciMT.Domain.Entities;
using CeciMT.Domain.Interfaces.Repository;
using CeciMT.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeciMT.Infra.Data.Repository
{
    [ExcludeFromCodeCoverage]
    public class RegistrationTokenRepository : BaseRepository<RegistrationToken>, IRegistrationTokenRepository
    {
        public RegistrationTokenRepository(AppDbContext appDbcontext) : base(appDbcontext)
        {
        }
    }
}

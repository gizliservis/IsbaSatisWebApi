﻿using IsbaSatisWeb.Application.Repositories;
using IsbaSatisWeb.Core.Domain.Entities;
using IsbaSatisWeb.Infrastructure.Persistence.Contexts;
using IsbaSatisWeb.Persistence.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Persistence.Repositories
{
    public class CariRepository : Repository<Cari>, ICariRepository
    {
        public CariRepository(IsbaSatisWebDbContext context) : base(context)
        {
        }
    }
}

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
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(IsbaSatisWebDbContext context) : base(context)
        {
        }
    }
}

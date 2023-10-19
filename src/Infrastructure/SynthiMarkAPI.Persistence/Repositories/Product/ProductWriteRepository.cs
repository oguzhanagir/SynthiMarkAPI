﻿using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Domain.Entities;
using SynthiMarkAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(SynthiMarkAPIDbContext context) : base(context)
        {
        }
    }
}

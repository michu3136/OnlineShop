﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    interface IProductRepository
    {
        IQueryable<Product> GetAll();
        Product GetById(Guid id);
        Product Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}

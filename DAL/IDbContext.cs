﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public interface IDbContext
    {
        IDbSet<T> Set<T>() where T : class;
        int SaveChanges();
        DbEntityEntry Entry(object o);
        void Dispose();
    }
}

﻿using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using LinkDev.Company.DAL.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Repo
{
    public class GenericRepository<T> :IGeneracRepositor<T> where T : BaseModel
    {
        private protected readonly Context dbContext;

        public GenericRepository(Context context)
        {
            dbContext = context;
        }
        public int Add(T Tentity)
        {
            dbContext.Set<T>().Add(Tentity);
            return dbContext.SaveChanges();
        }

        public int Delete(T Tentity)
        {
            dbContext.Set<T>().Remove(Tentity);
            return dbContext.SaveChanges();

        }

        public T Get(int id)
        {
            return dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            
        }

        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Employee))
            {
                return (IEnumerable<T>) dbContext.Employees.Include(e=>e.Department).ToList();
            }
            return dbContext.Set<T>().ToList();
        }

        public int Update(T TEntity)
        {
            dbContext.Set<T>().Update(TEntity);
            return dbContext.SaveChanges();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using TransLocalization.Domain.Core.Interface.Repositorys;
using TransLocalization.Domain.Core.Interface.Services;

namespace TransLocalization.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;

        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
}
        public void Remove(TEntity obj)
        {
                repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
                repository.Update(obj);
        }
    }
}

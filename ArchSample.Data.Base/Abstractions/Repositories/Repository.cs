using ArchSample.Domain.Base.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchSample.Data.Base.Abstractions.Repositories
{
    public abstract class Repository<TEntity> where TEntity : Entity
    {
        public abstract TEntity SaveOrUpdate(TEntity entity);
        public abstract bool Remove(TEntity entity);
        public abstract TEntity GetById(Guid id);
        public abstract IEnumerable<TEntity> Get(int skip = 0, int take = 10);
        public abstract IEnumerable<TEntity> GetAll();
    }
}

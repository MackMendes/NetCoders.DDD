using System.Collections.Generic;
using BM.Data;
using BM.Data.Common.Interfaces;

namespace NetCoders.MicroErpDDD.Infra.Repositories.Base
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected IConnection Connection;

        protected RepositoryBase()
        {
            Connection = new Connection(nameOfConnection: ""); 
        }

        public abstract TEntity Get(int id);
        public abstract IEnumerable<TEntity> Get();
        public abstract void Add(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(int id);
    }
}

namespace LaptopListingSystem.Data
{
    using System;
    using System.Linq;
    
    public class Repository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> All()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Detach(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

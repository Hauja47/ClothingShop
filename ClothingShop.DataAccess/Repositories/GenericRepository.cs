using Microsoft.EntityFrameworkCore;

namespace ClothingShop.DataAccess
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        protected ShopContext context = null;

        protected DbSet<T> table = null;

        public GenericRepository(ShopContext context)
        {
            this.context = context;

            table = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(Guid id)
        {
            return table.Find(id);
        }

        public void Add(T entity)
        {
            table.AddAsync(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            table.AddRange(entities);
        }

        public void Update(T entity)
        {
            table.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            table.UpdateRange(entities);
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            table.RemoveRange(entities);
        }

        public Task SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Distro.Seedworks.Infrastructure.DataAccess
{
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class, IDatabaseEntity
    {
        protected DbContext Context { get; set; }
        public DbSet<T> _table { get; set; }

        protected RepositoryBase(DbContext dataContext)
        {
            this.Context = dataContext;
            _table = Context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _table.Find(id);
        }

        public IList<T> FindAll()
        {
            return _table.ToList();
        }

        public virtual void AddPreValidation(T addRequest)
        {
        }

        public T Add(T entity)
        {
            AddPreValidation(entity);

            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            _table.Add(entity);
            return entity;
        }

        public T Update(Guid id, T entity)
        {
            if (id != entity.Id)
            {
                throw new AccessViolationException($"Invalid update request. The ID [{id}] is different from the object provided");
            }

            _table.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public void Remove(Guid id)
        {
            var existing = _table.Single(a => a.Id == id);

            if (existing == null)
            {
                throw new DataMisalignedException($"Entity [{typeof(T)}] with ID [{id}]");
            }

            _table.Remove(existing);
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}

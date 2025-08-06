using ITSEP.Models;
using ITSEP.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ITSEP.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
         where TEntity : class, IEntity
    {

        public ItsepDbContext context { get; set; }
        protected IServiceProvider serviceProvider;
        protected IHttpContextAccessor httpContextAccessor;

        public Repository(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor)
        {
            this.serviceProvider = serviceProvider;
            this.httpContextAccessor = httpContextAccessor;
            this.context = (ItsepDbContext)this.serviceProvider.GetService(typeof(ItsepDbContext));
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(Guid id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(long id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public Task<TEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

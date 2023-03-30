using MelodiousApp.DataAccess.Persistence;
using MelodiousApp.Models.Base;

namespace MelodiousApp.DataAccess.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly MelodiousContext _melodiousContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(MelodiousContext melodiousContext)
        {
            _melodiousContext = melodiousContext;
            _dbSet = _melodiousContext.Set<TEntity>();
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            var createdEntity = await _dbSet.AddAsync(entity);
            var newEntity = createdEntity.Entity;

            await _melodiousContext.SaveChangesAsync();

            return newEntity;
        }

        public Task<TEntity> Delete(int id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);

            if (entityToDelete == null)
                throw new Exception("Entity not found");

            _dbSet.Remove(entityToDelete);
            return entityToDelete;
        }

        public Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<TEntity> GetOne(int id)
        {
            var test = _dbSet.Where(x => x.Id == id);
            return _dbSet.Where(x => x.Id == id).FirstAsync();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _melodiousContext.SaveChangesAsync();
            return entity;
        }
    }
}

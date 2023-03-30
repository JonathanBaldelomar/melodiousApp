using MelodiousApp.Models.Base;


namespace MelodiousApp.DataAccess.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetOne(int id);

        Task<TEntity> Create(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(int id);

    }
}

namespace Zaneuski.Casino.Model.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        void Delete(Expression<Func<TEntity, bool>> where);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        TEntity GetById(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Gets the many.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        /// <summary>
        /// Gets the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        TEntity Get(Expression<Func<TEntity, bool>> where);

        /// <summary>
        /// Counts the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        int Count(Expression<Func<TEntity, bool>> where = null);

        /// <summary>
        /// Determines whether the specified where is exist.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        bool IsExist(Expression<Func<TEntity, bool>> where = null);

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        void Dispose();
    }
}

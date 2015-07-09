namespace Zaneuski.Casino.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Base Repository abstract class
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseUnit
    {
        /// <summary>
        /// The casino context
        /// </summary>
        protected CasinoContext casinoContext;

        /// <summary>
        /// Gets the database set.
        /// </summary>
        /// <value>
        /// The database set.
        /// </value>
        protected DbSet<TEntity> DbSet
        {
            get { return casinoContext.Set<TEntity>(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepository(CasinoContext context)
        {
            casinoContext = context;
        } 

        //linqkit
        /// <summary>
        /// Gets the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public virtual List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }


        // look this method
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            casinoContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            IQueryable<TEntity> entities = DbSet.Where(where);
            List<TEntity> objects = entities.ToList();
            //IEnumerable<TEntity> objects = DbSet.Where(where).ToList();//.AsEnumerable();
            //IEnumerable<TEntity> objects = DbSet.Where<TEntity>(where).AsEnumerable();
            foreach (var entity in objects)
            {
                DbSet.Remove(entity);
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        /// <summary>
        /// Gets the many.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where).ToList();
        }

        /// <summary>
        /// Gets the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where).FirstOrDefault<TEntity>();
        }

        /// <summary>
        /// Counts the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public int Count(Expression<Func<TEntity, bool>> where = null)
        {
            return DbSet.Count(where);
        }

        /// <summary>
        /// Determines whether the specified where is exist.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public bool IsExist(Expression<Func<TEntity, bool>> where = null)
        {
            return DbSet.FirstOrDefault(where) != null;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        public void Save()
        {
            try
            {
                casinoContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder builder = new StringBuilder();
                foreach (var errors in e.EntityValidationErrors)
                {
                    builder.Append(string.Format(
                        "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        errors.Entry.Entity.GetType().Name, errors.Entry.State) + Environment.NewLine);
                    foreach (var dbValidationError in errors.ValidationErrors)
                    {
                        builder.Append(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                        dbValidationError.PropertyName, dbValidationError.ErrorMessage));
                    }
                }
                throw new Exception(builder.ToString(), e);
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            if (casinoContext != null)
            {
                casinoContext.Dispose();
                casinoContext = null;
            }
        }
    }
}

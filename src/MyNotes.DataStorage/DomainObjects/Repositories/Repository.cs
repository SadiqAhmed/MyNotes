namespace MyNotes.DataStorage.DomainObjects.Repositories
{
    using System;
    using NHibernate;
    using System.Linq.Expressions;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }

        /// <summary>
        /// Add entity of type TEntity
        /// </summary>
        /// <param name="entity">Entity of type TEntity</param>
        public void Add(TEntity entity)
        {
            _session.Save(entity);
        }

        /// <summary>
        /// Update entity of type TEntity
        /// </summary>
        /// <param name="entity">Entity of type TEntity</param>
        public void Update(TEntity entity)
        {
            _session.Update(entity);
        }

        /// <summary>
        /// Delete entity of type TEntity
        /// </summary>
        /// <param name="entity">Entity of type TEntity</param>
        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        /// <summary>
        /// Find entity of type TEntity by id
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <returns>Entity of type TEntity</returns>
        public TEntity FindOne(Guid id)
        {
            return _session.Get<TEntity>(id);
        }

        /// <summary>
        /// Find entity of type TEntity by expresion
        /// </summary>
        /// <param name="expression">Linq expression</param>
        /// <returns></returns>
        public TEntity FindOne(Expression<Func<TEntity, bool>> expression)
        {
            var query = _session.QueryOver<TEntity>().Where(expression);

            return query.SingleOrDefault<TEntity>();
        }

        /// <summary>
        /// Find all entities
        /// </summary>
        /// <returns>IQueryOver of entity of type TEntity</returns>
        public IQueryOver<TEntity> FindAll()
        {
            var query = _session.QueryOver<TEntity>();

            query.Cacheable().CacheMode(CacheMode.Normal);

            return query;
        }

        /// <summary>
        /// Find all entities with filter
        /// </summary>
        /// <param name="expression">Linq expression</param>
        /// <returns>IQueryOver of entity of type TEntity</returns>
        public IQueryOver<TEntity> FindAll(Expression<Func<TEntity, bool>> expression)
        {
            var query = _session.QueryOver<TEntity>();

            query.Cacheable().CacheMode(CacheMode.Normal);

            return query.Where(expression);
        }
    }
}

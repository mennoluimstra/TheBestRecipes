using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TheBestRecipes.Data
{
	public interface IRepository<T> where T : class
	{
		void Delete(object id);
		void Delete(T entityToDelete);
		IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
		T GetByID(object id);
		void Insert(T entity);
		void Update(T entityToUpdate);
	}
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace TheBestRecipes.Data
{
	public class Repository<T> : IRepository<T> where T : class
    {
		internal ApplicationDbContext context;
		internal DbSet<T> dbSet;

		public Repository(ApplicationDbContext context)
		{
			this.context = context;
			this.dbSet = context.Set<T>();
		}

		public virtual IQueryable<T> Get(
			Expression<Func<T, bool>> filter = null,
			Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
			string includeProperties = "")
		{
			IQueryable<T> query = dbSet;

			if (filter != null)
			{
				query = query.Where(filter);
			}

			foreach (var includeProperty in includeProperties.Split
				(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(includeProperty);
			}

			if (orderBy != null)
			{
				return orderBy(query);
			}
			else
			{
				return query;
			}
		}

		public virtual T GetByID(object id)
		{
			return dbSet.Find(id);
		}

		public virtual void Insert(T entity)
		{
			dbSet.Add(entity);
		}

		public virtual void Delete(object id)
		{
			T entityToDelete = dbSet.Find(id);
			Delete(entityToDelete);
		}

		public virtual void Delete(T entityToDelete)
		{
			if (context.Entry(entityToDelete).State == EntityState.Detached)
			{
				dbSet.Attach(entityToDelete);
			}
			dbSet.Remove(entityToDelete);
		}

		public virtual void Update(T entityToUpdate)
		{
			dbSet.Attach(entityToUpdate);
			context.Entry(entityToUpdate).State = EntityState.Modified;
		}
	}
}

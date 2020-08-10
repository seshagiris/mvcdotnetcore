using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Data.Data.Repository.IRepository;

namespace Uplift.Data.Data.Repository
{
	public class UnitOfWork : IUnitofWork
	{
		private readonly ApplicationDbContext _db;

		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			Category = new CategoryRepository(_db);
		}
		public ICategoryRepository Category { get; private set; }

		public void Dispose()
		{
			_db.Dispose();
		}

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}

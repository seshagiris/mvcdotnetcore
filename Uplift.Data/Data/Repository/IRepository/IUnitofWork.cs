using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.Data.Data.Repository.IRepository
{
	public interface IUnitofWork : IDisposable
	{
		ICategoryRepository Category { get; }

		void Save();
	}
}

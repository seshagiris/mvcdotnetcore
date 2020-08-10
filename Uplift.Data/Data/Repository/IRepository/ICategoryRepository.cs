using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Uplift.Data.Data.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		IEnumerable<SelectListItem> GetCategoryListForDropDown();

		void Update(Category category);

	}
}

using System.Collections.Generic;

using Budget.Business.Entities;
using Budget.Business.Queries.GetAllCategoryGroupsQuery;

using Microsoft.AspNetCore.Mvc;

namespace Budget.Angular.Controllers {

	[Route("api/[controller]")]
	public class CategoryController : Controller {

		[HttpGet("[action]")]
		public IEnumerable<CategoryGroup> CategoryGroups() {

			var queryHandler = new GetAllCategoryGroupsQueryHandler();

			return queryHandler.Handle(new GetAllCategoryGroupsQuery());
		}

	}

}
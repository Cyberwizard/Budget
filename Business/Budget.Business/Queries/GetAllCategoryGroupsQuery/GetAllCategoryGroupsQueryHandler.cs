using System;
using System.Collections.Generic;

using Budget.Business.Entities;
using Budget.Business.Interfaces.Queries;

namespace Budget.Business.Queries.GetAllCategoryGroupsQuery {

	public class GetAllCategoryGroupsQueryHandler : IQueryHandler<GetAllCategoryGroupsQuery, IEnumerable<CategoryGroup>> {

		public IEnumerable<CategoryGroup> Handle(GetAllCategoryGroupsQuery query) {
			
			return new List<CategoryGroup> {
				new CategoryGroup {
					Id = 1,
					Name = "Daily",
					Categories = new List<Category> {
						new Category {
							Id = 1,
							CategoryGroupId = 1,
							Name = "Groceries",
							Frequency = FrequencyType.MonthlyCumulative,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 2,
							CategoryGroupId = 1,
							Name = "Eating Out",
							Frequency = FrequencyType.MonthlyCumulative,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 3,
							CategoryGroupId = 1,
							Name = "Fuel",
							Frequency = FrequencyType.MonthlyCumulative,
							Amount = 500,
							Balance = 150
						},
					}
				},
				new CategoryGroup {
					Id = 2,
					Name = "Monthly Bills",
					Categories = new List<Category> {
						new Category {
							Id = 1,
							CategoryGroupId = 2,
							Name = "Electricity",
							Frequency = FrequencyType.MonthlySet,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 2,
							CategoryGroupId = 2,
							Name = "Water",
							Frequency = FrequencyType.MonthlySet,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 3,
							CategoryGroupId = 2,
							Name = "Cable",
							Frequency = FrequencyType.MonthlySet,
							Amount = 500,
							Balance = 150
						},
					}
				},
				new CategoryGroup {
					Id = 3,
					Name = "Yearly",
					Categories = new List<Category> {
						new Category {
							Id = 1,
							CategoryGroupId = 3,
							Name = "Life Insurance",
							Frequency = FrequencyType.Yearly,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 2,
							CategoryGroupId = 3,
							Name = "Amazon Prime",
							Frequency = FrequencyType.Yearly,
							Amount = 500,
							Balance = 150
						},
						new Category {
							Id = 3,
							CategoryGroupId = 3,
							Name = "Car Tags",
							Frequency = FrequencyType.Yearly,
							Amount = 500,
							Balance = 150
						},
					}
				}

			};
		}

	}

}
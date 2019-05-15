using System.Linq;

using Budget.Business.Queries.GetAllCategoryGroupsQuery;

using FluentAssertions;

using Xunit;

namespace Budget.Tests.UnitTests.Business.Queries {

	public class GetAllCategoryGroupsQueryHandlerTests {

		[Fact]
		public void GetAllCategoriesGroupsReturnsGroups() {

			// Arrange
			var queryHandler = new GetAllCategoryGroupsQueryHandler();

			// Act
			var groups = queryHandler.Handle(new GetAllCategoryGroupsQuery());

			// Assert
			groups.Count().Should().BeGreaterOrEqualTo(1, "the groups were returned");
		}

	}

}
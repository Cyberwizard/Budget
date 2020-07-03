using System.Collections.Generic;

namespace Budget.Business.Entities {

	public class CategoryGroup {

		public uint Id { get; set; }
		public string Name { get; set; }

		public ICollection<Category> Categories { get; set; }

	}

}
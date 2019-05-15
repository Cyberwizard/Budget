using System;

namespace Budget.Business.Entities {

	public class Category {

		public uint Id { get; set; }
		public uint CategoryGroupId { get; set; }
		public FrequencyType Frequency { get; set; }
		public string Name { get; set; }
		public decimal Amount { get; set; }
		public decimal Balance { get; set; }

		public CategoryGroup CategoryGroup { get; set; }
	}

}
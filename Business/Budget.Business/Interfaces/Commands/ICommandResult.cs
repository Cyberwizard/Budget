using System.Collections.Generic;

namespace Budget.Business.Interfaces.Commands {

	public interface ICommandResult {

		CommandResult Result { get; }
		ICollection<string> Messages { get; }

	}

}
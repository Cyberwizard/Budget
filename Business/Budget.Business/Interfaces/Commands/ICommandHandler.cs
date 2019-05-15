using System.Threading.Tasks;

namespace Budget.Business.Interfaces.Commands {

	public interface ICommandHandler<TCommand> {

		Task<ICommandResult> Handle(TCommand command);

	}

}
using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{
    public abstract class BaseCommandHandler<TCommand, TResponse> : ICommandHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
    {
        private readonly IUnitOfWork _unitOfWork;

        protected BaseCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<OperationResult<TResponse>> Handle(TCommand request, CancellationToken cancellationToken)
        {

            // Step 1: Execute core operation
            var operationResult = await ExecuteAsync(request, cancellationToken);
            if (!operationResult.IsSuccess)
            {
                return operationResult; // Return failure result
            }

            // Step 2: Commit Unit of Work
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            // Step 3: Dispatch Domain Events


            // Step 4: Return Result
            return operationResult;

        }

        /// <summary>
        /// Executes the core operation logic for the command.
        /// </summary>
        protected abstract Task<OperationResult<TResponse>> ExecuteAsync(TCommand request, CancellationToken cancellationToken);

    }
}

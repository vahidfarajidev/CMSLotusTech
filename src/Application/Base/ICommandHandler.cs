using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{
    public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, OperationResult<TResponse>>
        where TRequest : ICommand<TResponse>
        where TResponse : notnull
    { }

    public interface ICommandHandler<TRequest> : IRequestHandler<TRequest, OperationResult<Unit>>
        where TRequest : ICommand
    { }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{
    public interface ICommand<TResponse> : IRequest<OperationResult<TResponse>>
        where TResponse : notnull
    { }

    public interface ICommand : IRequest<OperationResult<Unit>> 
    { }
}

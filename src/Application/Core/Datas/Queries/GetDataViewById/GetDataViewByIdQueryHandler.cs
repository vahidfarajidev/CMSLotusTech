using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataViewById
{
    class GetDataViewByIdQueryHandler(IGetDataViewByIdService getDataViewByIdService) : IQueryHandler<GetDataViewByIdQuery, GetDataViewByIdDto>
    {
        private readonly IGetDataViewByIdService _getDataViewByIdService = getDataViewByIdService;

        public async Task<OperationResult<GetDataViewByIdDto>> Handle(GetDataViewByIdQuery request, CancellationToken cancellationToken)
        {
            var getDataViewByIdDto = await _getDataViewByIdService.Handle(request.id, cancellationToken);

            if (getDataViewByIdDto == null)
                return OperationResult<GetDataViewByIdDto>.Failure("Data not found.");

            return OperationResult<GetDataViewByIdDto>.Success(getDataViewByIdDto);
        }
    }
}

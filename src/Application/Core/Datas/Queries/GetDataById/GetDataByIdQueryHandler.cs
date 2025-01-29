using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Core.Datas.Queries.GetDataById
{
    class GetDataByIdQueryHandler(IGetDataByIdService getDataByIdService) : IQueryHandler<GetDataByIdQuery, GetDataByIdDto>
    {
        private readonly IGetDataByIdService _getDataByIdService = getDataByIdService;

        public async Task<OperationResult<GetDataByIdDto>> Handle(GetDataByIdQuery request, CancellationToken cancellationToken)
        {
            var getDataByIdDto = await _getDataByIdService.Handle(request.id, cancellationToken);

            if (getDataByIdDto == null)
                return OperationResult<GetDataByIdDto>.Failure("Data not found.");

            return OperationResult<GetDataByIdDto>.Success(getDataByIdDto);
        }
    }
}

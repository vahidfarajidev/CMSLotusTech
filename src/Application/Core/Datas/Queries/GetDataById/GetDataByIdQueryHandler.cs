using Application.Base;
using Application.Core.Datas.Queries.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataById
{
    class GetDataByIdQueryHandler(IDataQueryService dataQueryService, IMapper mapper) : IQueryHandler<GetDataByIdQuery, DataDto>
    {
        private readonly IDataQueryService _dataQueryService = dataQueryService;
        private readonly IMapper _mapper = mapper;

        public async Task<OperationResult<DataDto>> Handle(GetDataByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _dataQueryService.GetDataById(request.id);

            if (data == null)
                return OperationResult<DataDto>.Failure("Data not found.");

            var dataDto = _mapper.Map<DataDto>(data);
            return OperationResult<DataDto>.Success(dataDto);
        }
    }
}

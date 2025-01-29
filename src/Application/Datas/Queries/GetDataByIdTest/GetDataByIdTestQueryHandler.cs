using Application.Base;
using Application.Datas.Dtos;
using AutoMapper;
using Domain.Datas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Queries.GetDataById
{
    class GetDataByIdTestQueryHandler : IQueryHandler<GetDataByIdTestQuery, DataDtoTest>
    {
        private readonly IDataRepository _dataRepository;
        private readonly IMapper _mapper;

        public GetDataByIdTestQueryHandler(IDataRepository dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        public async Task<OperationResult<DataDtoTest>> Handle(GetDataByIdTestQuery request, CancellationToken cancellationToken)
        {
            var data = await _dataRepository.GetDataByIdTestAsync(request.id, cancellationToken);
            if (data == null)
                return OperationResult<DataDtoTest>.Failure("Data not found.");

            var dataDto = _mapper.Map<DataDtoTest>(data);
            return OperationResult<DataDtoTest>.Success(dataDto);
        }
    }
}

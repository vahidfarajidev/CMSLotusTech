using Application.Base;
using Application.Datas.Services;
using Domain.Base;
using Domain.Datas.Models;
using Domain.Datas.Repositories;
using Domain.Datas.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Application.Datas.Commands.CreateData
{
    public class CreateDataCommandHandler : BaseCommandHandler<CreateDataCommand, Guid>
    {
        private readonly IDataRepository _dataRepository;
        private readonly IDataDomainService _dataDomainService;
        private Data? _createdData;

        public CreateDataCommandHandler(
            IDataRepository dataRepository,
            IDataDomainService dataDomainService,
            IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dataRepository = dataRepository;
            _dataDomainService = dataDomainService;
        }

        protected override async Task<OperationResult<Guid>> ExecuteAsync(CreateDataCommand request, CancellationToken cancellationToken)
        {
            // Step 1: Core operation
            if (!await _dataDomainService.DataCategoryExists(request.DataCategoryId))
                return OperationResult<Guid>.Failure("Invalid DataCategoryId");
            
            if (!await _dataDomainService.AuthorExists(request.AuthorId))
                return OperationResult<Guid>.Failure("Invalid AuthorId");

            Data _createdData = Data.Create(request.DataTitle, request.DataSummary, request.DataBody, request.DataStatus,
                request.DataCategoryId, request.AuthorId, request.CreatedBy);

            await _dataRepository.AddAsync(_createdData, cancellationToken);

            return OperationResult<Guid>.Success(_createdData.Id);
        }
    }
}

using Application.Core.Datas.Commands.CreateData;
using Application.Core.Datas.Queries.GetDataById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CMSLotusTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateData([FromBody] CreateDataCommand command)
        {
            var result = await _mediator.Send(command);

            if (result.IsFailure)
                return BadRequest(new { error = result.Error });

            return Ok(result.Value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDataById(Guid id)
        {
            var operationResult = await _mediator.Send(new GetDataByIdQuery(id));

            if (operationResult.IsFailure)
                return NotFound(new { error = operationResult.Error });

            return Ok(operationResult.Value);
        }
    }
}

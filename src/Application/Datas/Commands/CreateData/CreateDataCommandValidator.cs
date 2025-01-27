using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Commands.CreateData
{
    public class CreateDataCommandValidator : AbstractValidator<CreateDataCommand>
    {
        public CreateDataCommandValidator()
        {
            RuleFor(d => d.DataTitle)
                .NotEmpty().WithMessage("Title is required.")
                .NotNull().WithMessage("Title is required.");
            RuleFor(d => d.DataSummary)
                .NotEmpty().WithMessage("Summary is required.")
                .NotNull().WithMessage("Summary is required.");
        }
    }
}
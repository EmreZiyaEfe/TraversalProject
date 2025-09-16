using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;

namespace Traversal.Business.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please Enter Name of Guide");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please Enter Name of Guide max 30 Chars.");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Please Enter Name of Guide min 10 Chars.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please Enter Description of Guide");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please Enter Image of Guide");
        }
    }
}

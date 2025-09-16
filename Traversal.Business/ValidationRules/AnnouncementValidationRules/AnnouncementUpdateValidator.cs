using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTO.DTOs.AnnouncementDtos;

namespace Traversal.Business.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please enter your announcement title");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Please enter your announcement content");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Please enter your announcement title min 3 chars");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Please enter your announcement title max 20 chars");
        }
    }
}

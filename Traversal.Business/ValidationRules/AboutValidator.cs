using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;

namespace Traversal.Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
            RuleFor(x => x.FirstImage).NotEmpty().WithMessage("Lütfen resim seçin");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama girin!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen açıklamayı ksıaltın!");



        }
    }
}

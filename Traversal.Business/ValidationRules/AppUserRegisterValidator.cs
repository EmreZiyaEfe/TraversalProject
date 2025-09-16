using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTO.DTOs.AppUserDTOs;

namespace Traversal.Business.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<ApppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter your name.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Please enter your surname.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Please enter your username.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Please enter your mail.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Please enter your password.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Please enter your confirm password.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Please enter your username min 3 chars");
            RuleFor(x => x.UserName).MaximumLength(10).WithMessage("Please enter your username mac 10 chars");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Password and confirm password not same");
        }
    }
}

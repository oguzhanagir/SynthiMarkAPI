using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.AdvertisingTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.AdvertisingTypes
{
    public class CreateAdvertisingTypeValidator : AbstractValidator<VMCreateAdvertisingType>
    {
        public CreateAdvertisingTypeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Reklam tipi adı boş olamaz").MaximumLength(150).WithMessage("Reklam tipi adı maksimum 150 karakter olmalıdır");
            
        }
    }
}

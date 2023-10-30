using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Advertisings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Advertisings
{
    public class CreateAdvertisingValidator : AbstractValidator<VMCreateAdvertising>
    {
        public CreateAdvertisingValidator()
        {
            
            RuleFor(x=>x.Title).NotEmpty().NotNull().WithMessage("Reklam başlığı boş olamaz.").MaximumLength(250).WithMessage("Reklam başlığı maksimum 250 karakter olmalıdır.");
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Reklam açıklaması boş olamaz.");
            RuleFor(x => x.AdvertisingType).NotEmpty().NotNull().WithMessage("Reklam tipi boş olamaz.");
        }
    }
}

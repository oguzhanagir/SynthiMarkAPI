using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Seos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Seos
{
    public class CreateSeoValidator : AbstractValidator<VMCreateSeo>
    {
        public CreateSeoValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Seo başlığı boş olamaz").MaximumLength(150).WithMessage("Seo başlığı maksimum 150 karakter olmalıdır.");
            RuleFor(x => x.AuthorInfo).NotNull().NotEmpty().WithMessage("Seo yazar bilgisi boş olamaz").MaximumLength(150).WithMessage("Seo yazar bilgisi maksimum 150 karakter olmalıdır.");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Seo açıklaması boş olamaz.").MaximumLength(250).WithMessage("Seo açıklaması maksimum 250 karakter olmalıdır.");

        }
    }
}

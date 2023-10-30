using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Products
{
    public class UpdateProductValidator : AbstractValidator<VMUpdateProduct>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Ürün başlığı boş olamaz.").MaximumLength(150).WithMessage("Ürün başlığı maksimum 150 karakter olmalıdır.");
            RuleFor(x => x.SubDescription).NotNull().NotEmpty().WithMessage("Ürün alt açıklaması boş olamaz.").MaximumLength(250).WithMessage("Ürün alt açıklaması maksimum 250 karakter olmalıdır.");
            RuleFor(x => x.Features).NotNull().NotEmpty().WithMessage("Ürün özellikleri boş olamaz.").MaximumLength(250).WithMessage("Ürün özellikleri maksimum 250 karakter olmalıdır.");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Ürün açıklaması boş olamaz.");
        }
    }
}

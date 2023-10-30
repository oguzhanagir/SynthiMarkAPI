using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Videos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Videos
{
    public class CreateVideoValidator : AbstractValidator<VMCreateVideo>
    {
        public CreateVideoValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Video başlığı boş olamaz.").MaximumLength(350).WithMessage("Video başlığı maksimum 350 karakter olmalıdır.");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Video açıklaması boş olamaz.");
            RuleFor(x => x.TagList).NotNull().NotEmpty().WithMessage("Video etiket listesi boş olamaz").MaximumLength(350).WithMessage("Video etiket listesi maksimum 350 karakter olmalıdır.");

        }
    }
}

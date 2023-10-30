using FluentValidation;
using SynthiMarkAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.VideoIdeas
{
    public class UpdateVideoIdeaValidator : AbstractValidator<VMUpdateVideoIdea>
    {
        public UpdateVideoIdeaValidator()
        {
            RuleFor(x => x.Content).NotEmpty().NotNull().WithMessage("Video fikir içeriği boş olamaz").MaximumLength(350).WithMessage("Video fikir içeriği maksimum 350 karakter olmalıdır.");

        }
    }
}

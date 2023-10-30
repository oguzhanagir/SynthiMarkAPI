using FluentValidation;
using SynthiMarkAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.PostIdeas
{
    public class CreatePostIdeaValidator : AbstractValidator<VMCreatePostIdea>
    {
        public CreatePostIdeaValidator()
        {
            RuleFor(x=>x.Content).NotEmpty().NotNull().WithMessage("Post fikirlerinin içeriği boş olamaz").MaximumLength(500).WithMessage("Post fikirlerinin içeriği maksimum 500 olmalıdır.");
        }
    }
}

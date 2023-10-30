using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Blogs
{
    public class CreateBlogValidator : AbstractValidator<VMCreateBlog>
    {
        public CreateBlogValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Blog başlığı boş olamaz").MaximumLength(200).WithMessage("Blog başlığı maksimum 200 karakter olmalıdır");
            RuleFor(x => x.SubDescription).NotNull().NotEmpty().WithMessage("Blog alt açıklaması boş olamaz").MaximumLength(300).WithMessage("Blog alt açıklaması maksimum 300 karakter olmalıdır.");
        }
    }
}

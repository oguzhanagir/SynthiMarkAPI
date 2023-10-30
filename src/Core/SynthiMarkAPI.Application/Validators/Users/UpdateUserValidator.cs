using FluentValidation;
using SynthiMarkAPI.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Validators.Users
{
    public class UpdateUserValidator : AbstractValidator<VMUpdateUser>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.FullName).NotNull().NotEmpty().WithMessage("Kullanıcı ad ve soyad boş olamaz").MaximumLength(150).WithMessage("Kullanıcı ad ve soyad maksimum 150 karakter olmalıdır.");
            RuleFor(x => x.Mail).NotNull().NotEmpty()
                .WithMessage("Kullanıcı mail adresi boş olamaz")
                .EmailAddress().WithMessage("Mail adresi olmalıdır.")
                .MaximumLength(150).WithMessage("Kullanıcı mail adresi maksimum 150 karakter olmalıdır.");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Kullanıcı şifresi boş olamaz").MinimumLength(5).MaximumLength(150).WithMessage("Kullanıcı şifresi 5 ile 150 karakter arasında olmalıdır.");
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty().WithMessage("Kullanıcı telefon numarası boş olamaz").MaximumLength(15).WithMessage("Kullanıcı telefon numarası maksimum 15 karakter olmalıdır.");
        }
    }
}

using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Linq;

namespace BussinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(20).MinimumLength(8).WithMessage("Görsel başlığı boş geçilemez ve 8 ile 20 karakter aralığında olmalıdır.");
            RuleFor(x => x.Descriprion).MaximumLength(50).MinimumLength(20).WithMessage("Görsel açıklaması boş geçilemez ve 20 ile 50 karakter aralığında olmalıdır.");
            RuleFor(x => x.ImageUrl).MinimumLength(5).WithMessage("Görsel başlığı boş geçilemez");
        }
    }
}

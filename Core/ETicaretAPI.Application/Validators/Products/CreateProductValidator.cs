using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                    .MaximumLength(150)
                    .MinimumLength(5)
                        .WithMessage("Ürün adı 5-150 karakter olmalıdır.");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen stock bilgisini boş geçmeyiniz.")
                .Must(s => s > -1)
                    .WithMessage("Lütfen stock bilgisini adam gbi giriniz.");
            RuleFor(p => p.Price)
      .NotEmpty()
      .NotNull()
          .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
      .Must(s => s > -1)
          .WithMessage("Lütfen fiyat bilgisini adam gbi giriniz.");

        }
    }
}

using FluentValidation;
using SSTTEK.DTO;
using SSTTEK.Models;

namespace SSTTEK.Validators;

public class SaveUpdateBookDTOValidator : AbstractValidator<SaveUpdateBookDTO>
{
    public SaveUpdateBookDTOValidator()
    {
        RuleFor(x=>x.Title).NotEmpty().WithMessage("Title cannot be empty").NotNull().WithMessage("Title cannot be empty");
        RuleFor(x=>x.Author).NotEmpty().WithMessage("Author cannot be empty").NotNull().WithMessage("Author cannot be empty");
    }
}
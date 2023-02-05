using Entities.Concretes;
using FluentValidation;

namespace Business.Validations
{
    public class ComputerValidation : AbstractValidator<Computer>
    {
        public ComputerValidation()
        {
            RuleFor(c => c.Brand).NotEmpty();
            RuleFor(c => c.Model).MinimumLength(3);
        }
    }
}

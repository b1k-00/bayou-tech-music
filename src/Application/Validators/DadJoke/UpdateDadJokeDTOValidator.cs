using Application.DTOs.DadJoke;
using FluentValidation;

namespace Application.Validators.DadJoke;

public class UpdateDadJokeDTOValidator : AbstractValidator<DadJokeDTO>
{
    public UpdateDadJokeDTOValidator()
    {
        //There is code here that is identical to code in CreateDadJokeValidator. 
        //These validators should be refactored so that this code is not repeated.
        //This is the DRY principle - D(on't) R(epeat) Y(ourself)

        RuleFor(dj => dj.Id)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0");

        RuleFor(dj => dj.Setup)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        RuleFor(dj => dj.Punchline)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        RuleFor(dj => dj.Rating)
            .InclusiveBetween(1, 5)
            .When(dj => dj.Rating != null);
    }
}

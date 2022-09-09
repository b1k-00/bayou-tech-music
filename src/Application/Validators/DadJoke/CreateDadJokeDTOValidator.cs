using Application.DTOs.DadJoke;
using FluentValidation;

namespace Application.Validators.DadJoke;

public class CreateDadJokeDTOValidator : AbstractValidator<CreateDadJokeDTO>
{
    public CreateDadJokeDTOValidator()
    {
        //There is code here that is identical to code in UpdateDadJokeValidator. 
        //These validators should be refactored so that this code is not repeated.
        //This is the DRY principle - D(on't) R(epeat) Y(ourself)

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

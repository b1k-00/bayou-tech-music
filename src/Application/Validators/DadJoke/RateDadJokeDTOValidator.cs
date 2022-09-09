using Application.DTOs.DadJoke;
using FluentValidation;

namespace Application.Validators.DadJoke;

public class RateDadJokeDTOValidator : AbstractValidator<DadJokeRatingDTO>
{
    public RateDadJokeDTOValidator()
    {
        //There is code here that is identical to code in CreateDadJokeValidator. 
        //These validators should be refactored so that this code is not repeated.

        RuleFor(dj => dj.Id)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0");

        RuleFor(dj => dj.Rating)
            .InclusiveBetween(1, 5).WithMessage("{PropertyName} must be between 1 and 5");
    }
}

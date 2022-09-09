using Application.Persistence;
using Application.Requests.DadJoke.Commands;
using Application.Validators.DadJoke;
using AutoMapper;
using MediatR;

namespace Application.Handlers.DadJoke.Commands;

public class RateDadJokeCommandHandler : IRequestHandler<RateDadJokeCommand, Unit>
{
    private readonly IDadJokeRepository _dadJokeRepository;
    private readonly IMapper _mapper;

    public RateDadJokeCommandHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
    {
        _dadJokeRepository = dadJokeRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(RateDadJokeCommand request, CancellationToken cancellationToken)
    {
        var validator = new RateDadJokeDTOValidator();
        var validationResult = await validator.ValidateAsync(request.DadJokeRatingDTO);

        if (!validationResult.IsValid)
        {
            //We would want to throw a real, typed exception here with a nice message
            //That is left as an exercise for the reader
            throw new Exception();
        }

        await _dadJokeRepository.RateDadJokeAsync(request.DadJokeRatingDTO.Id, request.DadJokeRatingDTO.Rating);

        //Unit is used in place of NULL
        return Unit.Value;
    }
}

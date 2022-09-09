using Application.Persistence;
using Application.Requests.DadJoke.Commands;
using Application.Validators.DadJoke;
using AutoMapper;
using MediatR;

namespace Application.Handlers.DadJoke.Commands;

public class UpdateDadJokeCommandHandler : IRequestHandler<UpdateDadJokeCommand, Unit>
{
    private readonly IDadJokeRepository _dadJokeRepository;
    private readonly IMapper _mapper;

    public UpdateDadJokeCommandHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
    {
        _dadJokeRepository = dadJokeRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateDadJokeCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateDadJokeDTOValidator();
        var validationResult = await validator.ValidateAsync(request.DadJokeDTO);

        if (!validationResult.IsValid)
        {
            //We would want to throw a real, typed exception here with a nice message
            //That is left as an exercise for the reader
            throw new Exception();
        }

        var existingDadJoke = await _dadJokeRepository.GetAsync(request.Id);

        if (existingDadJoke != null)
        {
            var dadJoke = _mapper.Map<Domain.DadJoke>(request.DadJokeDTO);
            await _dadJokeRepository.UpdateAsync(dadJoke);

            //_mapper.Map(request.DadJokeDTO, existingDadJoke);
            //await _dadJokeRepository.UpdateAsync(existingDadJoke);
        }
        else
        {
            //DadJoke doesn't exist, so we can't update it.
            //Whatever we would do in that instance is dependent on business rules.
            //Do we create it? Throw an error? Ignore it? Ask the product owner!
        }

        //Unit is used in place of NULL
        return Unit.Value;
    }
}

using Application.Persistence;
using Application.Requests.DadJoke.Commands;
using Application.Validators.DadJoke;
using AutoMapper;
using MediatR;

namespace Application.Handlers.DadJoke.Commands;

public class CreateDadJokeCommandHandler : IRequestHandler<CreateDadJokeCommand, int>
{
    private readonly IDadJokeRepository _dadJokeRepository;
    private readonly IMapper _mapper;

    public CreateDadJokeCommandHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
    {
        _dadJokeRepository = dadJokeRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateDadJokeCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateDadJokeDTOValidator();
        var validationResult = await validator.ValidateAsync(request.CreateDadJokeDTO);

        if(!validationResult.IsValid)
        {
            //We would want to throw a real, typed exception here with a nice message
            //That is left as an exercise for the reader
            throw new Exception();
        }

        var dadJoke = _mapper.Map<Domain.DadJoke>(request.CreateDadJokeDTO);
        var createdDadJoke = await _dadJokeRepository.AddAsync(dadJoke);
        return createdDadJoke.Id;

        //Room for improvement? - Instead of returning the id of the created DadJoke, we could create a
        //standard response object that communicates some information about how the operation went. 
        //Properties like success, errors, or messages could be used to more elegantly handle errors for instance.
    }
}

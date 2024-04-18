//using Application.Persistence;
//using Application.Requests.DadJoke.Commands;
//using AutoMapper;
//using MediatR;

//namespace Application.Handlers.DadJoke.Commands;

//public class DeleteDadJokeCommandHandler : IRequestHandler<DeleteDadJokeCommand>
//{
//    private readonly IDadJokeRepository _dadJokeRepository;
//    private readonly IMapper _mapper;

//    public DeleteDadJokeCommandHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
//    {
//        _dadJokeRepository = dadJokeRepository;
//        _mapper = mapper;
//    }

//    public async Task<Unit> Handle(DeleteDadJokeCommand request, CancellationToken cancellationToken)
//    {
//        await _dadJokeRepository.DeleteAsync(request.Id);

//        return Unit.Value;
//    }
//}

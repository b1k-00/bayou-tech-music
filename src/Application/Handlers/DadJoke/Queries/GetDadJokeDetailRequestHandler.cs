//using Application.DTOs.DadJoke;
//using Application.Persistence;
//using Application.Requests.DadJoke.Queries;
//using AutoMapper;
//using MediatR;

//namespace Application.Handlers.DadJoke.Queries;

//public class GetDadJokeDetailRequestHandler : IRequestHandler<GetDadJokeDetailRequest, DadJokeDTO>
//{
//    private readonly IDadJokeRepository _dadJokeRepository;
//    private readonly IMapper _mapper;

//    public GetDadJokeDetailRequestHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
//    {
//        _dadJokeRepository = dadJokeRepository;
//        _mapper = mapper;
//    }

//    public async Task<DadJokeDTO> Handle(GetDadJokeDetailRequest request, CancellationToken cancellationToken)
//    {
//        var dadJoke = await _dadJokeRepository.GetAsync(request.Id);
//        return _mapper.Map<DadJokeDTO>(dadJoke);
//    }
//}

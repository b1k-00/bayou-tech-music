//using Application.DTOs.DadJoke;
//using Application.Persistence;
//using Application.Requests.DadJoke.Queries;
//using AutoMapper;
//using MediatR;

//namespace Application.Handlers.DadJoke.Queries;

//public class GetDadJokeListRequestHandler : IRequestHandler<GetDadJokeListRequest, List<DadJokeDTO>>
//{
//    private readonly IDadJokeRepository _dadJokeRepository;
//    private readonly IMapper _mapper;

//    public GetDadJokeListRequestHandler(IDadJokeRepository dadJokeRepository, IMapper mapper)
//    {
//        _dadJokeRepository = dadJokeRepository;
//        _mapper = mapper;
//    }

//    public async Task<List<DadJokeDTO>> Handle(GetDadJokeListRequest request, CancellationToken cancellationToken)
//    {
//        var dadJokes = await _dadJokeRepository.GetAllAsync();
//        return _mapper.Map<List<DadJokeDTO>>(dadJokes);
//    }
//}

using Application.DTOs.DadJoke;
using MediatR;

namespace Application.Requests.DadJoke.Queries;

public class GetDadJokeListRequest : IRequest<List<DadJokeDTO>>
{
}

using MediatR;

namespace Application.Requests.DadJoke.Commands;

public class DeleteDadJokeCommand: IRequest
{
    public int Id { get; set; }
}

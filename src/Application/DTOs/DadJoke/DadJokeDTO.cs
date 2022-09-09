using System;

namespace Application.DTOs.DadJoke;

public class DadJokeDTO : BaseDTO
{
    public string Setup { get; set; }
    public string Punchline { get; set; }
    public int? Rating { get; set; }
}

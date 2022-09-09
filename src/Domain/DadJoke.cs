using System;

namespace Domain;

public class DadJoke : BaseEntity
{
    public string Setup { get; set; }
    public string Punchline { get; set; }
    public int? Rating { get; set; }
}

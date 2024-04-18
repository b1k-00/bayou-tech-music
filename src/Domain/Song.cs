using System;

namespace Domain;

public class Song : BaseEntity
{
    public string Title { get; set; }

    public Artist Artist { get; set; }
    public TimeSpan Duration { get; set; }

    public DateTime ReleaseDate { get; set; }

    //I want this to have the option to be null
    public string Features { get; set; } 

    public string Producer {  get; set; }


}

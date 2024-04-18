using System;
using System.Reflection.Emit;

namespace Domain;

public class Album : BaseEntity
{
    public string Title { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public Artist Artist { get; set; }

    public List<Song> Songs { get; set; }
    public MusicLabel MusicLabel { get; set; }

    public TimeSpan Length { get; set; }
}

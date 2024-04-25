using System;
using System.Reflection.Emit;

namespace Domain;

public class Album : BaseEntity
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int ArtistId { get; set; }

    public int MusicLabelId { get; set; }


}

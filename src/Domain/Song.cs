using System;

namespace Domain;

public class Song : BaseEntity
{
    public string Title { get; set; }

    public int ArtistId { get; set; }

    public DateTime ReleaseDate { get; set; }

    public int AlbumId { get; set; }

    //I want this to have the option to be null
    public string? Features { get; set; } 

    public string? Producer {  get; set; }


}

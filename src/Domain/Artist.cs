using System;

namespace Domain;

public class Artist : BaseEntity
{
    public string ArtistName { get; set; }

    public string Genre { get; set; }

    public DateTime BirthDate { get; set; }

    public string Origin { get; set; }


}

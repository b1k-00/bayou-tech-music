using System;

namespace Domain;

public class Artist : BaseEntity
{
    public string Name { get; set; }

    public string Genre { get; set; }

    public DateOnly BirthDate { get; set; }

    public string Origin { get; set; }


}

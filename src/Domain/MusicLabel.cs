using System;

namespace Domain;

public class MusicLabel : BaseEntity
{
    public string LabelName { get; set; }
    public string Owner { get; set; }
    public string Company { get; set; }

}


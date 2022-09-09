namespace Domain;

/// <summary>
/// This class is abstract so you can't instantiate it and should only be used as the base class for other entities
/// </summary>
public abstract class BaseEntity
{
    public int Id { get; set; }
}

using System;

namespace Application.DTOs;

/// <summary>
/// Base case to use for DTOs. This is mostly here for demonstration. Actual use of this Base DTO is up to anyone implementing this project.
/// </summary>
public abstract class BaseDTO
{
    public int Id { get; set; }
}

namespace Domain.Base;

/// <summary>
/// Базовая сущность
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Уникальный идентефикатор.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// Дата и время создания сущности.
    /// </summary>
    public DateTime CreatedAt { get; init; }
}
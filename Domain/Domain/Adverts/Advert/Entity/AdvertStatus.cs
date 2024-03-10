namespace Domain.Adverts.Advert.Entity;

/// <summary>
/// Статус обьявления
/// </summary>
public class AdvertStatus
{
    /// <summary>
    /// Уникальный идентефикатор.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Описание статуса, например "Опубликовано".
    /// </summary>
    public string Description { get; set; }
}
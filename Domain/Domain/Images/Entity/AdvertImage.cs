using Domain.Base;

namespace Domain.Images.Entity;

/// <summary>
/// Картинка, связанная с обьявлением
/// </summary>
public class AdvertImage : BaseEntity
{
    /// <summary>
    /// Внешний ключ для таблицы "Advert".
    /// </summary>
    public Guid AdvertId { get; init; }
    
    /// <summary>
    /// Бинарные данные jpeg картинки.
    /// </summary>
    public char[] Bin { get; init; }
}
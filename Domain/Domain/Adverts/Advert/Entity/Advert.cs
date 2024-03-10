using Domain.Base;

namespace Domain.Adverts.Advert.Entity;

/// <summary>
/// Обьявления пользователей
/// </summary>
public class Advert : BaseEntity
{
    /// <summary>
    /// Внешний ключ для таблицы "User".
    /// Идентификатор пользователя.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Телефон продавца.
    /// </summary>
    public string SellerPhone { get; set; }
    
    /// <summary>
    /// Заголовок объявления
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание объявления.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Цена товара.
    /// </summary>
    public double Price { get; set; }
    
    /// <summary>
    /// Внешний ключ для таблицы "Category".
    /// Идентификатор категории товара.
    /// </summary>
    public Guid CategoryId { get; set; }
    
    /// <summary>
    /// Адрес размещения товара.
    /// </summary>
    public string Address { get; set; }
    
    /// <summary>
    /// Внешний ключ для таблицы "AdvertStatus".
    /// Идентификатор статуса товара.
    /// </summary>
    public Guid ItemStatusId { get; set; }
    
    /// <summary>
    /// Качество товара (от 1 до 5).
    /// </summary>
    public int ItemQuality { get; set; }
    
    /// <summary>
    /// Дата последнего обновления объявления.
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
using Domain.Base;

namespace Domain.Adverts.AdvertReview.Entity;

/// <summary>
/// Отзыв на обьявление
/// </summary>
public class AdvertReview : BaseEntity
{
    /// <summary>
    /// Идентификатор обьявления.
    /// </summary>
    public Guid AdvertId { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя, оставившего отзыв.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Рейтинг данный пользователем.
    /// </summary>
    public int Rating { get; set; }
    
    /// <summary>
    /// Описание отзыва.
    /// </summary>
    public string Message { get; set; }
    
    /// <summary>
    /// Статус отношений продавца и покупателя.
    /// Например, "Сделка состоялась", или
    /// "Не общались".
    /// </summary>
    public Guid AdvertReviewStatusId { get; set; }
    
}
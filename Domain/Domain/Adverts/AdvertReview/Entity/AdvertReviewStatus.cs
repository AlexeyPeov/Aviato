namespace Domain.Adverts.AdvertReview.Entity;

/// <summary>
/// Статус отношений продавца и покупателя
/// на момент создания отзыва.
/// </summary>
public class AdvertReviewStatus
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Описание статуса, например "Сделка сорвалась".
    /// </summary>
    public string Description { get; set; }
}
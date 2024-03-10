namespace Domain.Categories.Entity;

/// <summary>
/// Категория товаров
/// </summary>
public class Category
{
    /// <summary>
    /// Уникальный идентефикатор категории.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Название категории, например "Авто".
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Внешний ключ для таблицы "Category".
    /// Ссылается на ключ другой категории (если есть).
    /// Пример:
    /// Категория "Авто" является родителем категории "Мототехника".
    /// Авто -> Мототехника -> ...
    /// </summary>
    public Guid? ParentId { get; init; }
}
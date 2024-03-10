namespace Domain.Users.Entity;

public class UserRole
{
    /// <summary>
    /// Уникальный идентефикатор.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Описание роли пользователя, например "Админ".
    /// </summary>
    public string Description { get; set; }
}
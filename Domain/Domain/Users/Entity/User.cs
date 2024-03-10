using Domain.Base;

namespace Domain.Users.Entity;

public class User : BaseEntity
{
    /// <summary>
    /// Электронная почта пользователя.
    /// </summary>
    public string email { get; set; }
    
    /// <summary>
    /// Номер телефона пользователя.
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Пароль пользователя. todo: хеширование
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Внешний ключ для таблицы "UserRole".
    /// Роль пользователя, например "Admin".
    /// </summary>
    public Guid RoleId { get; set; }
    
    /// <summary>
    /// Дата изменения. 
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
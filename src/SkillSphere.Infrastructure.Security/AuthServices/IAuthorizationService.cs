namespace SkillSphere.Infrastructure.Security.AuthServices;

/// <summary>
/// Интерфейс для сервиса авторизации, предоставляющего методы для проверки существования пользователя.
/// </summary>
public interface IAuthorizationService
{
    /// <summary>
    /// Проверяет, существует ли пользователь с заданным идентификатором.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <returns>Истинное значение, если пользователь существует; иначе - ложное значение.</returns>
    Task<bool> UserExistsAsync(Guid userId);
}

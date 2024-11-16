namespace SkillSphere.Infrastructure.Security.AuthServices;

/// <summary>
/// Реализация сервиса авторизации для проверки существования пользователя.
/// </summary>
public class AuthorizationService : IAuthorizationService
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="AuthorizationService"/>.
    /// </summary>
    /// <param name="httpClient">Клиент HTTP для выполнения запросов.</param>
    public AuthorizationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <inheritdoc/>
    public async Task<bool> UserExistsAsync(Guid userId)
    {
        var response = await _httpClient.GetAsync($"/api/auth/users/{userId}");
        return response.IsSuccessStatusCode;
    }
}

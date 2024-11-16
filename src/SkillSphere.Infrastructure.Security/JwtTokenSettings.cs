namespace SkillSphere.Infrastructure.Security;

/// <summary>
/// Класс, представляющий настройки JWT токенов.
/// </summary>
public class JwtTokenSettings
{
    /// <summary>
    /// Секретный ключ, используемый для подписи JWT токенов.
    /// </summary>
    public string SecretKey { get; set; }

    /// <summary>
    /// Издатель JWT токенов (issuer). Указывает, кто выдал токен.
    /// </summary>
    public string Issuer { get; set; }

    /// <summary>
    /// Время жизни access токена в минутах.
    /// </summary>
    public double AccessTokenLifetimeInMinutes { get; set; }

    /// <summary>
    /// Время жизни refresh токена в минутах.
    /// </summary>
    public double RefreshTokenLifetimeInMinutes { get; set; }
}
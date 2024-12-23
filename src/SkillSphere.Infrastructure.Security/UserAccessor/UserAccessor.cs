﻿using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace SkillSphere.Infrastructure.Security.UserAccessor;

/// <summary>
/// Сервис для доступа к данным пользователя.
/// </summary>
public class UserAccessor : IUserAccessor
{
    /// <summary>
    /// Авторизированный пользователь.
    /// </summary>
    private readonly ClaimsPrincipal _user;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="UserAccessor"/>.
    /// </summary>
    /// <param name="httpContextAccessor">
    /// Интерфейс для доступа к текущему <see cref="HttpContext"/>, 
    /// содержащему данные о текущем HTTP-запросе.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// Выбрасывается, если <paramref name="httpContextAccessor"/> равен <c>null</c> или если 
    /// <see cref="HttpContext.User"/> в текущем контексте равен <c>null</c>.
    /// </exception>
    public UserAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _user = httpContextAccessor.HttpContext?.User
            ?? throw new ArgumentNullException(nameof(httpContextAccessor));
    }

    /// <inheritdoc/>
    public Guid GetUserId()
    {
        if (Guid.TryParse(_user.Claims.First
            (x => x.Type == ClaimTypes.NameIdentifier).Value, out Guid id))
        {
            return id;
        }

        return Guid.Empty;
    }
}

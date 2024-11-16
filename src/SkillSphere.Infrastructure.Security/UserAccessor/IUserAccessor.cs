namespace SkillSphere.Infrastructure.Security.UserAccessor;

public interface IUserAccessor
{
    /// <summary>
    /// Получить идентификатор пользователя.
    /// </summary>
    /// <returns></returns>
    Guid GetUserId();
}

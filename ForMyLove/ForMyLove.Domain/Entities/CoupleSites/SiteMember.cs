using ForMyLove.Domain.Enums;

namespace ForMyLove.Domain.Entities.CoupleSites;

public sealed class SiteMember
{
    public Guid Id { get; private set; }
    public Guid SiteId { get; private set; }
    public Guid UserId { get; private set; }
    public SiteMemberRole Role { get; private set; }
    public bool CanEditContent { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }

    private SiteMember()
    {
    }

    public SiteMember(
        Guid id,
        Guid siteId,
        Guid userId,
        SiteMemberRole role,
        bool canEditContent,
        DateTimeOffset? createdAt = null)
    {
        Id = id;
        SiteId = siteId;
        UserId = userId;
        Role = role;
        CanEditContent = canEditContent;
        CreatedAt = createdAt ?? DateTimeOffset.UtcNow;
    }

    public bool CanEditSettings()
    {
        return Role == SiteMemberRole.Owner || CanEditContent;
    }
}

namespace ForMyLove.Domain.Entities.Invites;

public sealed class PartnerInvite
{
    public Guid Id { get; private set; }
    public Guid SiteId { get; private set; }
    public string TokenHash { get; private set; } = string.Empty;
    public bool IsUsed { get; private set; }
    public DateTimeOffset ExpiresAt { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? UsedAt { get; private set; }

    private PartnerInvite()
    {
    }

    public PartnerInvite(
        Guid id,
        Guid siteId,
        string tokenHash,
        DateTimeOffset expiresAt,
        DateTimeOffset? createdAt = null)
    {
        Id = id;
        SiteId = siteId;
        TokenHash = tokenHash;
        ExpiresAt = expiresAt;
        CreatedAt = createdAt ?? DateTimeOffset.UtcNow;
    }

    public bool CanBeUsed(DateTimeOffset now)
    {
        return !IsUsed && ExpiresAt > now;
    }

    public void MarkAsUsed(DateTimeOffset? usedAt = null)
    {
        IsUsed = true;
        UsedAt = usedAt ?? DateTimeOffset.UtcNow;
    }
}

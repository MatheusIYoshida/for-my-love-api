namespace ForMyLove.Domain.Entities.CoupleSites;

public sealed class CoupleSite
{
    public Guid Id { get; private set; }
    public string Alias { get; private set; } = string.Empty;
    public string Title { get; private set; } = string.Empty;
    public Guid OwnerUserId { get; private set; }
    public bool IsActive { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset UpdatedAt { get; private set; }

    private CoupleSite()
    {
    }

    public CoupleSite(
        Guid id,
        string alias,
        string title,
        Guid ownerUserId,
        bool isActive = true,
        DateTimeOffset? createdAt = null,
        DateTimeOffset? updatedAt = null)
    {
        Id = id;
        Alias = alias;
        Title = title;
        OwnerUserId = ownerUserId;
        IsActive = isActive;
        CreatedAt = createdAt ?? DateTimeOffset.UtcNow;
        UpdatedAt = updatedAt ?? CreatedAt;
    }
}

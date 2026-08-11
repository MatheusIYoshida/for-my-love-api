namespace ForMyLove.Domain.Entities.Users;

public sealed class User
{
    public Guid Id { get; private set; }
    public string Email { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public string? AvatarUrl { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }

    private User()
    {
    }

    public User(
        Guid id,
        string email,
        string name,
        string passwordHash,
        string? avatarUrl = null,
        DateTimeOffset? createdAt = null)
    {
        Id = id;
        Email = email;
        Name = name;
        PasswordHash = passwordHash;
        AvatarUrl = avatarUrl;
        CreatedAt = createdAt ?? DateTimeOffset.UtcNow;
    }
}

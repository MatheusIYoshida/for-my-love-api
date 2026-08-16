using ForMyLove.Tests.Factories;

namespace ForMyLove.Tests.Domain;

public sealed class PartnerInviteTests
{
    [Fact]
    public void CanBeUsed_WhenInviteIsValid_ReturnsTrue()
    {
        // Arrange
        var now = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var invite = PartnerInviteFactory.Create(now.AddMinutes(10));

        // Act
        var result = invite.CanBeUsed(now);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanBeUsed_WhenInviteIsExpired_ReturnsFalse()
    {
        // Arrange
        var now = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var invite = PartnerInviteFactory.Create(now.AddMinutes(-1));

        // Act
        var result = invite.CanBeUsed(now);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanBeUsed_WhenInviteIsUsed_ReturnsFalse()
    {
        // Arrange
        var now = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var invite = PartnerInviteFactory.Create(now.AddMinutes(10));
        invite.MarkAsUsed(now);

        // Act
        var result = invite.CanBeUsed(now);

        // Assert
        Assert.False(result);
    }

}

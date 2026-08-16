using ForMyLove.Domain.Enums;
using ForMyLove.Tests.Factories;

namespace ForMyLove.Tests.Domain;

public sealed class SiteMemberTests
{
    [Fact]
    public void CanEditSettings_WhenMemberIsOwner_ReturnsTrue()
    {
        // Arrange
        var member = SiteMemberFactory.Create(SiteMemberRole.Owner, canEditContent: false);

        // Act
        var result = member.CanEditSettings();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanEditSettings_WhenPartnerHasPermission_ReturnsTrue()
    {
        // Arrange
        var member = SiteMemberFactory.Create(SiteMemberRole.Partner, canEditContent: true);

        // Act
        var result = member.CanEditSettings();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanEditSettings_WhenPartnerHasNoPermission_ReturnsFalse()
    {
        // Arrange
        var member = SiteMemberFactory.Create(SiteMemberRole.Partner, canEditContent: false);

        // Act
        var result = member.CanEditSettings();

        // Assert
        Assert.False(result);
    }

}

using ForMyLove.Tests.Factories;

namespace ForMyLove.Tests.Domain;

public sealed class CoupleSettingsTests
{
    [Fact]
    public void Update_WhenValidData_UpdatesSettings()
    {
        // Arrange
        var updatedAt = new DateTimeOffset(2026, 2, 1, 0, 0, 0, TimeSpan.Zero);
        var settings = CoupleSettingsFactory.Create();

        // Act
        settings.Update(
            updatedAt,
            "New song",
            "New artist",
            "New phrase",
            "New lyrics",
            updatedAt);

        // Assert
        Assert.Equal(updatedAt, settings.FirstDate);
        Assert.Equal("New song", settings.SongName);
        Assert.Equal("New artist", settings.ArtistName);
        Assert.Equal("New phrase", settings.SongPhrase);
        Assert.Equal("New lyrics", settings.LyricsText);
        Assert.Equal(updatedAt, settings.UpdatedAt);
    }
}

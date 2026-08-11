namespace ForMyLove.Domain.Entities.Settings;

public sealed class CoupleSettings
{
    public Guid Id { get; private set; }
    public Guid SiteId { get; private set; }
    public DateTimeOffset FirstDate { get; private set; }
    public string SongName { get; private set; } = string.Empty;
    public string ArtistName { get; private set; } = string.Empty;
    public string SongPhrase { get; private set; } = string.Empty;
    public string LyricsText { get; private set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset UpdatedAt { get; private set; }

    private CoupleSettings()
    {
    }

    public CoupleSettings(
        Guid id,
        Guid siteId,
        DateTimeOffset firstDate,
        string songName,
        string artistName,
        string songPhrase,
        string lyricsText,
        DateTimeOffset? createdAt = null,
        DateTimeOffset? updatedAt = null)
    {
        Id = id;
        SiteId = siteId;
        FirstDate = firstDate;
        SongName = songName;
        ArtistName = artistName;
        SongPhrase = songPhrase;
        LyricsText = lyricsText;
        CreatedAt = createdAt ?? DateTimeOffset.UtcNow;
        UpdatedAt = updatedAt ?? CreatedAt;
    }

    public void Update(
        DateTimeOffset firstDate,
        string songName,
        string artistName,
        string songPhrase,
        string lyricsText,
        DateTimeOffset? updatedAt = null)
    {
        FirstDate = firstDate;
        SongName = songName;
        ArtistName = artistName;
        SongPhrase = songPhrase;
        LyricsText = lyricsText;
        UpdatedAt = updatedAt ?? DateTimeOffset.UtcNow;
    }
}

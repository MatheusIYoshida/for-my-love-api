using Bogus;
using ForMyLove.Domain.Entities.Settings;

namespace ForMyLove.Tests.Factories;

public static class CoupleSettingsFactory
{
    public static CoupleSettings Create()
    {
        var faker = new Faker("pt_BR");
        var createdAt = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);

        return new CoupleSettings(
            Guid.NewGuid(),
            Guid.NewGuid(),
            createdAt,
            faker.Random.String2(20),
            faker.Random.String2(20),
            faker.Random.String2(20),
            faker.Random.String2(20),
            createdAt,
            createdAt);
    }
}

using Bogus;
using ForMyLove.Domain.Entities.Invites;

namespace ForMyLove.Tests.Factories;

public static class PartnerInviteFactory
{
    public static PartnerInvite Create(DateTimeOffset expiresAt)
    {
        var faker = new Faker("pt_BR");

        return new PartnerInvite(
            faker.Random.Guid(),
            faker.Random.Guid(),
            faker.Random.AlphaNumeric(64),
            expiresAt);
    }
}

using Bogus;
using ForMyLove.Domain.Entities.CoupleSites;
using ForMyLove.Domain.Enums;

namespace ForMyLove.Tests.Factories;

public static class SiteMemberFactory
{
    public static SiteMember Create(SiteMemberRole role, bool canEditContent)
    {
        var faker = new Faker("pt_BR");

        return new SiteMember(
            faker.Random.Guid(),
            faker.Random.Guid(),
            faker.Random.Guid(),
            role,
            canEditContent);
    }
}

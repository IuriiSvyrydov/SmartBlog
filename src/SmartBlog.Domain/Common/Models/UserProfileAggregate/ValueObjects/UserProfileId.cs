
namespace SmartBlog.Domain.Common.Models.UserProfileAggregate.ValueObjects;

public sealed class UserProfileId : ValueObject
{
    public Guid Value { get;  }
    protected UserProfileId()
    { }
    private UserProfileId(Guid value)
    {
        Value = value;
    }
    public static UserProfileId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public static UserProfileId Create(Guid userId)
    { return new(userId); }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

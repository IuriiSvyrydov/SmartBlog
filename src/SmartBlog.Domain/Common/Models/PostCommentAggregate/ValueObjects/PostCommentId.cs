
namespace SmartBlog.Domain.Common.Models.PostCommentAggregate.ValueObjects;

public sealed class PostCommentId : ValueObject
{
    public Guid Value { get;  }

    protected PostCommentId()
    {

    }
    private PostCommentId(Guid value)
    {
        Value = value;
    }
    public static PostCommentId CreateUnique()
    {
        return new (Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
       yield return Value;
    }
}

namespace SmartBlog.Domain.PostAggregate.ValueObjects;

public sealed class PostId : ValueObject
{ 
    public Guid Value { get; set; }
    protected PostId()
    {

    }
    private PostId(Guid value)
    {
        Value = value;
    }
    public static PostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
       yield return Value;
    }
    public static PostId Create(Guid value)
    {
        return  new PostId(value);
    }

    
}

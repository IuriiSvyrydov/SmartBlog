


namespace SmartBlog.Domain.Common.Models.PostInteractionAggregate.ValueObjects
{
    public sealed class PostInteractionId : ValueObject
    {
        public Guid Value { get; set; }
        protected PostInteractionId()
        {

        }
        private PostInteractionId(Guid id)
        {
            Value = id;
        }
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
        public static PostInteractionId Create()
        {
            return new(Guid.NewGuid());
        }
        public static PostInteractionId CreateUnique(Guid value)
        {
            return new PostInteractionId(value);
        }
    }
}

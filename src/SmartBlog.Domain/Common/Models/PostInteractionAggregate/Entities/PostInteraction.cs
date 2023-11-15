using SmartBlog.Domain.Common.Models.PostInteractionAggregate.ValueObjects;


namespace SmartBlog.Domain.Common.Models.PostInteractionAggregate.Entities
{
    public sealed class PostInteraction : Entity<PostInteractionId>
    {
        public PostId PostId { get; private set; }
        public InteractionType InteractionType { get;private set; }
        private PostInteraction()
        {

        }
        private PostInteraction(PostInteractionId id,PostId postId, InteractionType interactionType) : base(id)
        {
            PostId = postId;
            InteractionType = interactionType;
        }
        public static PostInteraction Create(PostId postId,InteractionType interactionType)
        {
            return new(PostInteractionId.Create(), postId, interactionType);
        }
    }
}

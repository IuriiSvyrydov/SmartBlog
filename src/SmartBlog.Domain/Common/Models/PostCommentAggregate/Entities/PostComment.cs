


namespace SmartBlog.Domain.Common.Models.PostCommentAggregate.Entities
{
    public class PostComment : Entity<PostCommentId>
    {
        protected PostComment() { }
        private PostComment(PostCommentId id) : base(id)
        {
        }
    }
}

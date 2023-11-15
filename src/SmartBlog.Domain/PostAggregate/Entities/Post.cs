using SmartBlog.Domain.Common.Models.PostCommentAggregate.Entities;
using SmartBlog.Domain.Common.Models.UserProfileAggregate.Entities;
using SmartBlog.Domain.Common.Models.UserProfileAggregate.ValueObjects;
using SmartBlog.Domain.PostAggregate.ValueObjects;

namespace SmartBlog.Domain.PostAggregate.Entities;



public class Post : Entity<PostId>
{
    #region
    private readonly List<PostComment> _postComments = new();
    #endregion

    public UserProfileId UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }
    public string TextContent { get; private set; }
    public DateTime CreateDate { get; private set; }
    public DateTime LastModified { get; private set; }
    public IReadOnlyList<PostComment> Comments => _postComments.AsReadOnly();;
    
}

using SmartBlog.Domain.Common.Models.PostInteractionAggregate.Entities;

namespace SmartBlog.Domain.PostAggregate.Entities;

public class Post : AggregateRoot<PostId>
{
    #region
    private readonly List<PostComment> _postComments = new();
    private readonly List<PostInteraction> _postInteractions = new();

    #endregion

    public UserProfileId UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }
    public string TextContent { get; private set; }
    public DateTime CreateDate { get; private set; }
    public DateTime LastModified { get; private set; }
    public IReadOnlyList<PostComment> Comments => _postComments.AsReadOnly();
    public IReadOnlyList<PostInteraction> Interactions => _postInteractions.AsReadOnly();


    private Post()
    { }
    private Post(PostId postId, UserProfileId userProfileId,string textContent,UserProfile userProfile):base(postId)
    {
        UserProfileId = userProfileId;
        TextContent = textContent;
        UserProfile = userProfile;
    }
    #region simple methods

    public Post CreatePost(UserProfileId userProfileId, string textContent, UserProfile userProfile)
    {
        return new(PostId.CreateUnique(), userProfileId, textContent, userProfile);
    }
    public void UpdatePost(string newText)
    {
        TextContent = newText;
       LastModified = DateTime.UtcNow;
    }
    public void AddPostCommet(PostComment postComment)
    {
        _postComments.Add(postComment);
    }
    public void RemoveCommentInteraction(PostInteraction postInteraction)
    {
        _postInteractions.Remove(postInteraction);
    }


    #endregion


}

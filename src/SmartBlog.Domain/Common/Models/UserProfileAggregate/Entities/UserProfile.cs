namespace SmartBlog.Domain.Common.Models.UserProfileAggregate.Entities;

public class UserProfile
{
    private UserProfile() { }
   
    public Guid UserProfileId { get; private set; }
    public string IdentityId { get; private set; }
    public BasicInfo BasicInfo { get;  private set; }
    public DateTime? DateCreated { get; private set; }
    public DateTime? DateUpdated { get; private set; }

    public static UserProfile CreateProfile(string identityId, BasicInfo basicInfo)
    {
       return new UserProfile() { IdentityId = identityId, BasicInfo = basicInfo ,DateCreated = DateTime.UtcNow,DateUpdated = DateTime.UtcNow};
    }
    public void UpdateBasicInfo(BasicInfo newInfo)
    {
        BasicInfo = newInfo;
        DateUpdated = DateTime.UtcNow;
        
    }


}



namespace SmartBlog.Domain;

public class Entity<TID> : IEquatable<Entity<TID>> where TID : notnull
{
    public TID Id { get;protected set; }


    public Entity(TID id)
    {
        Id = id;
    }
    protected Entity()
    {

    }

    public bool Equals(Entity<TID>? other)
    {
        return Equals((object?)other);
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public static bool operator==(Entity<TID>lhs, Entity<TID> rhs)
    {
        return Equals(lhs, rhs);
    }
    public static bool operator!=(Entity<TID> lhs, Entity<TID> rhs)
    { return !Equals(lhs, rhs); }
}

namespace SmartBlog.Domain
{
    public abstract class AggregateRoot<TID>: Entity<TID> where TID : notnull
    {
        public TID Value { get; set; }
        public AggregateRoot() { }

        public AggregateRoot(TID id)
        {
            Value = id;
        }

       

    }
}

using SmartBlog.Domain.Common.Models.PostCommentAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authors.Models
{
    public class Author : AggregateRoot
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Comment { get; private set; }

        private Author(string fullName, string email, string comment, Guid createdBy) : base(createdBy)
        {
            Guard(createdBy);
            FullName = fullName;
            Email = email;
            Comment = comment;
        }

        public static Author Create(string fullName, string email, string comment, Guid createdBy)
        {
            var author = new Author(fullName, email, comment, createdBy);
            return author;
        }

        void Guard(Guid createdBy)
        {
            if (createdBy == Guid.Empty)
                throw new Exception("CreatedBy is required!");
        }
    }
}

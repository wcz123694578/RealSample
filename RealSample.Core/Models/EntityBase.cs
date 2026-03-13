using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models
{
    public class EntityBase
    {
        private int _id;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}

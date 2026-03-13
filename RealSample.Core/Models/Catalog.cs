using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models
{
    public class Catalog : EntityBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _parentId;

        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }
    }
}

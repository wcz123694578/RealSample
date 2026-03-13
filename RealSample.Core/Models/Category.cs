using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models {
    public class Category : EntityBase {
        public Category(string name) {
            Name = name;
        }

        public Category(int id, string name) : base(id) {
            Name = name;
        }

        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        private int _parentId;

        public int ParentId {
            get { return _parentId; }
            set { _parentId = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models.Queries {
    public class MediaFileQuery {
        public MediaFileQuery() {
            CategoryId = 0;
        }

        private int _categoryId;

        public int CategoryId {
            get { return _categoryId; }
            set { _categoryId = value; }
        }

        private string _directory = string.Empty;

        public string Directory {
            get { return _directory; }
            set { _directory = value; }
        }
	
    }
}

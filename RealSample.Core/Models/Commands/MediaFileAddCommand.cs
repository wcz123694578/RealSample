using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models.Commands {
    public class MediaFileAddCommand {
        public MediaFileAddCommand(string filePath, int categoryId) {
            FilePath = filePath;
            CategoryId = categoryId;
        }

        public MediaFileAddCommand(string filePath) : this(filePath, 0) { 
        
        }

        private string _filePath;

        public string FilePath {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private int _categoryId;

        public int CategoryId {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
	
    }
}

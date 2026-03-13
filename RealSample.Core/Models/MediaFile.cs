using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models
{
    public class MediaFile : EntityBase
    {
        public MediaFile(string filePath, string hash, int categoryId) {
            FilePath = filePath;
            Hash = _hash;
            CategoryId = categoryId;
        }

        public MediaFile() {

        }

        private string _filePath;
        private string _hash;
        private int _categoryId;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public string Hash
        {
            get { return _hash; }
            set { _hash = value; }
        }


        public int CategoryId {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
	
    }
}

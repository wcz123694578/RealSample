using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models
{
    public class File : EntityBase
    {
        private string _filePath;
        private string _hash;

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
    }
}

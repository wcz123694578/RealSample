using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models.ViewModels {
    public class MediaFileMasterResult {
        public MediaFileMasterResult(
            int id,
            string fileName,
            DateTime createdAt,
            int categoryId,
            string categoryName) {
            Id = id;
            FilePath = fileName;
            CreatedAt = createdAt;
            CategoryId = categoryId;
            categoryName = categoryName;
        }

        public MediaFileMasterResult() {

        }

        private int _id;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }

        private string _filePath = string.Empty;

        public string FilePath {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private DateTime _createdAt;

        public DateTime CreatedAt {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        private int _categoryId;

        public int CategoryId {
            get { return _categoryId; }
            set { _categoryId = value; }
        }

        private string _categoryName = string.Empty;

        public string CategoryName {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using RealSample.Core.Models;

namespace RealSample.DAL.Abstractions {
    public interface IMediaFileDataService {
        int AddMediaFile(string filePath, string hash, int categoryId, DateTime createdAt, DateTime modifiedAt);

        IEnumerable<MediaFile> SelectMediaFiles();
    }
}

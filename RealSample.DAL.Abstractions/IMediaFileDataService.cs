using System;
using System.Collections.Generic;
using System.Text;
using RealSample.Core.Models;
using RealSample.Core.Models.ViewModels;
using RealSample.Core.Models.Queries;

namespace RealSample.DAL.Abstractions {
    public interface IMediaFileDataService {
        int AddMediaFile(string filePath, string hash, int categoryId, DateTime createdAt, DateTime modifiedAt);

        IEnumerable<MediaFileMasterResult> SelectMediaFiles(MediaFileQuery query);

        void DeleteMediaFile(int id);
    }
}

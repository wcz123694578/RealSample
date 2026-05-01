using System;
using System.Collections.Generic;
using System.Text;
using RealSample.Core.Models.Commands;
using RealSample.Core.Models.ViewModels;
using RealSample.Core.Models.Queries;

namespace RealSample.BLL.Abstractions {
    public interface IMediaFileBusinessService {
        int AddMediaFile(MediaFileAddCommand command);
        IEnumerable<MediaFileMasterResult> SelectMediaFiles(MediaFileQuery query);

        void DeleteMediaFile(int id);
    }
}

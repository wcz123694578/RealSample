using System;
using System.Collections.Generic;
using System.Text;
using RealSample.Core.Models.Commands;

namespace RealSample.BLL.Abstractions {
    public interface IMediaFileBusinessService {
        int AddMediaFile(MediaFileAddCommand command);
    }
}

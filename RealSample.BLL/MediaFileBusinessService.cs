using System;
using System.Collections.Generic;
using System.Text;
using RealSample.BLL.Abstractions;
using RealSample.Core.Models.Commands;
using RealSample.DAL.Abstractions;
using RealSample.Ioc;
using RealSample.Core.Models;
using RealSample.Shared;

namespace RealSample.BLL {
    public class MediaFileBusinessService : IMediaFileBusinessService {
        private readonly IMediaFileDataService _mediaFileDataService;

        public MediaFileBusinessService() {
            _mediaFileDataService = ServiceLocator.Get<IMediaFileDataService>();
        }

        #region IMediaFileBusinessService 成员

        public int AddMediaFile(MediaFileAddCommand command) {
            int lines = _mediaFileDataService.AddMediaFile(
                command.FilePath, 
                HashHelper.GetFileSha256(command.FilePath), 
                command.CategoryId, 
                DateTime.Now, 
                DateTime.Now);

            if (lines <= 0) {
                throw new ArgumentException("文件插入错误");
            }

            return lines;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using RealSample.Core.Models;

namespace RealSample.FilePlugin {
    public class Entry : IAssetPlugin {
        #region IAssetPlugin ≥…‘±

        public string GetUniqueId() {
            return "{realsample.fileplugin}";
        }

        #endregion
    }
}

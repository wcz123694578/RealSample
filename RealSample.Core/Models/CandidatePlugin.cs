using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Core.Models
{
    public class CandidatePlugin : EntityBase
    {
        private int _catalogId;

        public int CatalogId
        {
            get { return _catalogId; }
            set { _catalogId = value; }
        }

        private string _pluginUniqueId;

        public string PluginUniqueId
        {
            get { return _pluginUniqueId; }
            set { _pluginUniqueId = value; }
        }
	
    }
}

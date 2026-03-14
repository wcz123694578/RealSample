using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using RealSample.Delegate.Shared;

namespace RealSample.Controls {
    public class CommandViewModel {
        private Bitmap _icon;

        public Bitmap Icon {
            get { return _icon; }
            set { _icon = value; }
        }
	

        private string _description;

        public string Description {
            get { return _description; }
            set { _description = value; }
        }

        private CommandHandler _executor;

        public CommandHandler Executor {
            get { return _executor; }
            set { _executor = value; }
        }
	
    }
}

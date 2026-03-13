using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Controls {
    public delegate void BindCallback(IItemView view, object data);

    public interface IItemView {
        void Bind(object data, BindCallback callback);
        int GetItemHeight();
    }
}

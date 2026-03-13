using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealSample.Controls {
    public delegate IItemView CreateItemViewCallback();

    public partial class ItemsControl : Panel {
        public event EventHandler SelectedIndexChanged;

        private List<object> _itemsSource = new List<object>();

        private List<IItemView> _viewPool = new List<IItemView>();

        public int GetItemHeight() { return 38; }

        private int _selectedIndex = -1;

        public int SelectedIndex {
            get { return _selectedIndex; }
        }
	

        public CreateItemViewCallback _createItemView;
        public BindCallback _binder;

        public void SetCreateItemViewCallback(CreateItemViewCallback callback) {
            _createItemView = callback;
        }

        protected virtual void OnSelectedIndexChanged(EventArgs e) {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);
        }

        public ItemsControl() {
            InitializeComponent();
        }

        public void SetData(List<object> itemsSource) {
            _itemsSource = itemsSource;

            this.AutoScrollMinSize = new Size(0, itemsSource.Count * GetItemHeight());

            UpdateVisible();
        }

        public void SetBinder(BindCallback binder) {
            _binder = binder;
        }

        protected override void OnScroll(ScrollEventArgs se) {
            base.OnScroll(se);
            UpdateVisible();
        }

        private void UpdateVisible() {
            if (_itemsSource == null)
                return;

            int firstIndex = this.VerticalScroll.Value / GetItemHeight();

            int visibleCount = this.Height / GetItemHeight() + 2;

            bool flag = EnsurePool(visibleCount);

            if (!flag) return;

            for (int i = 0; i < visibleCount; i++) {
                int dataIndex = firstIndex + i;
                Control view = _viewPool[i] as Control;

                if (dataIndex >= _itemsSource.Count) {
                    
                    view.Visible = false;
                    continue;
                }

                if (dataIndex == _selectedIndex) {
                    view.BackColor = SystemColors.Highlight;
                    view.ForeColor = SystemColors.HighlightText;
                } else {
                    view.BackColor = SystemColors.Control;
                    view.ForeColor = SystemColors.ControlText;
                }

                view.Visible = true;

                (_viewPool[i]).Bind(_itemsSource[dataIndex], _binder);

                view.Top = dataIndex * _viewPool[i].GetItemHeight() - this.VerticalScroll.Value;
            }
        }

        private bool EnsurePool(int count) {
            if (_createItemView == null) return false;

            while (_viewPool.Count < count) {
                IItemView view = _createItemView();
                Control control = view as Control;
                control.Width = this.ClientSize.Width;

                RegisterClick(control);

                this.Controls.Add(control);
                _viewPool.Add(view);
            }

            return true;
        }

        private void RegisterClick(Control ctrl) {
            ctrl.Click += Internal_Item_Click;

            foreach (Control c in ctrl.Controls)
                RegisterClick(c);
        }

        private void Internal_Item_Click(object sender, EventArgs e) {
            Control ctrl = sender as Control;

            // 找到对应的 ItemView
            while (ctrl != null && !_viewPool.Contains(ctrl as IItemView))
                ctrl = ctrl.Parent;

            if (ctrl == null)
                return;

            int viewIndex = _viewPool.IndexOf(ctrl as IItemView);

            if (viewIndex < 0)
                return;

            int firstIndex = this.VerticalScroll.Value / GetItemHeight();

            int dataIndex = firstIndex + viewIndex;

            if (dataIndex >= 0 && dataIndex < _itemsSource.Count) {
                if (_selectedIndex != dataIndex) {
                    _selectedIndex = dataIndex;

                    UpdateVisible();

                    OnSelectedIndexChanged(EventArgs.Empty);
                }
            }
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            foreach (IItemView view in _viewPool)
                (view as Control).Width = this.ClientSize.Width;
            UpdateVisible();
        }

        protected override void OnPaint(PaintEventArgs pe) {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint(pe);
        }

        [Browsable(false)]
        public object SelectedItem {
            get {
                if (_selectedIndex < 0 || _selectedIndex >= _itemsSource.Count)
                    return null;

                return _itemsSource[_selectedIndex];
            }
        }
    }
}

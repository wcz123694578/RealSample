using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RealSample.Mvvm;

namespace RealSample.Controls
{
    public partial class MasterItemView : UserControl, IItemView
    {
        private bool _isSelected;

        [Browsable(false)]
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
            }
        }


        public string Title
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
                this.Invalidate();
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                DateTime time;
                if (DateTime.TryParse(lblCreatedAt.Text, out time))
                {
                    return time;
                }
                else
                {
                    return default(DateTime);
                }
            }
            set
            {
                lblCreatedAt.Text = value.ToString("yyyy-MM-dd HH:mm:ss");
                this.Invalidate();
            }
        }

        public string CategoryName
        {
            get
            {
                return lblCategory.Text;
            }
            set
            {
                lblCategory.Text = value;
                this.Invalidate();
            }
        }



        public MasterItemView()
        {
            InitializeComponent();

            InitializeDisplay();
        }

        private void InitializeDisplay()
        {
            pnlTitle.Paint += new PaintEventHandler(pnlTitle_Paint);
        }

        void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Panel p = (Panel)sender;

            e.Graphics.DrawLine(
                Pens.Gray,
                0,
                p.Height - 1,
                p.Width,
                p.Height - 1);
        }

        #region IItemView ≥…‘±

        public void Bind(object data, BindCallback binder) {
            if (binder != null) binder.Invoke(this, data);
        }

        public int GetItemHeight() {
            return this.Height;
        }

        #endregion
    }
}

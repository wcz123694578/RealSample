using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RealSample.Controls;
using RealSample.Core.Models;
using System.IO;
using System.Collections;
using System.Data.SQLite;
using RealSample.Shared;
using RealSample.BLL.Abstractions;
using RealSample.Ioc;
using RealSample.Core.Models.Commands;

namespace RealSample.Presentations.Views
{
    public partial class MainView : Form
    {
        private readonly IMediaFileBusinessService _mediaFileBusinessService;

        private readonly List<Category> categories = new List<Category>();
        Hashtable categoryMap = new Hashtable();

        private List<MediaFile> mediaFiles = new List<MediaFile>();

        public MainView()
        {
            InitializeComponent();

            _mediaFileBusinessService = ServiceLocator.Get<IMediaFileBusinessService>();
        }

        private void MainView_Load(object sender, EventArgs e) {
            InitializeControls();

            LoadData();
        }

        private void LoadData() {
            

            foreach (Category cat in categories) {
                categoryMap[cat.Id] = cat.Name;
            }

            List<object> objs = new List<object>();
            foreach (MediaFile mf in mediaFiles)
                objs.Add(mf);

            lstMaster.SetData(objs);
        }

        private void InitializeControls() {
            lstMaster.SetCreateItemViewCallback(new CreateItemViewCallback(CreateItemView));
            lstMaster.SetBinder(new BindCallback(OnBind));

        }

        private IItemView CreateItemView() {
            return new MasterItemView();
        }

        private void OnBind(IItemView view, object data) {
            MasterItemView v = view as MasterItemView;
            MediaFile mediaFile = data as MediaFile;
            if (v != null && mediaFile != null) {
                v.Title = Path.GetFileNameWithoutExtension(mediaFile.FilePath);
                if (categoryMap.ContainsKey(mediaFile.CategoryId)) v.CategoryName = (string)categoryMap[mediaFile.CategoryId];
                v.CreatedAt = mediaFile.CreatedAt;
            }
        }

        private void lstMaster_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                MediaFile mf = lstMaster.SelectedItem as MediaFile;

                detailView.FilePath = mf.FilePath;
                detailView.Title = Path.GetFileNameWithoutExtension(mf.FilePath);
                if (categoryMap.ContainsKey(mf.CategoryId)) detailView.CategoryName = (string)categoryMap[mf.CategoryId];
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e) {
            try {
                using (OpenFileDialog dlg = new OpenFileDialog()) {
                    dlg.InitialDirectory = @"C:\";

                    dlg.RestoreDirectory = true;

                    if (dlg.ShowDialog() == DialogResult.OK) {
                        string filePath = dlg.FileName;

                        MediaFileAddCommand command = new MediaFileAddCommand(filePath);

                        _mediaFileBusinessService.AddMediaFile(command);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
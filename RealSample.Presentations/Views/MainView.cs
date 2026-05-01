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
using RealSample.Core.Models.Queries;
using RealSample.Core.Models.ViewModels;

namespace RealSample.Presentations.Views {
    public partial class MainView : Form {
        private string _selectedDirectory;

        public string SelectedDirectory {
            get { return _selectedDirectory; }
            set { _selectedDirectory = value; }
        }


        private readonly IMediaFileBusinessService _mediaFileBusinessService;

        private readonly List<Category> categories = new List<Category>();
        Hashtable categoryMap = new Hashtable();

        private List<MediaFileMasterResult> _mediaFiles = new List<MediaFileMasterResult>();

        private MediaFileMasterResult _selectedMediaFile = null;

        public MainView() {
            InitializeComponent();

            _mediaFileBusinessService = ServiceLocator.Get<IMediaFileBusinessService>();
        }

        private void MainView_Load(object sender, EventArgs e) {
            InitializeControls();

            InitializeBindings();

            LoadData();

            LoadPlugin();
        }

        private void LoadPlugin() {
            
        }

        private void InitializeBindings() {
            txtDirectory.DataBindings.Add("Text", this, "SelectedDirectory", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadData() {


            foreach (Category cat in categories) {
                categoryMap[cat.Id] = cat.Name;
            }

            MediaFileQuery query = new MediaFileQuery();
            query.CategoryId = 0;
            query.Directory = SelectedDirectory;

            _mediaFiles = EnumerableExtentions.ToList<MediaFileMasterResult>(_mediaFileBusinessService.SelectMediaFiles(query));

            List<object> objs = new List<object>();
            foreach (MediaFileMasterResult mf in _mediaFiles)
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
            MediaFileMasterResult mediaFile = data as MediaFileMasterResult;
            if (v != null && mediaFile != null) {
                v.Title = Path.GetFileNameWithoutExtension(mediaFile.FilePath);
                if (categoryMap.ContainsKey(mediaFile.CategoryId)) v.CategoryName = (string)categoryMap[mediaFile.CategoryId];
                v.CreatedAt = mediaFile.CreatedAt;
            }
        }

        private void lstMaster_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                MediaFileMasterResult mf = lstMaster.SelectedItem as MediaFileMasterResult;

                _selectedMediaFile = mf;
                if (mf != null) tsbDelete.Enabled = true;

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

                LoadData();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            try {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog()) {
                    if (dlg.ShowDialog() == DialogResult.OK) {
                        SelectedDirectory = dlg.SelectedPath;
                    }

                    LoadData();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDirectory_KeyUp(object sender, KeyEventArgs e) {
            LoadData();
        }

        private void tsbDelete_Click(object sender, EventArgs e) {
            try {
                if (_selectedMediaFile == null) return;
                _mediaFileBusinessService.DeleteMediaFile(_selectedMediaFile.Id);
                LoadData();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
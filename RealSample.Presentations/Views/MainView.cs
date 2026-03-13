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

namespace RealSample.Presentations.Views
{
    public partial class MainView : Form
    {
        private readonly List<Category> categories = new List<Category>();
        Hashtable categoryMap = new Hashtable();

        private List<MediaFile> mediaFiles = new List<MediaFile>();

        public MainView()
        {
            InitializeComponent();

            categories.Add(new Category(1, "MIDI²ÉÑù"));

            foreach (Category cat in categories) {
                categoryMap[cat.Id] = cat.Name;
            }

            mediaFiles.Add(new MediaFile("media.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media2.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media2.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media2.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media2.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media.mp4", "", 1));
            mediaFiles.Add(new MediaFile("media2.mp4", "", 1));
        }

        private void MainView_Load(object sender, EventArgs e) {
            InitializeCotrols();
        }

        private void InitializeCotrols() {
            lstMaster.SetCreateItemViewCallback(new CreateItemViewCallback(CreateItemView));
            lstMaster.SetBinder(new BindCallback(OnBind));

            List<object> objs = new List<object>();
            foreach (MediaFile mf in mediaFiles)
                objs.Add(mf);

            lstMaster.SetData(objs);
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
            MediaFile mf = lstMaster.SelectedItem as MediaFile;
        }
    }
}
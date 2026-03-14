using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Design;

namespace RealSample.Controls {

    public partial class DetailView : UserControl {
        public DetailView() {
            InitializeComponent();

            Reload += Internal_Reload;
        }

        private void Internal_Reload(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(FilePath)) return;

                _fileInfo = new FileInfo(FilePath);

                txtFileInfo.Text = BuildFileInfoString();
            } catch {
                if (!DesignMode) {
                    throw;
                }
            }
        }

        private string BuildFileInfoString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("文件名：" + _fileInfo.Name);
            sb.AppendLine("路径：" + _fileInfo.FullName);
            sb.AppendLine("扩展名：" + _fileInfo.Extension);
            sb.AppendLine("大小：" + FormatSize(_fileInfo.Length));
            sb.AppendLine("创建时间：" + _fileInfo.CreationTime.ToString());
            sb.AppendLine("修改时间：" + _fileInfo.LastWriteTime.ToString());

            return sb.ToString();
        }

        private string FormatSize(long byteLength) {
            string[] sizes = new string[] { "B", "KB", "MB", "GB", "TB" };

            double len = byteLength;
            int order = 0;

            while (len > 1024 && order < sizes.Length - 1) {
                order++;
                len /= 1024;
            }

            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }

        public event EventHandler Reload;

        public string Title {
            get { return lblTitle.Text; }
            set {
                lblTitle.Text = value;
                this.Invalidate();
            }
        }

        public string CategoryName {
            get { return lblCategory.Text; }
            set {
                lblCategory.Text = value;
                this.Invalidate();
            }
        }

        private FileInfo _fileInfo;

        private string _filePath;

        [Editor(typeof(FilePathEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Browsable(true)]
        [Category("Data")]
        [Description("文件路径")]
        public string FilePath {
            get { return _filePath; }
            set { 
                _filePath = value;
                if (Reload != null) {
                    Reload.Invoke(this, new EventArgs());
                }
            }
        }

        private List<CommandViewModel> _commands;

        public List<CommandViewModel> Commands {
            get { return _commands; }
            set { _commands = value; }
        }

        private BindingList<KeyValueItem> _keyValues = new BindingList<KeyValueItem>();

        private void SetAssetInfo(Dictionary<string, string> infos) {
            foreach (KeyValuePair<string, string> keyValue in infos) {
                _keyValues.Add(new KeyValueItem(keyValue.Key, keyValue.Value));
            }
        }
    }

    public struct KeyValueItem {
        public KeyValueItem(string key, string value) {
            _key = key;
            _value = value;
        }

        private string _key;

        public string Key {
            get { return _key; }
            set { _key = value; }
        }

        private string _value;

        public string Value {
            get { return _value; }
            set { _value = value; }
        }

    }

    public class FilePathEditor : UITypeEditor {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context,
                                                 IServiceProvider provider,
                                                 object value) {
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.FileName = value as string;

                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.FileName;
            }

            return value;
        }
    }
}

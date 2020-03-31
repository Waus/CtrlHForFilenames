using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtrlHForFilenames
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void WithoutPathRB_CheckedChanged(object sender, EventArgs e)
        {
            PathTB.Enabled = WithPathRB.Checked;
            SelectDirectoryBtn.Enabled = WithPathRB.Checked;
        }

        private void WithPathRB_CheckedChanged(object sender, EventArgs e)
        {
            PathTB.Enabled = WithPathRB.Checked;
            SelectDirectoryBtn.Enabled = WithPathRB.Checked;
        }

        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            string path = WithoutPathRB.Checked ? Directory.GetCurrentDirectory() : PathTB.Text;
            SearchOption searchOption = AllDirectoriesTB.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            string searchText = SearchTextTB.Text;
            string replaceTo = ReplaceToTB.Text;
            if (Directory.Exists(path))
            {
                foreach (string filePath in Directory.GetFiles(path, "*", searchOption))
                {
                    string directoryName = Path.GetDirectoryName(filePath);
                    string oldFileName = Path.GetFileName(filePath);
                    string newFileName = oldFileName.Replace(searchText, replaceTo);
                    string newFileNameWithPath = directoryName + '\\' + newFileName;

                    if (!String.IsNullOrEmpty(newFileName) && newFileName != oldFileName)
                    {
                        File.Move(filePath, newFileNameWithPath);
                    }
                }
            }
            else
            {
                string message = "Nieprawidłowa ścieżka";
                string caption = "Błąd";
                MessageBox.Show(message, caption);
            }
        }

        private void SelectDirectoryBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathTB.Text = fbd.SelectedPath;
                }
            }
        }
    }
}

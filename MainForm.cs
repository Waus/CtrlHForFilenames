using System;
using System.IO;
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
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Nieprawidłowa ścieżka", "Błąd");
            }
            else if (String.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Nie podano szukanego tekstu", "Błąd");
            }
            else
            {
                var allFiles = Directory.GetFiles(path, "*", searchOption);
                foreach (string filePath in allFiles)
                {
                    string directoryName = Path.GetDirectoryName(filePath);
                    string oldFileName = Path.GetFileName(filePath);
                    string newFileName = oldFileName.Replace(searchText, replaceTo);

                    if (!String.IsNullOrEmpty(newFileName) && newFileName != oldFileName)
                    {
                        string newFileNameWithPath = Path.Combine(directoryName, newFileName);
                        try
                        {
                            File.Move(filePath, newFileNameWithPath);
                        }
                        catch
                        {
                        }
                    }
                }
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

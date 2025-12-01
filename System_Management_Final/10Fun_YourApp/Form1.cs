using System.Diagnostics;
using System.IO;

namespace _10Fun_YourApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /* Is Path Valid Function */
        private bool ValidatePath(string path, bool mustExist = true, bool isFile = true)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Please select a path first!");
                return false;
            }

            if (mustExist)
            {
                if (isFile && !File.Exists(path))
                {
                    MessageBox.Show("The selected file does not exist!");
                    return false;
                }
                else if (!isFile && !Directory.Exists(path))
                {
                    MessageBox.Show("The selected folder does not exist!");
                    return false;
                }
            }

            return true;
        }

        private string GetFullPath()
        {
            return Path.Combine(lblPath.Text, lblFileName.Text);
        }

        /* 1. Browse Buttons Function */
        private void BrowseFolder(Label targetLabel)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a folder to process";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    targetLabel.Text = fbd.SelectedPath;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BrowseFolder(lblPath);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            BrowseFolder(lblDst);
        }

        /* Process Button Function : Get Path */
        private void doSomethingWithPath(string path)
        {
            MessageBox.Show($"Processing path: {path}");
        }

        /* 2. Create Dir Button Function */
        private void Dir_Name_Click(object sender, EventArgs e)
        {

        }
        private void btnCrtDir_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = lblPath.Text;
                string dirName = txtDirName.Text;
                string fullPath = Path.Combine(basePath, dirName);

                if (string.IsNullOrWhiteSpace(dirName))
                {
                    MessageBox.Show("Please enter a directory name!");
                    return;
                }

                if (!ValidatePath(basePath, mustExist: true, isFile: false))
                    return;

                Directory.CreateDirectory(fullPath);
                MessageBox.Show($"Directory created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating directory: {ex.Message}");
            }
        }

        /* 3. Create File Button Function */
        private void txtDirName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCrtFile_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = lblPath.Text;
                string fileName = lblFileName.Text;
                string fullPath = Path.Combine(basePath, fileName);

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Please enter a directory name!");
                    return;
                }

                if (!ValidatePath(basePath, mustExist: true, isFile: false))
                    return;

                File.Create(fullPath).Close();
                MessageBox.Show($"File created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating file: {ex.Message}");
            }
        }

        /* 4. Open Dir Function */
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string basePath = lblPath.Text;

            if (!ValidatePath(basePath, mustExist: true, isFile: false))
                return;

            try
            {
                Process.Start("explorer.exe", basePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening path: {ex.Message}");
            }
        }

        /* 5. Write Function */
        private void btnWrte_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath = GetFullPath();
                string content = textWrte.Text;

                if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                    return;

                File.WriteAllText(fullPath, content);
                MessageBox.Show($"Content written to file successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        /* 6. Append Function */
        private void btnApnd_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath = GetFullPath();
                string content = textApnd.Text;

                if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                    return;

                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine(content);
                }

                MessageBox.Show($"Content appended to file successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Appending To File: {ex.Message}");
                return;
            }
        }

        /* 7. Read Function */
        private void btnRead_Click(object sender, EventArgs e)
        {
            string fullPath = GetFullPath();

            if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                return;

            var content = File.ReadAllText(fullPath);
            MessageBox.Show(content, "File Content");
        }

        /* 8. Copy Function */
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath = GetFullPath();
                string destPath = lblDst.Text;

                if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                    return;

                if (!ValidatePath(destPath, mustExist: true, isFile: false))
                    return;

                string destFilePath = Path.Combine(destPath, lblFileName.Text);
                File.Copy(fullPath, destFilePath, overwrite: true);
                MessageBox.Show($"File copied successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying file: {ex.Message}");
            }
        }

        /* 9. Move Function */
        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath = GetFullPath();
                string destPath = lblDst.Text;

                if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                    return;
                if (!ValidatePath(destPath, mustExist: true, isFile: false))
                    return;

                string destFilePath = Path.Combine(destPath, lblFileName.Text);
                File.Move(fullPath, destFilePath);
                MessageBox.Show($"File moved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error moving file: {ex.Message}");
            }
        }

        /* 10. Delete Dir Function */
        private void btnDltDir_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = lblDst.Text;
                string dirName = txtDirName.Text;
                string fullPath = Path.Combine(basePath, dirName);

                if (string.IsNullOrWhiteSpace(dirName))
                {
                    MessageBox.Show("Please enter a directory name!");
                    return;
                }
                if (!ValidatePath(fullPath, mustExist: true, isFile: false))
                    return;

                Directory.Delete(fullPath, recursive: true);
                MessageBox.Show($"Directory deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting directory: {ex.Message}");
            }
        }

        /* 11. Delete File Function */
        private void btnDltFile_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = lblDst.Text;
                string fileName = lblFileName.Text;
                string fullPath = Path.Combine(basePath, fileName);
                if (!ValidatePath(fullPath, mustExist: true, isFile: true))
                    return;

                File.Delete(fullPath);
                MessageBox.Show($"File deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting file: {ex.Message}");
            }
        }

        /* ================================================ Finshed ================================================ */
    }
}

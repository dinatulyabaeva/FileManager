using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
namespace файловый_менеджер
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        private bool isMove = false;
        private string curFilePath;
        private TreeNode curSelectedNode = null;
        private string[] copyFilesSourcePaths = new string[200];
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
             Library.SetLocalDrive(TreeView);
             TreeView.AfterSelect += AfterSelect;
             ListView.MouseDoubleClick += GoButton_Click;
             GoButton.Click += GoButton_Click; 
             Exit.Click += Exit_Click;
             About.Click += AboutProgram_Click;
        }

         private void AboutProgram_Click(object sender, EventArgs e)
         {
             string str = "Проводник v 1.0\r\r Разработчик: Тулябаева Дина Азаматовна\r";
             MessageBox.Show(str, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
        private void AfterSelect(object sender, TreeViewEventArgs e) //после выбора
        {
            string newPath = e.Node.FullPath.Replace("\\\\", "\\");
            AddressBar.Text = $"Путь: {newPath}";
            if (e.Node.GetNodeCount(true) == 0)
            {
                Library.GetSubDir(e.Node, e.Node.FullPath);
            }
            Library.GetDirectories(e.Node.FullPath, ListView);
            FileName.Text = newPath;
            FileType.Text = System.IO.Path.GetExtension("abc.txt");
        }
         private void Exit_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void About_Click(object sender, EventArgs e)
        {

        }

       private void GoButton_Click(object sender, EventArgs e)
       {
            string path = TreeView.SelectedNode.FullPath + '\\' + ListView.FocusedItem.Text;
            //Проверка существования файла
            if (File.Exists(path))
            {
                //Команда для открытия файла приложением по умолчанию
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                Library.SearchNode(TreeView, path);
                Library.GetDirectories(path, ListView);
            }
       }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ListView lv = new ListView();
            string path = AddressBar.Text;
            GoBack();
            Library.GetDirectories(path, lv);
        }
        
        public void GoBack()
        {
            try
            {
                string path = AddressBar.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                AddressBar.Text = "Путь: ";
                ListView.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(AddressBar.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach(DirectoryInfo directory in dirs)
                {
                    ListView.Items.Add(directory.Name);
                }
                FileInfo[] files = dir.GetFiles();
                foreach(FileInfo fileInfo in files)
                {
                    ListView.Items.Add(fileInfo.Name);
                }
                AddressBar.Text = path;
            }
            catch
            {

            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                int i = 0;

                foreach (ListViewItem el in ListView.SelectedItems)
                {
                    copyFilesSourcePaths[i++] = el.Tag.ToString();
                }

                isMove = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string path = TreeView.SelectedNode.FullPath + '\\' + ListView.FocusedItem.Text;
            if (System.IO.File.Exists(path))
            {
                try
                {
                    System.IO.File.Delete(path);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Ошибка");
                    return;
                }
            }
            System.IO.FileInfo fi = new System.IO.FileInfo(path);
            try
            {
                fi.Delete();
            }
            catch (System.IO.IOException )
            {
                
            }
            try
            {
                System.IO.Directory.Delete(path);
            }
            catch (System.IO.IOException)
            { 

            }
            if (System.IO.Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.Delete(path, true);
                }

                catch (System.IO.IOException)
                {

                }
            }
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            try
            {
                di.Delete(true);
            }
            catch (System.IO.IOException)
            {

            }
        }


        private void RenameIt_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                ListView.SelectedItems[0].BeginEdit();
            }
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {

        }

        private void CreateFolder_Click_1(object sender, EventArgs e)
        {
            string path = Path.Combine(curFilePath, "новая папка");
            try
            {
                string fileAddr = AddressBar.Text + "Новая папка";
                if (Directory.Exists(fileAddr))
                {
                    int i = 1;
                    fileAddr += " (" + i.ToString() + ")";
                }
                Directory.CreateDirectory(fileAddr);

                Library.GetSubDir(curSelectedNode, path);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            
        }
        
    }
}


namespace файловый_менеджер
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddressBar = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.FileName = new System.Windows.Forms.Label();
            this.FileType = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameIt = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressBar
            // 
            this.AddressBar.Location = new System.Drawing.Point(114, 33);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(513, 22);
            this.AddressBar.TabIndex = 0;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(636, 30);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(98, 25);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Перейти";
            this.GoButton.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.HideSelection = false;
            this.ListView.LabelEdit = true;
            this.ListView.LargeImageList = this.ImageList;
            this.ListView.Location = new System.Drawing.Point(268, 61);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(466, 364);
            this.ListView.SmallImageList = this.ImageList;
            this.ListView.TabIndex = 2;
            this.ListView.Tag = "10";
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "UNKNOWN.png");
            this.ImageList.Images.SetKeyName(1, "PNG.png");
            this.ImageList.Images.SetKeyName(2, "PDF.png");
            this.ImageList.Images.SetKeyName(3, "EXE.png");
            this.ImageList.Images.SetKeyName(4, "MP4.png");
            this.ImageList.Images.SetKeyName(5, "MP3.png");
            this.ImageList.Images.SetKeyName(6, "DOC.png");
            this.ImageList.Images.SetKeyName(7, "FOLDER.png");
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(21, 470);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(119, 17);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "Название файла";
            // 
            // FileType
            // 
            this.FileType.AutoSize = true;
            this.FileType.Location = new System.Drawing.Point(547, 470);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(80, 17);
            this.FileType.TabIndex = 4;
            this.FileType.Text = "Тип файла";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 30);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 25);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(24, 61);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(217, 364);
            this.TreeView.TabIndex = 8;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit,
            this.About,
            this.Copy,
            this.Delete,
            this.Create,
            this.RenameIt});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(759, 28);
            this.MenuStrip.TabIndex = 9;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(67, 24);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(118, 24);
            this.About.Text = "О программе";
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(107, 24);
            this.Copy.Text = "Копировать";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 24);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFolder,
            this.CreateFile});
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(78, 24);
            this.Create.Text = "Создать";
            // 
            // CreateFolder
            // 
            this.CreateFolder.Name = "CreateFolder";
            this.CreateFolder.Size = new System.Drawing.Size(224, 26);
            this.CreateFolder.Text = "Папку";
            this.CreateFolder.Click += new System.EventHandler(this.CreateFolder_Click_1);
            // 
            // CreateFile
            // 
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(224, 26);
            this.CreateFile.Text = "Файл";
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // RenameIt
            // 
            this.RenameIt.Name = "RenameIt";
            this.RenameIt.Size = new System.Drawing.Size(135, 24);
            this.RenameIt.Text = "Переименовать";
            this.RenameIt.Click += new System.EventHandler(this.RenameIt_Click);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.ShowCheckMargin = true;
            this.ContextMenuStrip.Size = new System.Drawing.Size(83, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 502);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "File Manager";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressBar;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label FileType;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem CreateFolder;
        private System.Windows.Forms.ToolStripMenuItem CreateFile;
        private System.Windows.Forms.ToolStripMenuItem RenameIt;
    }
}


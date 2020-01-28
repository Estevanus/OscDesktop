using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscDesktop
{
	public partial class DesktopForm : Form
	{
		string relativePath = AppDomain.CurrentDomain.BaseDirectory;
		string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		string userPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		bool winPressed = false;

		List<Bitmap> daftarWalpapers = new List<Bitmap>();
		List<Image> dw = new List<Image>();
		int curWallpaper = 0;

		private System.Windows.Forms.ListView desktopCollection;

		ImageList iList = new ImageList();

		public DesktopForm()
		{
			InitializeComponent();
			KeyUp += DesktopForm_KeyUp;
			KeyDown += DesktopForm_KeyDown;

			desktopCollection = new CustomControl();

			desktopCollection.HideSelection = false;
			desktopCollection.Location = new System.Drawing.Point(543, 92);
			desktopCollection.Name = "desktopCollection";
			desktopCollection.Size = new System.Drawing.Size(335, 218);
			desktopCollection.TabIndex = 1;
			desktopCollection.UseCompatibleStateImageBehavior = false;
			desktopCollection.Dock = DockStyle.Fill;

			Controls.Add(desktopCollection);

		}

		private void DesktopForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.LWin)
			{
				winPressed = true;
			}
		}

		void GetDesktopFiles()
		{
			System.IO.DirectoryInfo pardir = new System.IO.DirectoryInfo(userPath);

			System.IO.DirectoryInfo[] dirs = pardir.GetDirectories();
			System.IO.FileInfo[] files = pardir.GetFiles();

			foreach (System.IO.DirectoryInfo dir in dirs)
			{
				ListViewItem item = new ListViewItem(dir.Name);
				item.ImageKey = "folder";
				desktopCollection.Items.Add(item);
			}

			foreach (System.IO.FileInfo file in files)
			{
				ListViewItem item = new ListViewItem(file.Name);
				item.ImageKey = "file";
				desktopCollection.Items.Add(item);
			}
		}

		private void DesktopForm_Load(object sender, EventArgs e)
		{

			//Bitmap gb = new Bitmap(@"wallpapers/wallpaper.jpg");
			iList.ImageSize = new System.Drawing.Size(42, 42);
			Icon folderIcon = new Icon(relativePath + "/icons/folder.ico");
			Icon fileIcon = new Icon(relativePath + "icons/file.ico");
			iList.Images.Add("file", fileIcon);
			iList.Images.Add("folder", folderIcon);
			desktopCollection.LargeImageList = iList;
			desktopCollection.SmallImageList = iList;
			

			System.IO.StreamReader f = System.IO.File.OpenText(relativePath + "/wallpaperList.txt");
			string isi = f.ReadToEnd();
			f.Close();

			string[] baris = isi.Split('\n');

			//MessageBox.Show(relativePath);

			foreach (string lok in baris)
			{
				Size s = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				Bitmap wallpaper = new Bitmap(@lok);
				Bitmap tes = new Bitmap(wallpaper, s);
				//wallpaper.SetResolution(600, 400);
				daftarWalpapers.Add(tes);
			}

			//BackgroundImage = gb;
			//desktopCollection.BackgroundImage = gb;

			//desktopCollection.BackgroundImage = this.BackgroundImage;

			GetDesktopFiles();


			ChangeBackGround();
		}

		private void DesktopForm_KeyUp(object sender, KeyEventArgs e)
		{
			if (winPressed == true && e.KeyCode == Keys.E)
			{
				System.Diagnostics.Process.Start("OscExplorer.exe");
				Console.WriteLine("okey dokey");
			}

			if (e.KeyCode == Keys.LWin)
			{
				winPressed = false;
			}
		}

		private void ExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("OscExplorer.exe");
		}

		private void VolumeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("C://Windows/System32/SndVol.exe");
		}

		void ChangeBackGround()
		{
			if (curWallpaper < daftarWalpapers.Count)
			{
				desktopCollection.BackgroundImage = daftarWalpapers[curWallpaper];
				curWallpaper += 1;
			}
			else
			{
				curWallpaper = 0;
			}
		}

		private void WallpaperChanger_Tick(object sender, EventArgs e)
		{
			ChangeBackGround();
		}
	}
}

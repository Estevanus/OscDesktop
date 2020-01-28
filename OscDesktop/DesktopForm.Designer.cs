namespace OscDesktop
{
	partial class DesktopForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wallpaperChanger = new System.Windows.Forms.Timer(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem,
            this.volumeSettingsToolStripMenuItem});
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(160, 48);
			// 
			// explorerToolStripMenuItem
			// 
			this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
			this.explorerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.explorerToolStripMenuItem.Text = "&Explorer";
			this.explorerToolStripMenuItem.Click += new System.EventHandler(this.ExplorerToolStripMenuItem_Click);
			// 
			// volumeSettingsToolStripMenuItem
			// 
			this.volumeSettingsToolStripMenuItem.Name = "volumeSettingsToolStripMenuItem";
			this.volumeSettingsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.volumeSettingsToolStripMenuItem.Text = "&Volume Settings";
			this.volumeSettingsToolStripMenuItem.Click += new System.EventHandler(this.VolumeSettingsToolStripMenuItem_Click);
			// 
			// wallpaperChanger
			// 
			this.wallpaperChanger.Enabled = true;
			this.wallpaperChanger.Interval = 3000;
			this.wallpaperChanger.Tick += new System.EventHandler(this.WallpaperChanger_Tick);
			// 
			// DesktopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OscDesktop.Properties.Resources._281446_aliya06;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1366, 768);
			this.ContextMenuStrip = this.menuStrip;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DesktopForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OscDesktop";
			this.Load += new System.EventHandler(this.DesktopForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumeSettingsToolStripMenuItem;
		private System.Windows.Forms.Timer wallpaperChanger;
	}
}


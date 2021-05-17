/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 04.05.2021
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinForms_grafika
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zavřítToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nástrojeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operaceToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem obrysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odstínyŠediToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zvětšeníToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem výřezToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem převodNaZnakyToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zavřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nástrojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.obrysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odstínyŠediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zvětšeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.výřezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.převodNaZnakyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.souborToolStripMenuItem,
			this.nástrojeToolStripMenuItem,
			this.operaceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// souborToolStripMenuItem
			// 
			this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.novýToolStripMenuItem,
			this.otevřítToolStripMenuItem,
			this.zavřítToolStripMenuItem,
			this.uložitToolStripMenuItem});
			this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
			this.souborToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.souborToolStripMenuItem.Text = "Soubor";
			// 
			// novýToolStripMenuItem
			// 
			this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
			this.novýToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.novýToolStripMenuItem.Text = "Nový";
			this.novýToolStripMenuItem.Click += new System.EventHandler(this.NovýToolStripMenuItemClick);
			// 
			// otevřítToolStripMenuItem
			// 
			this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
			this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.otevřítToolStripMenuItem.Text = "Otevřít";
			this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.OtevřítToolStripMenuItemClick);
			// 
			// zavřítToolStripMenuItem
			// 
			this.zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
			this.zavřítToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.zavřítToolStripMenuItem.Text = "Zavřít";
			this.zavřítToolStripMenuItem.Click += new System.EventHandler(this.ZavřítToolStripMenuItemClick);
			// 
			// uložitToolStripMenuItem
			// 
			this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
			this.uložitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.uložitToolStripMenuItem.Text = "Uložit";
			this.uložitToolStripMenuItem.Click += new System.EventHandler(this.UložitToolStripMenuItemClick);
			// 
			// nástrojeToolStripMenuItem
			// 
			this.nástrojeToolStripMenuItem.Name = "nástrojeToolStripMenuItem";
			this.nástrojeToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.nástrojeToolStripMenuItem.Text = "Nástroje";
			// 
			// operaceToolStripMenuItem
			// 
			this.operaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.blackAndWhiteToolStripMenuItem,
			this.obrysToolStripMenuItem,
			this.odstínyŠediToolStripMenuItem,
			this.zvětšeníToolStripMenuItem,
			this.výřezToolStripMenuItem,
			this.převodNaZnakyToolStripMenuItem});
			this.operaceToolStripMenuItem.Name = "operaceToolStripMenuItem";
			this.operaceToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.operaceToolStripMenuItem.Text = "Operace";
			// 
			// blackAndWhiteToolStripMenuItem
			// 
			this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
			this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.blackAndWhiteToolStripMenuItem.Text = "BlackAndWhite";
			this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.BlackAndWhiteToolStripMenuItemClick);
			// 
			// obrysToolStripMenuItem
			// 
			this.obrysToolStripMenuItem.Name = "obrysToolStripMenuItem";
			this.obrysToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.obrysToolStripMenuItem.Text = "Obrys";
			this.obrysToolStripMenuItem.Click += new System.EventHandler(this.ObrysToolStripMenuItemClick);
			// 
			// odstínyŠediToolStripMenuItem
			// 
			this.odstínyŠediToolStripMenuItem.Name = "odstínyŠediToolStripMenuItem";
			this.odstínyŠediToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.odstínyŠediToolStripMenuItem.Text = "Odstíny šedi";
			this.odstínyŠediToolStripMenuItem.Click += new System.EventHandler(this.OdstínyŠediToolStripMenuItemClick);
			// 
			// zvětšeníToolStripMenuItem
			// 
			this.zvětšeníToolStripMenuItem.Name = "zvětšeníToolStripMenuItem";
			this.zvětšeníToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.zvětšeníToolStripMenuItem.Text = "Zvětšení";
			this.zvětšeníToolStripMenuItem.Click += new System.EventHandler(this.ZvětšeníToolStripMenuItemClick);
			// 
			// výřezToolStripMenuItem
			// 
			this.výřezToolStripMenuItem.Name = "výřezToolStripMenuItem";
			this.výřezToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.výřezToolStripMenuItem.Text = "Výřez";
			this.výřezToolStripMenuItem.Click += new System.EventHandler(this.VýřezToolStripMenuItemClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 28);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(450, 300);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1110, 493);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseUp);
			// 
			// převodNaZnakyToolStripMenuItem
			// 
			this.převodNaZnakyToolStripMenuItem.Name = "převodNaZnakyToolStripMenuItem";
			this.převodNaZnakyToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.převodNaZnakyToolStripMenuItem.Text = "Převod na znaky";
			this.převodNaZnakyToolStripMenuItem.Click += new System.EventHandler(this.PřevodNaZnakyToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1110, 521);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(450, 300);
			this.Name = "MainForm";
			this.Text = "WinForms-grafika";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 04.05.2021
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_grafika
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static Bitmap obr;
		public static Bitmap obrM;
		public static Bitmap obrN;
		private static decimal podR=0.2989M;
		private static decimal podG=0.5866M;
		private static decimal podB=0.1145M;
		private static decimal svetlost;
		private static decimal svetlost2;
		Color pixelokusdal;
		private int red;
        private int green;
        private int blue;
        private bool mousedown;
        private Point bodSpusteni = new Point();
        bool pero;
        private int x;
        private int y;
        private string[] ASCII = {"#","@","S","%","=","+","*",":","-","."};
		
		public MainForm()
		{
			InitializeComponent();
		}
		void NovýToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		void OtevřítToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.FileName="...";
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				obr=new Bitmap(openFileDialog1.FileName);
				obrM=new Bitmap(openFileDialog1.FileName);
				obrN=new Bitmap(openFileDialog1.FileName);
				pictureBox1.Load(openFileDialog1.FileName);
			}
		}
		void ZavřítToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void UložitToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		void BlackAndWhiteToolStripMenuItemClick(object sender, EventArgs e)
		{
			//pro vytvoření černo bílého obrázku potřebujeme zjistit světlost pixelu
            //pixel je barva skládající se ze tří barev
            //nejvíce se na světlosti podílí zelená barva (cca. 60%[58.66%]) [modrá: 11%(11.45%) červená: 29.89%(30%)]
            if(obr != null)
            { 	
				for(int i=0;i<obr.Width;i++)
				{
					for(int j=0;j<obr.Height;j++)
					{
						Color pixel = obr.GetPixel(i,j);
						red=pixel.R;
						green=pixel.G;
						blue=pixel.B;
						svetlost=(red*podR+green*podG+blue*podB);
						if(svetlost<255/2)
						{obrM.SetPixel(i,j,Color.Black);}
						
						else{obrM.SetPixel(i,j,Color.White);}
					}
				}
				Form frm1 = new Form1(obrM);
				frm1.Show();
            }
		}
		void ObrysToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(obr != null)
			{
				for(int i=1;i<obr.Width;i++)
				{
					for(int j=0;j<obr.Height;j++)
					{
						Color pixel = obr.GetPixel(i,j);
			
						pixelokusdal=obr.GetPixel(i-1,j);
				
					    red=pixel.R;
						green=pixel.G;
						blue=pixel.B;
				
						int red2=pixelokusdal.R;
						int green2=pixelokusdal.G;
						int blue2=pixelokusdal.B;
						svetlost=(red*podR+green*podG+blue*podB);
						svetlost2=(red2*podR+green2*podG+blue2*podB);
						if(svetlost-svetlost2<5||svetlost-svetlost2>245)
						{
							obrM.SetPixel(i,j,Color.White);
						}	
						else obrM.SetPixel(i,j,Color.Black);
					}
				}
				Form frm1 = new Form1(obrM);
				frm1.Show();
			}
		}
		void OdstínyŠediToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (obr != null)
            {
                for (int i = 0; i < obrM.Width; i++)
                {
                    for (int j = 0; j < obrM.Height; j++)
                    {
                        Color pixel = obrM.GetPixel(i, j);
                        red = pixel.R;
                        green = pixel.G;
                        blue = pixel.B;
                        svetlost = (red * podR + green * podG + blue * podB);
                        obrM.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(svetlost), Convert.ToInt32(svetlost), Convert.ToInt32(svetlost))); //- lepší černo bílý obrázek
                    }
                }
                Form frm1 = new Form1(obrM);
                frm1.Show();
            }
		}
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			mousedown = true;
            bodSpusteni.X = e.X;
            bodSpusteni.Y = e.Y;
		}
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			mousedown = false;
		}
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
			if(mousedown)
            {
                if (obr != null)
                {
                	obrN = new Bitmap(obr);
                    int tloustka = Convert.ToInt32(32);
                    Graphics grx = Graphics.FromImage(obrN);
                    Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red);
                    pen.Width = 1;
                    grx.DrawLine(pen, bodSpusteni.X, bodSpusteni.Y, e.X, bodSpusteni.Y);
                    grx.DrawLine(pen, e.X, bodSpusteni.Y, e.X, e.Y);
                    grx.DrawLine(pen, e.X, e.Y, bodSpusteni.X, e.Y);
                    grx.DrawLine(pen, bodSpusteni.X, e.Y, bodSpusteni.X, bodSpusteni.Y);
                    x = e.X;
                    y = e.Y;
                    pictureBox1.Image = obrN;
                }
			}
		}
		void VýřezToolStripMenuItemClick(object sender, EventArgs e)
		{
			int zacatekX;
			int zacatekY;
			int konecX;
			int konecY;
			if(x>bodSpusteni.X) {zacatekX=bodSpusteni.X; konecX=x;}else {zacatekX=x; konecX=bodSpusteni.X;}
			if(y>bodSpusteni.Y) {zacatekY=bodSpusteni.Y; konecY=y;}else {zacatekY=y; konecY=bodSpusteni.Y;}
			Bitmap newBtm;
            Color pixel;
            newBtm = new Bitmap(obr.Width*2, obr.Height*2);
            for (int i = zacatekX+1; i < konecX; i++)
            {
                for (int j = zacatekY+1; j < konecY; j++)
                {
                    pixel = obr.GetPixel(i, j);
                    newBtm.SetPixel(2 * i, 2 * j, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j, pixel);
                    newBtm.SetPixel(2 * i, 2 * j + 1, pixel);
                    newBtm.SetPixel(2 * i + 1, 2 * j + 1, pixel);
                }
            }
            Form frm1 = new Form1(newBtm);
            frm1.Text = "Výřez obrázku";
            frm1.Show();
		}
		void ZvětšeníToolStripMenuItemClick(object sender, EventArgs e)
		{
			Bitmap obrZ;
            obrZ = new Bitmap(obr.Width*2, obr.Height*2);
            if (obr != null)
            {
                for (int i = 0; i < obr.Width; i++)
                {
                    for (int j = 0; j < obr.Height; j++)
                    {
                        Color pixel = obr.GetPixel(i, j);
                        obrZ.SetPixel(2 * i, 2 * j, pixel);
                        obrZ.SetPixel(2 * i + 1, 2 * j, pixel);
                        obrZ.SetPixel(2 * i, 2 * j + 1, pixel);
                        obrZ.SetPixel(2 * i + 1, 2 * j + 1, pixel);
                    }
                }
                Form frm1 = new Form1(obrZ);
                frm1.Show();
            }
		}
		void PřevodNaZnakyToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form frm2 = new Form2(obr);
			frm2.Text = "Převod do ASCII";
			frm2.Show();
		}
	}
}

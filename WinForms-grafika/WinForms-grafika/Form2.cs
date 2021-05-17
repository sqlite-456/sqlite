/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 05.05.2021
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace WinForms_grafika
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		Bitmap obr;
		private string[] ASCII = {"#","@","S","%","=","+","*",":","-",".","&nbsp;"};
		private static decimal podR = 0.2989M;
        private static decimal podG = 0.5866M;
        private static decimal podB = 0.1145M;
        private int red;
        private int green;
        private int blue;
        private static decimal svetlost;
        int index;
        string znak;
		public Form2(Bitmap obr)
		{
			InitializeComponent();
			this.obr = obr;
			string textASCII = BtmToText(obr);
			//webBrowser1.DocumentText = "<pre>"+"<h1> Nadpis h1 </h1><p></p>"+"<h2> Nadpis h2 </h2><p></p>"+ASCII[0]+"</pre>";
			webBrowser1.DocumentText = textASCII;
		}
		void Form2Load(object sender, EventArgs e)
		{
			
		}
		string BtmToText(Bitmap obr)
		{
			StringBuilder sb = new StringBuilder();
			 for (int i = 0; i < obr.Width; i++)
            {
                for (int j = 0; j < obr.Height; j++)
                {
                	Color pixel = obr.GetPixel(i, j);
                    red = pixel.R;
                    green = pixel.G;
                    blue = pixel.B;
                    svetlost = (red * podR + green * podG + blue * podB);
                    index = Convert.ToInt32((svetlost*10)/255);
                    znak = ASCII[index];
                    sb.Append(znak);
                }
                sb.Append("<br>");
			}
			return sb.ToString();
		}
	}
}

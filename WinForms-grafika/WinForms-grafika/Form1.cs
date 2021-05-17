/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 05.05.2021
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_grafika
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1(Bitmap obrM)
		{
			InitializeComponent();
			pictureBox1.Image = obrM;
		}
	}
}

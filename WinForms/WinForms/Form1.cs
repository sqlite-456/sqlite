/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 04.05.2021
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1(string jmeno, string prijmeni, string vlastnim, string pohlavi, string oblibenyDen, DateTime date)
		{	
			InitializeComponent();
			
			label1.Text = jmeno;
			label2.Text = prijmeni;
			label3.Text = vlastnim;
			label4.Text = pohlavi;
			label5.Text = oblibenyDen;
			label6.Text = date.ToString();
		}
	}
}

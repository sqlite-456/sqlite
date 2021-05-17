/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 25.02.2021
 * Time: 9:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Nevyplněné jméno nebo příjmení.", "Chyba");
			}
			else
			{
				if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
				{
					string pohlavi;
					if(radioButton1.Checked) pohlavi = radioButton1.Text;
					else if(radioButton2.Checked) pohlavi = radioButton2.Text;
					else if(radioButton3.Checked) pohlavi = radioButton3.Text;
					else pohlavi = radioButton4.Text;
					if(comboBox1.SelectedItem == null)
					{
						MessageBox.Show("Nezvolen oblíbený den", "Chyba");
					}
					else
					{
						string vlastnim = "";
						if(checkBox1.Checked) vlastnim = "Kolo ";
						if(checkBox2.Checked) vlastnim = vlastnim + "Auto ";
						if(checkBox3.Checked) vlastnim = vlastnim + "Dodávka";
						if(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked) vlastnim = "Nic";
						string oblibenyDen = comboBox1.SelectedItem.ToString();
						string jm = textBox1.Text;
						string prjm = textBox2.Text;
						DateTime date = dateTimePicker1.Value;
						Form frm1 = new Form1(jm, prjm, vlastnim, pohlavi, oblibenyDen, date);
						frm1.Show();
					}
				} else MessageBox.Show("Nevyplněno pohlaví", "Chyba");
			}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			int den = comboBox1.SelectedIndex;
			//label4.Text = den.ToString();
			switch(den)
			{
				case 0:
					pictureBox1.Image = Image.FromFile("pondeli.png");
					break;
				case 1:
					pictureBox1.Image = Image.FromFile("utery.png");
					break;
				case 2:
					pictureBox1.Image = Image.FromFile("streda.png");
					break;
				case 3:
					pictureBox1.Image = Image.FromFile("ctvrtek.png");
					break;	
				case 4:
					pictureBox1.Image = Image.FromFile("patek.png");
					break;
				case 5:
					pictureBox1.Image = Image.FromFile("sobota.png");
					break;
				case 6:
					pictureBox1.Image = Image.FromFile("nedele.png");
					break;
				case 7:
					pictureBox1.Image = Image.FromFile("nic.png");
					break;
			}
		}
	}
}

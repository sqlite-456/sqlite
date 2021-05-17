/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 15.05.2021
 * Time: 18:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Winforms_SQLite
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		SQLiteConnection con;
		DataSet dataSet = new DataSet();
		SQLiteDataAdapter dataAdapter;
		string conString = "URI=file:osoby.db";
		public Form1(int lastID)
		{
			
			InitializeComponent();
			textBox3.Text = (lastID+1).ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text=="" || textBox2.Text=="")
			{
				
			}
			else
			{
				con = new SQLiteConnection(conString);
				con.Open();
				string dotaz = "INSERT INTO Osoby(OsobaID, Jmeno, Prijmeni) VALUES("+textBox3.Text+", '"+textBox1.Text+"', '"+textBox2.Text+"')";
				dataAdapter = new SQLiteDataAdapter(dotaz, con);
				dataAdapter.SelectCommand.ExecuteNonQuery();
				con.Close();
				this.Close();
				Application.Restart();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

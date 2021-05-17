/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 15.05.2021
 * Time: 19:59
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
	
	public partial class Form2 : Form
	{
		SQLiteConnection con;
		DataSet dataSet = new DataSet();
		SQLiteDataAdapter dataAdapter;
		string conString = "URI=file:osoby.db";
		string jm;
		string prjm;
		public Form2(int ID, string jmeno, string prijmeni)
		{
			jm = jmeno;
			prjm = prijmeni;
			InitializeComponent();
			textBox1.Text = ID.ToString();
			textBox2.Text = jmeno;
			textBox3.Text = prijmeni;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox2.Text==jm && textBox3.Text==prjm || textBox2.Text=="" || textBox3.Text=="")
			{
				
			}
			else
			{
				con = new SQLiteConnection(conString);
				con.Open();
				string dotaz = "UPDATE Osoby SET Jmeno = '"+textBox2.Text+"', Prijmeni = '"+textBox3.Text+"' WHERE OsobaID = "+textBox1.Text+";";
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

/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 16.05.2021
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WinForms_MSSQL
{
	public partial class Form1 : Form
	{
		string conString = @"Data Source=localhost\MSSQL;Initial Catalog=Osoby;Integrated Security=True";
		SqlConnection con;
		
		public Form1()
		{
			InitializeComponent();
			
		}
		
		void Pridat(string jmeno, string prijmeni)
		{
			string dotaz = "INSERT INTO Osoba(Jmeno, Prijmeni) VALUES('"+jmeno+"', '"+prijmeni+"');";
			con = new SqlConnection(conString);
			con.Open();
			DataTable dtbl = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(dotaz, con);
			sda.SelectCommand.ExecuteNonQuery();
			con.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox2.Text=="" || textBox3.Text=="")
			{
				
			}
			else
			{
				Pridat(textBox2.Text, textBox3.Text);
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

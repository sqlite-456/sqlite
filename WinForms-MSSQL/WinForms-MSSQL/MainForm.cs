/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 16.05.2021
 * Time: 11:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WinForms_MSSQL
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string conString = @"Data Source=localhost\MSSQL;Initial Catalog=Osoby;Integrated Security=True";
		string sql = "SELECT * FROM Osoba";
		SqlConnection con;
		
		public MainForm()
		{
			
			InitializeComponent();
			SQLDotaz(sql);
		}
		
		void SQLDotaz(string dotaz)
		{
			con = new SqlConnection(conString);
			DataTable dtbl = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(dotaz, con);
			sda.Fill(dtbl);
			//sda.SelectCommand.ExecuteNonQuery();
			dataGridView1.DataSource = dtbl;
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
			Form frm1 = new Form1();
			frm1.Show();
		}
	}
}

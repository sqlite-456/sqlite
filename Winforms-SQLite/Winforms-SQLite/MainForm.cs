/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 15.05.2021
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace Winforms_SQLite
{
	public partial class MainForm : Form
	{
		SQLiteConnection con;
		DataSet dataSet = new DataSet();
		SQLiteDataAdapter dataAdapter;
		string uvodniDotaz = "select * from Osoby order by osobaID"; 
		string conString = "URI=file:osoby.db";
		int selectedID=0;
		
		public MainForm()
		{
			
			InitializeComponent();
			dataSet = GetData(uvodniDotaz);
			dataToGrid(dataSet);
			//naplint();
		}
		private void naplint()
		{
			con = new SQLiteConnection(conString);
			con.Open();
			//string dotaz1 = "CREATE TABLE Osoby (OsobaID int NOT NULL PRIMARY KEY, Jmeno varchar(255), Prijmeni varchar(255));";
			string dotaz1 = "INSERT INTO Osoby (OsobaID, Jmeno, Prijmeni) VALUES (02, 'Jan', 'Motička');";
			dataAdapter = new SQLiteDataAdapter(dotaz1, con);
			dataAdapter.SelectCommand.ExecuteNonQuery();
			//sda = new SQLiteDataAdapter(dotaz2, con);
			
			con.Close();
		}
		private DataSet GetData(string dotaz)
        {
            con = new SQLiteConnection(conString);
            con.Open();
            dataAdapter = new SQLiteDataAdapter(dotaz ,con);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "osoby");
            con.Close();
            
            return dataSet;
        }
		private void dataToGrid(DataSet ds)
		{
			dataGridView1.DataSource = ds.Tables[0];
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			GetData(uvodniDotaz);
			this.Refresh();
		}
		void Button1Click(object sender, EventArgs e)
		{
			//label1.Text = lastID().ToString();
			Form frm1 = new Form1(lastID());
			frm1.Show();
		}
		private int lastID()
		{
			string dotazLastID = "SELECT MAX(OsobaID) FROM Osoby";
			con = new SQLiteConnection(conString);
			con.Open();
			SQLiteCommand selectMaxCmd = new SQLiteCommand(dotazLastID, con);
			object val = selectMaxCmd.ExecuteScalar();
			int ID = int.Parse(val.ToString());
			con.Close();
			return ID;
		}
		void DataGridView1MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				/*ContextMenu m = new ContextMenu();
				m.MenuItems.Add(new MenuItem("Editovat"));
				m.MenuItems.Add(new MenuItem("Smazat"));*/
				ContextMenuStrip m = new ContextMenuStrip();
				
				int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
				
				if(currentMouseOverRow>=0 && currentMouseOverRow<lastID())
				{
					
					m.Items.Add("Editovat");
					m.Items.Add("Smazat");
					m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
					selectedID = int.Parse(currentMouseOverRow.ToString());
				}
				
				m.Show(dataGridView1, new Point(e.X, e.Y));
			}
		}
		void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			if(item.Text == "Editovat")
			{
				int id = int.Parse(dataGridView1.Rows[selectedID].Cells[0].Value.ToString());
				string jmeno = dataGridView1.Rows[selectedID].Cells[1].Value.ToString();
				string prijmeni = dataGridView1.Rows[selectedID].Cells[2].Value.ToString();
				Form frm2 = new Form2(id, jmeno, prijmeni);
				frm2.Show();
			}
			if(item.Text == "Smazat")
			{
				con = new SQLiteConnection(conString);
				con.Open();
				string dotaz = "DELETE FROM Osoby WHERE OsobaID="+dataGridView1.Rows[selectedID].Cells[0].Value.ToString()+";";
				dataAdapter = new SQLiteDataAdapter(dotaz, con);
				dataAdapter.SelectCommand.ExecuteNonQuery();
				con.Close();
				Application.Restart();
			}
		}
		private DataSet Data(string dotaz)
		{
			DataSet ds = new DataSet();
			dataAdapter.SelectCommand.CommandText = dotaz;
			dataAdapter.Fill(ds, "skupiny");
			return ds;
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			string dotaz ="SELECT * FROM Osoby WHERE "+comboBox1.Text+" LIKE '%"+textBox1.Text+"%' ORDER BY OsobaID;";
			ds = Data(dotaz);
			dataToGrid(ds);
			/*if(comboBox1.Text=="")
			{
				GetData(uvodniDotaz);
				dataToGrid(dataSet);
			}
			else
			{
				string dotaz ="SELECT * FROM Osoby WHERE "+comboBox1.Text+" LIKE '%"+textBox1.Text+"%' ORDER BY OsobaID;";
				GetData(dotaz);
				dataToGrid(dataSet);
			}*/
		}
	}
}

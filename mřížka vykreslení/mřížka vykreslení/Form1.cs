using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mřížka_vykreslení
{
    public partial class Form1 : Form
    {
        const int sirka = 10;
        int[,] Pole = new int[200, 200];
        long stridani = 0;
        bool nalezenkonec = false;
        Point bunka = new Point();
        bool mousedown = false;
        bool nalezenzacatek = false;
        Rectangle rec = new Rectangle();
        int PC;
        SolidBrush stetec = new SolidBrush(Color.Red);
        Color[] color = new Color[]{
        Color.Bisque,
        Color.Black,
        Color.Blue,
        Color.Orange,
        Color.Green,
        Color.Gold,
        Color.ForestGreen,
        Color.Firebrick,
        Color.Yellow,
        Color.Tomato,
        Color.LightGreen,
        Color.LightPink,
        Color.MediumPurple,
        Color.BurlyWood,
        Color.Aqua,
        Color.Bisque,
        Color.Black,
        Color.Blue,
        Color.Orange,
        Color.Green,
        Color.Gold,
        Color.ForestGreen,
        Color.Firebrick,
        Color.Yellow,
        Color.Tomato,
        Color.LightGreen,
        Color.LightPink,
        Color.MediumPurple,
        Color.BurlyWood,
        Color.PaleVioletRed,
        Color.Azure,
        Color.Aqua,
        Color.Bisque,
        Color.Black,
        Color.Blue,
        Color.Orange,
        Color.Green,
        Color.Gold,
        Color.ForestGreen,
        Color.Firebrick,
        Color.Yellow,
        Color.Tomato,
        Color.LightGreen,
        Color.LightPink,
        Color.MediumPurple,
        Color.BurlyWood,
        Color.PaleVioletRed,
        Color.Azure,
        Color.Aqua,
        Color.Bisque,
        Color.Black,
        Color.Blue,
        Color.Orange,
        Color.Green,
        Color.Gold,
        Color.ForestGreen,
        Color.Firebrick,
        Color.Yellow,
        Color.Tomato,
        Color.LightGreen,
        Color.LightPink,
        Color.MediumPurple,
        Color.BurlyWood,
        Color.PaleVioletRed,
        Color.Azure,
        Color.Aqua
        };
        Point zacatek = new Point(10, 10);

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < Pole.GetLength(0); i++)
    		{
        		for (int j = 0; j < Pole.GetLength(1); j++)
        		{
            		Pole[i, j] = 0;
        		}
    		}
        }

        private Point ZjistiBuňku(Point bk)
        {
            bunka.X = bk.X / 21;
            bunka.Y = bk.Y / 21;
            return bunka;
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point bod = e.Location;
            bunka = ZjistiBuňku(bod);
            if (Pole[bunka.X, bunka.Y] == 0)
            {
                Pole[bunka.X, bunka.Y] = -4;
            }
            else
                if (Pole[bunka.X, bunka.Y] == -4)
                {
                    Pole[bunka.X, bunka.Y] = 0;
                }
            tableLayoutPanel1.Refresh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            SolidBrush stetec4 = new SolidBrush(Color.Green);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Pole[i, j] == -4)
                    {
                        rec = new Rectangle(i * 21, j * 21, 21, 21);
                        gr.FillRectangle(stetec, rec);
                    }
                    
                    if (Pole[i, j] == -5)
                    {
                        rec = new Rectangle(i * 21, j * 21, 21, 21);
                        gr.FillRectangle(stetec4, rec);
                    }
                    
                    if (Pole[i, j] == -2)
                    {
                    	Rectangle rec1 = new Rectangle(i*21,j*21,20,20);
                    	  Font font = new Font ("Arial", 16);
                    	  SolidBrush stetec1 = new SolidBrush(Color.Blue);
                    	  gr.DrawString("Z",font,stetec1,rec1);
                    	
                      /*  Pen peroZ = new Pen(Color.Green,2);
                        gr.DrawLine(peroZ,i*21,j*21,i*21+20,j*21);
                        gr.DrawLine(peroZ,i*21+20,j*21,i*21,j*21+20);
                        gr.DrawLine(peroZ, i * 21, j * 21 + 20, i * 21 + 20, j * 21 + 20); */
                    }
                    
                    if (Pole[i, j] == -3)
                    {
                    	Rectangle rec2 = new Rectangle(i*21,j*21,20,20);
                    	  Font font = new Font ("Arial", 16);
                    	  SolidBrush stetec2 = new SolidBrush(Color.Purple);
                    	  gr.DrawString("K",font,stetec2,rec2);
                    	
                    /*	Pen peroK = new Pen(Color.Red,2);
                        gr.DrawLine(peroK,i*21,j*21,i*21,j*21+21);
                        gr.DrawLine(peroK,i*21+20,j*21,i*21,j*21+10);
                        gr.DrawLine(peroK, i * 21, j * 21 + 10, i * 21 + 20, j * 21 + 20);*/
                    }
                    
                    if (Pole[i, j] > 0)
                    {
                        rec = new Rectangle(i * 21, j * 21, 20, 20);
                        Font font2 = new System.Drawing.Font("Times New Roman", 10);
                        SolidBrush stetec3 = new SolidBrush(color[Pole[i, j]]);
                        gr.DrawString(Convert.ToString(Pole[i, j]), font2, stetec3, rec);
                    }

                }
            }
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                Point bod = (new Point(e.X, e.Y));
                bunka = ZjistiBuňku(bod);
                if(Pole[bunka.X,bunka.Y] == 0)
                {
                    Pole[bunka.X, bunka.Y] = -4;
                }
            }
        }


        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
		void Label1MouseDown(object sender, MouseEventArgs e)
		{
			Label zdroj = (Label)sender;
            DoDragDrop(zdroj.Text, DragDropEffects.Copy);
		}
		void label1_Mousedown(object sender, MouseEventArgs e)
		{
			Label zdroj = (Label)sender;
            DoDragDrop(zdroj.Text, DragDropEffects.Copy);
		}
		void TableLayoutPanel1DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}
		void TableLayoutPanel1DragDrop(object sender, DragEventArgs e)
		{
			TableLayoutPanel prijemce = (TableLayoutPanel)sender;
			
			if(e.Data.GetDataPresent(typeof(string)))
			{
				string napis = (String)e.Data.GetData(typeof(String));
				if(napis =="Začátek")
				{
					Point bod = this.PointToClient(new Point(e.X,e.Y));
					bunka = ZjistiBuňku(bod);
					Pole[bunka.X,bunka.Y]=-2;
					tableLayoutPanel1.Refresh();
				}
				if(napis =="Konec")
				{
					Point bod = this.PointToClient(new Point(e.X,e.Y));
					bunka = ZjistiBuňku(bod);
					Pole[bunka.X,bunka.Y]=-3;
					tableLayoutPanel1.Refresh();
				}
			}
		}
		void Label2MouseDown(object sender, MouseEventArgs e)
		{
			Label zdroj = (Label)sender;
            DoDragDrop(zdroj.Text, DragDropEffects.Copy);
		}

        private void Delejvlnu(int i)
        { 
            Graphics gr = CreateGraphics();
            for (int g = 0; g < 20; g++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Pole[g, j] == i)
                    {
                        #region Podmínka když je i rovno 1
                        if (i == 1)
                        {
                            #region Prikazy na vykreslovani jednicek
                            if (Pole[g, j] == Pole[g, 0] && Pole[g, j] != Pole[0, 0] && Pole[g, j] != Pole[19, 0])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g +1, j] != -2)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		break;
                                	}
                                	else
                                	{
                                		Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		break;
                                	}
                                	else
                                	{
                                    	Pole[g - 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		break;
                                	}
                                	else
                                	{
                                    	Pole[g, j + 1] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[g, 19] && Pole[g, j] != Pole[0, 19] && Pole[g, j] != Pole[19, 19])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g +1, j] != -2)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		break;
                                	}
                                	else
                                	{
                                    	Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = i + 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }
                            }
                            else if (Pole[g, j] == Pole[0, j] && Pole[g, j] != Pole[0, 0] && Pole[g, j] != Pole[0, 19])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g +1, j] != -2)
                                {
                                    Pole[g + 1, j] = i + 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                    Pole[g, j + 1] = i + 1;
                                }
                            }

                            else if (Pole[g, j] == Pole[19, j] && Pole[g, j] != Pole[19, 19] && Pole[g, j] != Pole[19, 0])
                            {
                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = i + 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                    Pole[g, j + 1] = i + 1;
                                }
                            }

                            else if (Pole[g, j] == Pole[0, 0])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g +1, j] != -2)
                                {
                                    Pole[g + 1, j] = i + 1;
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                    Pole[g, j + 1] = i + 1;
                                }
                            }

                            else if (Pole[g, j] == Pole[19, 19])
                            {
                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }
                            }

                            else if (Pole[g, j] == Pole[19, 0])
                            {

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                    Pole[g, j + 1] = i + 1;
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = i + 1;
                                }
                            }

                            else if (Pole[g, j] == Pole[0, 19])
                            {
                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = i + 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }
                            }
                            else
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2)
                                {
                                    Pole[g + 1, j] = i + 1;
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2)
                                {
                                    Pole[g - 1, j] = i + 1;
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2)
                                {
                                    Pole[g, j - 1] = i + 1;
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2)
                                {
                                    Pole[g, j + 1] = i + 1;
                                }
                            }
                        }
                            #endregion
                        #endregion
                        #region Podmínka když i je větší než jedna
                        else //Upravit doma !!
                        {
                            if (Pole[g, j] == Pole[g, 0] && Pole[g, j] != Pole[0, 0] && Pole[g, j] != Pole[19, 0])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else
                                	{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2 && Pole[g - 1, j] < i-1)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else
                                	{
                                    	Pole[g - 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                               		else
                               		{
                                    	Pole[g, j + 1] = i + 1;
                               		}
                                }
                            }

                            else if (Pole[g, j] == Pole[g, 19] && Pole[g, j] != Pole[0, 19] && Pole[g, j] != Pole[19, 19])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else
                                	{
                                    	Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2 && Pole[g - 1, j] < i-1)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g - 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] < i-1)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j - 1] = i + 1;
                                	}
                                }
                            }
                            else if (Pole[g, j] == Pole[0, j] && Pole[g, j] != Pole[0, 0] && Pole[g, j] != Pole[0, 19])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] < i-1)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    	Pole[g, j - 1] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j + 1] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[19, j] && Pole[g, j] != Pole[19, 19] && Pole[g, j] != Pole[19, 0])
                            {
                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2 && Pole[g - 1, j] < i-1)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g - 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] < i-1)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j - 1] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j + 1] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[0, 0])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    	Pole[g, j + 1] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[19, 19])
                            {
                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2 && Pole[g - 1, j] < i-1)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g - 1, j] = 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] < i-1)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j - 1] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[19, 0])
                            {

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j + 1] = i + 1;
                                	}
                                }

                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }
                            }

                            else if (Pole[g, j] == Pole[0, 19])
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] <= i)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j - 1] = i + 1;
                                	}
                                }
                            }
                            else
                            {
                                if (Pole[g + 1, j] != -4 && Pole[g + 1, j] != -2 && Pole[g + 1, j] < i-1)
                                {
                                	if(Pole[g + 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g + 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g - 1, j] != -4 && Pole[g - 1, j] != -2 && Pole[g - 1, j] < i-1)
                                {
                                	if(Pole[g - 1, j] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g - 1, j] = i + 1;
                                	}
                                }

                                if (Pole[g, j - 1] != -4 && Pole[g, j - 1] != -2 && Pole[g, j - 1] < i-1)
                                {
                                	if(Pole[g, j - 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j - 1] = i + 1;
                                	}
                                }

                                if (Pole[g, j + 1] != -4 && Pole[g, j + 1] != -2 && Pole[g, j + 1] < i-1)
                                {
                                	if(Pole[g, j + 1] == -3)
                                	{
                                		nalezenkonec = true;
                                		PC = i;
                                		break;
                                	}
                                	else{
                                    Pole[g, j + 1] = i + 1;
                                	}
                                }
                                #endregion
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Pole[i, j] == -2)
                    {
                        #region Prikazy na vykreslovani jednicek
                        if (Pole[i, j] == Pole[i, 0] && Pole[i, j] != Pole[0, 0] && Pole[i, j] != Pole[19, 0])
                        { 
                        if (Pole[i + 1, j] != -4)
                        {
                            Pole[i + 1, j] = 1;
                        }

                        if (Pole[i - 1, j] != -4)
                        {
                            Pole[i - 1, j] = 1;
                        }

                        if (Pole[i, j + 1] != -4)
                        {
                            Pole[i, j + 1] = 1;
                        }
                        }

                        else if (Pole[i, j] == Pole[i, 19] && Pole[i, j] != Pole[0, 19] && Pole[i, j] != Pole[19, 19])
                        {
                            if (Pole[i + 1, j] != -4)
                            {
                                Pole[i + 1, j] = 1;
                            }

                            if (Pole[i - 1, j] != -4)
                            {
                                Pole[i - 1, j] = 1;
                            }

                            if (Pole[i, j - 1] != -4)
                            {
                                Pole[i, j - 1] = 1;
                            }
                        }
                        else if (Pole[i, j] == Pole[0, j] && Pole[i, j] != Pole[0, 0] && Pole[i, j] != Pole[0, 19])
                        {
                            if (Pole[i + 1, j] != -4)
                            {
                                Pole[i + 1, j] = 1;
                            }

                            if (Pole[i, j-1] != -4)
                            {
                                Pole[i, j-1] = 1;
                            }

                            if (Pole[i, j + 1] != -4)
                            {
                                Pole[i, j + 1] = 1;
                            }
                        }

                        else if (Pole[i, j] == Pole[19, j] && Pole[i, j] != Pole[19, 19] && Pole[i, j] != Pole[19, 0])
                        {
                            if (Pole[i - 1, j] != -4)
                            {
                                Pole[i - 1, j] = 1;
                            }

                            if (Pole[i, j - 1] != -4)
                            {
                                Pole[i, j - 1] = 1;
                            }

                            if (Pole[i, j + 1] != -4)
                            {
                                Pole[i, j + 1] = 1;
                            }
                        }
                        
                        else if (Pole[i, j] == Pole[0, 0])
                        {
                            if (Pole[i + 1, j] != -4)
                            {
                                Pole[i + 1, j] = 1;
                            }

                            if (Pole[i, j + 1] != -4)
                            {
                                Pole[i, j + 1] = 1;
                            }
                        }

                       else if (Pole[i, j] == Pole[19, 19])
                        {
                            if (Pole[i - 1, j] != -4)
                            {
                                Pole[i - 1, j] = 1;
                            }

                            if (Pole[i, j - 1] != -4)
                            {
                                Pole[i, j - 1] = 1;
                            }
                        }

                        else if (Pole[i, j] == Pole[19, 0])
                        {

                            if (Pole[i, j + 1] != -4)
                            {
                                Pole[i, j + 1] = 1;
                            }

                            if (Pole[i-1, j] != -4)
                            {
                                Pole[i-1, j] = 1;
                            }
                        }

                        else if (Pole[i, j] == Pole[0, 19])
                        {
                            if (Pole[i + 1, j] != -4)
                            {
                                Pole[i + 1, j] = 1;
                            }

                            if (Pole[i, j - 1] != -4)
                            {
                                Pole[i, j - 1] = 1;
                            }
                        }
                        else 
                        {
                            if (Pole[i + 1, j] != -4)
                            {
                                Pole[i + 1, j] = 1;
                            }

                            if (Pole[i - 1, j] != -4)
                            {
                                Pole[i - 1, j] = 1;
                            }

                            if (Pole[i, j - 1] != -4)
                            {
                                Pole[i, j - 1] = 1;
                            }

                            if (Pole[i, j + 1] != -4)
                            {
                                Pole[i, j + 1] = 1;
                            }
                        }
                        #endregion
                    }
                }
            }

            for (int i = 1; i < 100; i++)
            {
            	if(nalezenkonec == false)
            	{
                	Delejvlnu(i);
            	}
            }
            tableLayoutPanel1.Refresh();
        }
        
        public void NakresliCestu(int cislo)
        {
        	#region Nakreslí cestu
        	Graphics gr = CreateGraphics();
        	if(nalezenzacatek == false)
        	{
	        	for (int i = 0; i < 20; i++)
	            {
	                for (int j = 0; j < 20; j++)
	                {
	                	if(Pole[i,j] == -5)
	                	{
	                		if(Pole[i+1, j] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i+1,j] == cislo)
	                		{
	                			Pole[i+1,j] = -5;
	                			break;
	                		}
	                		if(Pole[i-1, j] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i-1,j] == cislo)
	                		{
	                			Pole[i-1,j] = -5;
	                			break;
	                		}
	                		if(Pole[i, j + 1] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i,j + 1] == cislo)
	                		{
	                			Pole[i,j + 1] = -5;
	                			break;
	                		}
	                		if(Pole[i, j - 1] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i,j - 1] == cislo)
	                		{
	                			Pole[i,j - 1] = -5;
	                			break;
	                		}
	                	}
	                }
	        	}
        	}
        	PC--;
        	#endregion
        }
		void Button2Click(object sender, EventArgs e)
		{
			if(nalezenzacatek == false)
        	{
	        	for (int i = 0; i < 20; i++)
	            {
	                for (int j = 0; j < 20; j++)
	                {
	                	if(Pole[i,j] == -3)
	                	{
	                		if(Pole[i+1, j] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i+1,j] == PC)
	                		{
	                			Pole[i+1,j] = -5;
	                			PC --;
	                		}
	                		if(Pole[i-1, j] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i-1,j] == PC)
	                		{
	                			Pole[i-1,j] = -5;
	                			PC --;
	                			break;
	                		}
	                		if(Pole[i, j + 1] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i,j + 1] == PC)
	                		{
	                			Pole[i,j + 1] = -5;
	                			PC --;
	                			break;
	                		}
	                		if(Pole[i, j - 1] == -2)
	                		{
	                			nalezenzacatek = true;
	                			break;
	                		}
	                		else if(Pole[i,j - 1] == PC)
	                		{
	                			Pole[i,j - 1] = -5;
	                			PC --;
	                			break;
	                		}
	                	}
	                }
	        	}
        	}
		
			do{
				NakresliCestu(PC);
				
			}while(nalezenzacatek == false);
			tableLayoutPanel1.Refresh();
		}
    }
}

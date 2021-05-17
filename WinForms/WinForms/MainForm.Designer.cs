/*
 * Created by SharpDevelop.
 * User: MATEJ
 * Date: 25.02.2021
 * Time: 9:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jméno";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(102, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(174, 22);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Příjmení";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(102, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(174, 22);
			this.textBox2.TabIndex = 3;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(378, 226);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(251, 472);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 43);
			this.button1.TabIndex = 5;
			this.button1.Text = "Odeslat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(102, 70);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(64, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Kolo";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Vlastním";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(102, 100);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(64, 24);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Auto";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(102, 130);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(87, 24);
			this.checkBox3.TabIndex = 9;
			this.checkBox3.Text = "Dodávka";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(303, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 39);
			this.label4.TabIndex = 10;
			this.label4.Text = "Oblíbený den";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(6, 21);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Muž";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(27, 160);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(249, 133);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pohlaví";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(139, 51);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(104, 50);
			this.radioButton4.TabIndex = 14;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Nechci uvádět";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(6, 64);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(63, 24);
			this.radioButton3.TabIndex = 13;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Jiné";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(139, 21);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Žena";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Pondělí",
			"Úterý",
			"Středa",
			"Čtvrtek",
			"Pátek",
			"Sobota",
			"Neděle",
			"Žádný den"});
			this.comboBox1.Location = new System.Drawing.Point(378, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(207, 24);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(378, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(207, 169);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(303, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Datum";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 527);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "WinForms";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

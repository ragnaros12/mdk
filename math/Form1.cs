using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int max = 0;
			int first = Convert.ToInt32(textBox1.Text), 
				second = Convert.ToInt32(textBox1.Text);
			switch (comboBox1.SelectedIndex)
			{
				case 0:
					max = first + second;
					break;
				case 1:
					max = first - second;
					break;
				case 2:
					max = first * second;
					break;
				case 3:
					max = first / second;
					break;
			}
			label3.Text = Convert.ToString(max);
		}
	}
}

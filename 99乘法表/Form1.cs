using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99乘法表
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			int firstNumber = GetFirstNumber();
			string table = RengerSingleTable(firstNumber);
			textBox1.Text = table;
		}

		private string RengerSingleTable(int firstNumber)
		{
			string result = string.Empty;
			for(int i=1;i<=9;i++)
			{
				result += $"{firstNumber}*{i}={firstNumber * i}\r\n";
			}
			return result;
		}

		

		private int GetFirstNumber()
		=>Convert.ToInt32(comboBox1.SelectedItem);
	}
}

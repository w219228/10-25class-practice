using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四則運算
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			int firstnumber,secondnumber;

			try
			{
				firstnumber = GetFistNumber();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			try
			{
				secondnumber = GetSecondNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			string operation;
			try
			{
				operation = GetOpration();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			int result;
			try
			{
				result = calc(firstnumber,secondnumber,operation);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private int calc(int firstnumber, int secondnumber, string operation)
		{
			switch(operation)
			{
				case "+":
					return firstnumber + secondnumber;
				case "-":
					return firstnumber - secondnumber;
				case "*":
					return firstnumber * secondnumber;
				case "/":
					return firstnumber / secondnumber;
			}
			throw new Exception($"不支援此計算方式{operation}");
		}

		private string GetOpration()
		{
			ComboBox control = this.optionComboBox;
			object selectedItem = control.SelectedItem;

			return selectedItem != null
				? selectedItem.ToString()
				: throw new Exception("請輸入運算方式");

		}

		private int GetIn(TextBox control,string title)
		{
			string value = control.Text;
			bool IsInt = int.TryParse(value, out int number);
			return IsInt ? number : throw new Exception($"{title}必須寫數值");
		}
		
		private int GetSecondNumber()
		{
			TextBox txt = secoundNumberTextBox;
			string title = "第二個數";
			return GetIn(txt, title);
		}

		private int GetFistNumber()
		{
			TextBox txt = firstNumberTextBox;
			string title = "第一個數";
			return GetIn(txt, title);
		}
	}
}

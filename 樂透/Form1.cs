using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 樂透
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void drawButton_Click(object sender, EventArgs e)
		{
			Lottery lottery = new Lottery();
			int[] number = lottery.Draw(49, 6);

			Array.Sort(number);
			string msg = string.Join(",", number);
			label1.Text = msg;
		}
	}
	
	public class Lottery
	{
		/// <summary>
		/// 從多個數字中,取出N個不重複的值
		/// </summary>
		/// <param name="number">1~number是取亂數的對象</param>
		/// <param name="drawNumber">要娶幾個不重複的值</param>
		/// <returns>傳回陣列,內容不重複的值</returns>
		public int[] Draw (int number,int drawNumber)
		{
			if(number<=drawNumber)
			{

			}
			return new int[] { 1, 25, 4, 43, 53 };
		}
	}
		
}

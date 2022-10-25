using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
	public partial class Loginform : Form
	{
		public Loginform()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			//todo 判斷密碼是否正確
			//開啟form
			Form1 frm = new Form1();
			frm.Owner = this;
			frm.Show();
			this.Hide(); 
		}
	}
}

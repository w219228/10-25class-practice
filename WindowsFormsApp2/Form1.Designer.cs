namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.哈囉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ㄎㄎㄅToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ㄅㄅToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.哈囉ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.form2ToolStripMenuItem.Text = "Form2";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.form1ToolStripMenuItem.Text = "Form3";
			this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
			// 
			// 哈囉ToolStripMenuItem
			// 
			this.哈囉ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ㄎㄎㄅToolStripMenuItem,
            this.ㄅㄅToolStripMenuItem});
			this.哈囉ToolStripMenuItem.Name = "哈囉ToolStripMenuItem";
			this.哈囉ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.哈囉ToolStripMenuItem.Text = "哈囉(&M)";
			// 
			// ㄎㄎㄅToolStripMenuItem
			// 
			this.ㄎㄎㄅToolStripMenuItem.Name = "ㄎㄎㄅToolStripMenuItem";
			this.ㄎㄎㄅToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ㄎㄎㄅToolStripMenuItem.Text = "ㄎㄎㄅ";
			// 
			// ㄅㄅToolStripMenuItem
			// 
			this.ㄅㄅToolStripMenuItem.Name = "ㄅㄅToolStripMenuItem";
			this.ㄅㄅToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ㄅㄅToolStripMenuItem.Text = "ㄅㄅ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 哈囉ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ㄎㄎㄅToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ㄅㄅToolStripMenuItem;
	}
}


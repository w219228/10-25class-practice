namespace 四則運算
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
			this.calcButton = new System.Windows.Forms.Button();
			this.firstNumberTextBox = new System.Windows.Forms.TextBox();
			this.secoundNumberTextBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.optionComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(463, 109);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 0;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// firstNumberTextBox
			// 
			this.firstNumberTextBox.Location = new System.Drawing.Point(83, 82);
			this.firstNumberTextBox.Name = "firstNumberTextBox";
			this.firstNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.firstNumberTextBox.TabIndex = 1;
			// 
			// secoundNumberTextBox
			// 
			this.secoundNumberTextBox.Location = new System.Drawing.Point(345, 81);
			this.secoundNumberTextBox.Name = "secoundNumberTextBox";
			this.secoundNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.secoundNumberTextBox.TabIndex = 2;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(484, 85);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(56, 12);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "resultLabel";
			// 
			// optionComboBox
			// 
			this.optionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.optionComboBox.FormattingEnabled = true;
			this.optionComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.optionComboBox.Location = new System.Drawing.Point(213, 82);
			this.optionComboBox.Name = "optionComboBox";
			this.optionComboBox.Size = new System.Drawing.Size(121, 20);
			this.optionComboBox.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 281);
			this.Controls.Add(this.optionComboBox);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.secoundNumberTextBox);
			this.Controls.Add(this.firstNumberTextBox);
			this.Controls.Add(this.calcButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.TextBox firstNumberTextBox;
		private System.Windows.Forms.TextBox secoundNumberTextBox;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.ComboBox optionComboBox;
	}
}


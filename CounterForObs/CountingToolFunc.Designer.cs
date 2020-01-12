namespace CounterForObs
{
	partial class CountingToolFunc
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(63, 167);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 61);
			this.button3.TabIndex = 2;
			this.button3.Text = "-";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(63, 273);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 61);
			this.button2.TabIndex = 3;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Location = new System.Drawing.Point(330, 64);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(402, 61);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.textBox2.Location = new System.Drawing.Point(330, 206);
			this.textBox2.MaxLength = 1;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(103, 22);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(327, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Count";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(327, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(214, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "ケタ数(1-9までの半角数字を入力)";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(327, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(420, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "OBSの「テキスト(UTF-8)」の項目に表示されるパスを貼り付けてください";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(330, 312);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(417, 22);
			this.textBox3.TabIndex = 9;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// CountingToolFunc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 446);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Name = "CountingToolFunc";
			this.Text = "CounterForOBS";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
	}
}


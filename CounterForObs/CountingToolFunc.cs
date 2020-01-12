using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Copyright (c) 2020 Kazanagi Kotoha
 * Released under the MIT license
 * https://github.com/KotohaKazanagi/individual-app/blob/master/Licensed.txt
 */

namespace CounterForObs
{
	public partial class CountingToolFunc : Form
	{
		
		// 定数設定
		private const int START_NUM = 0; // 初期値
		private const int MAX_COUNT = int.MaxValue; // 最大値
		private const String EMPTY = ""; // 空文字
		private const String FILE_NAME = @"\memorizedCount.txt"; // 出力ファイル名
		private readonly String fullPath; // 出力される作業ファイルのフルパス
		

		public CountingToolFunc()
		{
			InitializeComponent();

			// カレントディレクトリのパスを取得
			fullPath = Directory.GetCurrentDirectory()+FILE_NAME;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 0埋めフォーマット
			String dealNum = AjustFormat.fillDigit(textBox2.Text, START_NUM.ToString());

			// テキストボックスに初期値適用
			textBox1.Text = dealNum;

			// 作業用ファイルのフルパスをテキストボックスに表示
			textBox3.Text = fullPath;

			//作業用ファイル作成・書き込み
			InOutFile.writeNum(dealNum, fullPath);

		}

		// 値を1加算
		private void Button1_Click(object sender, EventArgs e)
		{
			// フォーマットなしの数字を保持
			int num;
			int.TryParse(textBox1.Text, out num);

			// 値がint型の範囲を超える場合、値をint型の最大値とする
			if (num>= MAX_COUNT)
			{
				num = MAX_COUNT;
			}
			else
			{
				num = ++num;
			}

			// 0埋めフォーマット
			String dealNum = AjustFormat.fillDigit(textBox2.Text, num.ToString());

			// 加算した結果をファイルに書き込み
			InOutFile.writeNum(dealNum, fullPath);

			textBox1.Text= dealNum;
		}

		// 値を1減算
		private void Button3_Click(object sender, EventArgs e)
		{
			// フォーマットなしの数字を保持
			int num;
			int.TryParse(textBox1.Text, out num);

			// 値が0以下となる場合、0にする
			if (num <= START_NUM)
			{
				num = START_NUM;
			}
			else
			{
				num = --num;
			}


			String dealNum = AjustFormat.fillDigit(textBox2.Text, num.ToString());

			// 減算した結果を書き込み
			InOutFile.writeNum(dealNum, fullPath);

			textBox1.Text = dealNum;

		}

		// 値を初期値にリセット
		private void Button2_Click(object sender, EventArgs e)
		{
			// 0埋めフォーマット
			String dealNum = AjustFormat.fillDigit(textBox2.Text, START_NUM.ToString());

			// テキストボックスに初期値適用
			textBox1.Text = dealNum;

			//作業用ファイル作成・書き込み
			InOutFile.writeNum(dealNum, fullPath);
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		// 半角数字以外が入力されたとき、強制的に入力値をクリアする
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			// フォーマットなしの数字を保持
			int num;
			int.TryParse(textBox1.Text, out num);

			Regex notIntReg = new Regex(@"[^1-9]"); //数字以外にマッチする

			// 半角数字以外は強制的にクリア
			textBox2.Text = notIntReg.Replace(textBox2.Text, EMPTY);

			// 0埋めフォーマット
			String dealNum = AjustFormat.fillDigit(textBox2.Text, num.ToString());

			textBox1.Text = dealNum;

			InOutFile.writeNum(dealNum, fullPath);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

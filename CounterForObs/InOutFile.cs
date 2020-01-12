using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Copyright (c) 2020 Kazanagi Kotoha
 * Released under the MIT license
 * https://github.com/KotohaKazanagi/individual-app/blob/master/Licensed.txt
 */


namespace CounterForObs
{
	public static class InOutFile
	{
		// ファイル書き込み
		public static void writeNum(String num,String path)
		{
			// ファイル上書き・書き込みのみ・排他制御は読込のみ許可
			using (var fs = new FileStream(
				path
				,FileMode.Create
				,FileAccess.Write
				,FileShare.Read)
				)
			{
				using (var writer = new StreamWriter(fs))
				{
					// 数字をファイルに書き込み
					writer.Write(num);

					writer.Close();
				}

				fs.Close();
			}
		}
		
	}
}

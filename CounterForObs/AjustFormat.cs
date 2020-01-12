using System;
using System.Collections.Generic;
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
	public static class AjustFormat
	{
		private const char FILL_CHAR = '0';

		// 指定した桁数分0埋めを行う
		public static String fillDigit(String numOfDigit,String num)
		{
			int numOfDigitInt;
			int.TryParse(numOfDigit,out numOfDigitInt);

			return num.PadLeft(numOfDigitInt, FILL_CHAR);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public class TextFormatStrategy : IFormatStrategy
	{
		public string Format(string message, DateTime timestamp) =>
			$"[{timestamp:yyyy-MM-dd HH:mm:ss}] {message}";
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public class ConsoleHandler(IFormatStrategy strategy) : EventHandlerBase(strategy)
	{
		public override string FormatMessage(string type, object data)
		{
			return $"{type}: {data}";
		}

		public override void LogResult()
		{
			Console.WriteLine("[ConsoleHandler]: Уведомление отправлено");
		}

		public override void SendMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}

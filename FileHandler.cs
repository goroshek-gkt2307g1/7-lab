using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public class FileHandler : EventHandlerBase
	{
		private readonly string _filePath;

		public FileHandler(IFormatStrategy strategy, string filePath = "test.txt") : base(strategy)
		{
			_filePath = filePath;
		}


		public override string FormatMessage(string type, object data)
		{
			return $"{type}: {data}";
		}

		public override void LogResult()
		{
			Console.WriteLine("[FileHandler]: Уведомление отправлено");
		}

		public override void SendMessage(string message)
		{
			try
			{
				System.IO.File.AppendAllText(_filePath, message);
				Console.Write($"[FileHandler]: Записано в {_filePath}\n");
			}
			catch(Exception ex) 
			{
				Console.Write($"[FileHandler]: Ошибка записи - {ex.Message}");
			}
		}
	}
}

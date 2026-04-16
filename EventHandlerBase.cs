using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
	public abstract class EventHandlerBase
	{
		protected IFormatStrategy _formatStrategy; //текущая реализация
		protected EventHandlerBase(IFormatStrategy strategy) 
		{
			_formatStrategy = strategy;
		}

		//метод установки стратегии
		public void SetStrategy(IFormatStrategy strategy)
		{
			_formatStrategy = strategy;
		}

		//метод определения последовательности вызовов
		public void ProcessEvent(MetricEventArgs e)
		{
			var message = _formatStrategy.Format(
				FormatMessage(e.EventType, e.Data), DateTime.Now); //форматируем по стратегии
			SendMessage(message); //отправляем увед
			LogResult(); //логируем рез (опционально)
		}

		public abstract string FormatMessage(string type, object data);
		public abstract void SendMessage(string message);
		public abstract void LogResult();

	}
	
}
